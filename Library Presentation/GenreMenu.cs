using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Domain.Objects.Genre;
using Library_DTO;
using Library_DTO.Objects.Genre;
using Library_Persistence.UnitOfWork;

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
                    listBox1.DataSource = _listGenres;
                    //if (!(genres == null)) listBox1.DataSource = genres;
                    //listBox1.DataSource = uow.Genres.GetAll();
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
            listBox1.ClearSelected();
            textBox1.Clear();
            textBox2.Clear();
            _genre.Reset();
            _genreSelected.Reset();
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
                    //var genre = new Genre
                    //{
                    //    GenreName = textBox2.Text.ToString()
                    //};
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
                    _genre.GenreName(textBox2.Text.ToString());
                    var genre = _genre.Build();
                    //var genre = new Genre
                    //{
                    //    GenreName = textBox2.Text.ToString()
                    //};
                    uow.Genres.Update(genre);
                    uow.Save();
                    LoadGenres();
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
                    _genre.GenreName(textBox2.Text.ToString());
                    var genre = _genre.Build();
                    //var genre = new Genre
                    //{
                    //    GenreName = textBox2.Text.ToString()
                    //};
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genreSelected.GenreID(listBox1.SelectedIndex);
            _genreSelected.GenreName(listBox1.SelectedValue.ToString());
            textBox2.Text = listBox1.SelectedValue.ToString();
            EnableButtons();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var current = textBox1.Text;
            //foreach (ListItem item in listBox1.Items)
            //{
            //    //if (item.text.ToLower().Contains(current.ToLower()))
            //    //    item.Selected = true;
            //    //if (item.ToString().ToLower().Contains(current.ToLower()))
            //    //    item.Selected = true;

            //}

            //int index = listBox1.FindString(textBox1.Text, -1);
            //if (index != -1)
            //{
            //    listBox1.SetSelected(index, true);
            //}

            if (!(_listGenres.Count == 0))
            if (!String.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                var current = textBox1.Text;
                foreach (var item in _listGenres)
                {
                    if (item.GenreName.ToLower().Contains(current.ToLower()))
                    {
                        listBox1.Items.Add(item);
                    };
                }
            }
            else
            {
                Clear();
            }
        }
    }
}
