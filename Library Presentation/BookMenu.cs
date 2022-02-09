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
        private List<Book> _listBooks = new List<Book>();

        public BookMenu()
        {
            InitializeComponent();
            DisableButtons();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listBooks = uow.Books.GetAll().OrderBy(a => a.BookTitle).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
                    comboBoxGenresList.Items.Add(genre.GenreName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadAuthors()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listAuthors = uow.Authors.GetAll().OrderBy(a => a.LastName).ToList();
                }
                dataGridViewAuthorsList.DataSource = _listAuthors;
                dataGridViewAuthorsList.Columns["AuthorID"].Visible = false;
                dataGridViewAuthorsList.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewAuthorsList.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridViewAuthorsList.Columns["LastName"].HeaderText = "Last Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadBookAuthors() 
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    var bookauthors = from a in uow.Authors.GetAll()
                                      join b in uow.Books.GetAll() on a.AuthorID equals b.BookID
                                      select a;

                    //var td = from s in cv.Entity_Product_Points
                    //         join r in dt.PlanMasters on s.Product_ID equals r.Product_ID
                    //         where s.Entity_ID = getEntity
                    //         select s;

                }
                dataGridViewAuthorsList.DataSource = _listAuthors;
                dataGridViewAuthorsList.Columns["AuthorID"].Visible = false;
                dataGridViewAuthorsList.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewAuthorsList.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridViewAuthorsList.Columns["LastName"].HeaderText = "Last Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void EnableButtons()
        {
            AddButton.Enabled = true;
            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
            AddAuthorButton.Enabled = true;
            RemoveAuthorButton.Enabled = true;
            AddGenreButton.Enabled = true;
            RemoveGenreButton.Enabled = true;
        }

        private void DisableButtons()
        {
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            UpdateButton.Enabled = false;
            AddAuthorButton.Enabled = false;
            RemoveAuthorButton.Enabled = false;
            AddGenreButton.Enabled = false;
            RemoveGenreButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            LoadGenres();
            LoadAuthors();
            EnableButtons();
        }

        private void ClearEditingElements() 
        {
            dataGridViewAuthorsList.DataSource = null;
            comboBoxGenresList.Items.Clear();
            dataGridViewBookAuthors.DataSource = null;
            dataGridViewBookGenres.DataSource = null;
            textBoxBookTitle.Clear();
            textBoxNumberPages.Clear();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ClearEditingElements();
            LoadBooks();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearEditingElements();
            LoadAuthors();
            LoadGenres();
        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedListGenres = _listGenres.Where(g => g.GenreName.Equals(comboBoxGenresList.SelectedItem)).ToList();
        }
    }
}
