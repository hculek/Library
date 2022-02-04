using Library_Domain.Objects.Genre;
using Library_DTO.Builders;
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
        private GenreBuilder _genreSelected = new GenreBuilder();
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
                var context = new Library_Persistence.ApplicationContext();
                using (var uow = new UnitOfWork(context))
                {
                    _listGenres = uow.Genres.GetAll().ToList();
                    dataGridView1.DataSource = _listGenres;
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
            _genreSelected.Reset();
            dataGridView1.ClearSelection();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //using (var uow = UnitOfWorkFactory.Create())
                //{
                //    _genre.GenreName(textBox1.Text.ToString());
                //    var genre = _genre.Build();
                //    uow.Genres.Add(genre);
                //}

                var context = new Library_Persistence.ApplicationContext();
                using (var uow = new UnitOfWork(context))
                {
                    _genre.GenreName(textBox2.Text.ToString());
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
                var context = new Library_Persistence.ApplicationContext();
                using (var uow = new UnitOfWork(context))
                {
                    _genreSelected.GenreName(textBox2.Text.ToString());
                    var genre = _genreSelected.Build();
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
                var context = new Library_Persistence.ApplicationContext();
                using (var uow = new UnitOfWork(context))
                {
                    _genreSelected.GenreName(textBox2.Text.ToString());
                    var genre = _genreSelected.Build();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("LIKE %'{1}'", textBox1.Text);

                // (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%' OR ID LIKE '%{0}%'", searchTextBox.Text);
            }
            else
            {
                Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {
                dataGridView1.ClearSelection();
            }
            else
            {
                _genreSelected.GenreID(long.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                _genreSelected.GenreName(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                EnableButtons();
            }
        }
    }
}
