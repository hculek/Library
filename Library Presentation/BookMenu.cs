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
using Library_Domain.Objects.Author;
using Library_Domain.Objects.Book;
using Library_DTO.UOW;

namespace Library_Presentation
{
    public partial class BookMenu : UserControl
    {
        private List<Genre> _listGenres = new List<Genre>();
        private List<Genre> _selectedListGenres = new List<Genre>();
        private List<Author> _listAuthors = new List<Author>();
        private List<Author> _selectedListAuthors = new List<Author>();

        public BookMenu()
        {
            InitializeComponent();
            DisableButtons();
            LoadGenres();
            LoadAuthors();
        }

        void LoadGenres() 
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listGenres = uow.Genres.GetAll().OrderBy(g => g.GenreName).ToList();
                }
                foreach (var genre in _listGenres)
                {
                    comboBoxGenres.Items.Add(genre.GenreName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void LoadAuthors()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listAuthors = uow.Authors.GetAll().OrderBy(a => a.LastName).ToList();
                }
                foreach (var author in _listAuthors)
                {
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

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedListGenres = _listGenres.Where(g => g.GenreName.Equals(comboBoxGenres.SelectedItem)).ToList();
        }


    }
}
