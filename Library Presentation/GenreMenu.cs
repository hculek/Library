using Library_Domain.Objects.Genre;
using Library_DTO.Builders;
using Library_DTO.UOW;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library_Presentation
{
    public partial class GenreMenu : UserControl
    {
        private GenreBuilder _genre = new GenreBuilder();
        private List<Genre> _listGenres = new List<Genre>();


        public GenreMenu()
        {
            InitializeComponent();
            ToggleButtons(false);
            LoadGenres();
        }

        void LoadGenres()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listGenres = uow.Genres.Get().OrderBy(g => g.GenreName).ToList();
                    dataGridView1.DataSource = _listGenres;
                    dataGridView1.Columns["GenreID"].Visible = false;
                    dataGridView1.Columns["Books"].Visible = false;
                    dataGridView1.Columns["GenreName"].HeaderText = "Genre Name";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        void ToggleButtons(bool input) 
        {
            DeleteButton.Enabled = input;
            UpdateButton.Enabled = input;
            ClearButton.Enabled = input ? false : true;
        }

        void Clear() 
        {
            _genre.Reset();
            dataGridView1.ClearSelection();
            textBoxSearch.Clear();
            textBoxGenreLabel.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _genre.GenreName(textBoxGenreLabel.Text.Trim());
                var genre = _genre.Build();

                if(!_listGenres.Any(g => g.GenreName == genre.GenreName))
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Add(genre);
                        uow.Save();
                    }
                }
                else
                {
                    MessageBox.Show("Error!" +
                        "\nGenre with that name exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Clear();
            LoadGenres();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _genre.GenreName(textBoxGenreLabel.Text.Trim());
                var genre = _genre.Build();

                using (var uow = UnitOfWorkFactory.Create())
                {
                    uow.Genres.Update(genre);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            Clear();
            LoadGenres();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var genre = _genre.Build();

                using (var uow = UnitOfWorkFactory.Create())
                {

                    uow.Genres.Remove(genre);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            Clear();
            LoadGenres();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            LoadGenres();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var _searchedList = _listGenres.Select(item => item);
            if (!String.IsNullOrEmpty(textBoxSearch.Text.ToString()))
            {
                _searchedList = _searchedList.Where(item => item.GenreName.Contains(textBoxSearch.Text.ToString()));
                dataGridView1.DataSource = _searchedList.ToList();
            }
            else
            {
                Clear();
                LoadGenres();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                _genre.GenreID(long.Parse(dataGridView1.Rows[a].Cells["GenreID"].Value.ToString()));
                _genre.GenreName(dataGridView1.Rows[a].Cells["GenreName"].Value.ToString());
                textBoxGenreLabel.Text = dataGridView1.Rows[a].Cells["GenreName"].Value.ToString();
                ToggleButtons(true);
            }
            LoadGenres();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
            ToggleButtons(false);
        }
    }
}
