using Library_Domain.Objects.Genre;
using Library_DTO.Builders;
using Library_DTO.UOW;
using Library_Persistence.UnitOfWork;
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
            DisableButtons();
            LoadGenres();
        }

        void LoadGenres()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listGenres = uow.Genres.GetAll().ToList();
                    dataGridView1.DataSource = _listGenres;
                    dataGridView1.Columns["GenreID"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void EnableButtons() 
        {
            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
        }

        void DisableButtons() 
        {
            DeleteButton.Enabled = false;
            UpdateButton.Enabled = false;
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
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _genre.GenreName(textBoxGenreLabel.Text.ToString());
                    var genre = _genre.Build();
                    uow.Genres.Add(genre);
                    uow.Save();
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
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _genre.GenreName(textBoxGenreLabel.Text.ToString());
                    var genre = _genre.Build();
                    uow.Genres.Update(genre);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DisableButtons();
            Clear();
            LoadGenres();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    var genre = _genre.Build();
                    uow.Genres.Remove(genre);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DisableButtons();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //_genre.GenreID(long.Parse(dataGridView1.Rows[e.RowIndex].Cells["genreid"].Value.ToString()));
            //_genre.GenreName(dataGridView1.Rows[e.RowIndex].Cells["genrename"].Value.ToString());
            //textBoxGenreLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["genrename"].Value.ToString();
            //EnableButtons();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {
                dataGridView1.ClearSelection();
            }
            else
            {
                int a = dataGridView1.CurrentCell.RowIndex;
                _genre.GenreID(long.Parse(dataGridView1.Rows[a].Cells["GenreID"].Value.ToString()));
                _genre.GenreName(dataGridView1.Rows[a].Cells["GenreName"].Value.ToString());
                textBoxGenreLabel.Text = dataGridView1.Rows[a].Cells["GenreName"].Value.ToString();
                EnableButtons();
            }
        }
    }
}
