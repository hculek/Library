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
                    var genres = uow.Genres.GetAll();
                    //if (!(genres == null)) listBox1.DataSource = genres;
                    //listBox1.DataSource = genres;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _genre.GenreName(textBox1.Text.ToString());
                    var genre = _genre.Build();
                    uow.Genres.Add(_genre.Build());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _genreSelected.GenreName(textBox2.Text.ToString());
            _genreSelected.Build();
            DisableButtons();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            textBox1.Clear();
            textBox2.Clear();
            _genre.Reset();
            _genreSelected.Reset();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genreSelected.GenreID(listBox1.SelectedIndex);
            _genreSelected.GenreName(listBox1.SelectedValue.ToString());
            textBox2.Text = listBox1.SelectedValue.ToString();
            EnableButtons();
        }
    }
}
