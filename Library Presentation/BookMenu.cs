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
using Library_DTO.Builders;

namespace Library_Presentation
{
    public partial class BookMenu : UserControl
    {
        private BookBuilder _book = new BookBuilder();
        private AuthorBuilder _author = new AuthorBuilder();
        private GenreBuilder _genre = new GenreBuilder();
        private List<Book> _listBooks = new List<Book>();
        private List<Genre> _listGenres = new List<Genre>();
        private List<Genre> _selectedListGenres = new List<Genre>();
        private List<Author> _listAuthors = new List<Author>();
        private List<Author> _selectedListAuthors = new List<Author>();

        public BookMenu()
        {
            InitializeComponent();
            ToggleButtons(false);
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
                dataGridViewBooks.DataSource = _listBooks;
                dataGridViewBooks.Columns["BookID"].Visible = false;
                dataGridViewBooks.Columns["BookTitle"].HeaderText = "Book Title";
                dataGridViewBooks.Columns["BookTotalPages"].HeaderText = "Total Pages";
                dataGridViewBooks.ClearSelection();
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
                dataGridViewGenreList.DataSource = null;
                dataGridViewGenreList.DataSource = _listGenres;
                dataGridViewGenreList.Columns["GenreID"].Visible = false;
                dataGridViewGenreList.Columns["GenreName"].HeaderText = "Genre";
                dataGridViewGenreList.ClearSelection();
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
                dataGridViewAuthorsList.DataSource = null;
                dataGridViewAuthorsList.DataSource = _listAuthors;
                dataGridViewAuthorsList.Columns["AuthorID"].Visible = false;
                dataGridViewAuthorsList.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewAuthorsList.Columns["MiddleName"].HeaderText = "Middle Name";
                dataGridViewAuthorsList.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewAuthorsList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadSelectedAuthor()
        {
            dataGridViewBookAuthors.DataSource = null;
            dataGridViewBookAuthors.DataSource = _selectedListAuthors;
        }

        private void LoadSelectedGenres()
        {
            dataGridViewBookGenres.DataSource = null;
            dataGridViewBookGenres.DataSource = _selectedListGenres;
        }

        private void ToggleButtons(bool input)
        {
            AddButton.Enabled = input;
            AddButton.Enabled = input;
            DeleteButton.Enabled = input;
            UpdateButton.Enabled = input;
            CancelButton.Enabled = input;
            AddAuthorButton.Enabled = input;
            RemoveAuthorButton.Enabled = input;
            AddGenreButton.Enabled = input;
            RemoveGenreButton.Enabled = input;
            ClearButton.Enabled = input;
        }

        private void ClearEditingElements()
        {
            //dataGridViewAuthorsList.DataSource = null;
            //dataGridViewGenreList.DataSource = null;
            //dataGridViewBookAuthors.DataSource = null;
            //dataGridViewBookGenres.DataSource = null;
            textBoxBookTitle.Clear();
            textBoxNumberPages.Clear();
        }

        private void LoadEditingElements()
        {
            LoadAuthors();
            LoadGenres();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            LoadEditingElements();
            ToggleButtons(true);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _book.Title(textBoxBookTitle.Text.ToString());
                _book.TotalPages(int.Parse(textBoxNumberPages.Text.ToString()));
                _book.Author(_selectedListAuthors);
                _book.Genre(_selectedListGenres);
                var book = _book.Build();

                using (var uow = UnitOfWorkFactory.Create())
                {
                    uow.Books.Add(book);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            LoadBooks();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ToggleButtons(false);
            ClearEditingElements();
            LoadBooks();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearEditingElements();
            LoadEditingElements();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthorsList.SelectedRows.Count>0)
            {
                var a = dataGridViewAuthorsList.SelectedRows[0].Index;
                _author.AuthorID(long.Parse(dataGridViewAuthorsList.Rows[a].Cells["AuthorID"].Value.ToString()));
                _author.FirstName(dataGridViewAuthorsList.Rows[a].Cells["FirstName"].Value.ToString());
                _author.MiddleName(dataGridViewAuthorsList.Rows[a].Cells["MiddleName"].Value.ToString());
                _author.LastName(dataGridViewAuthorsList.Rows[a].Cells["LastName"].Value.ToString());

                var selectedAuthor = _author.Build();
                if (!(_selectedListAuthors.Contains(selectedAuthor)))
                {
                    _selectedListAuthors.Add(selectedAuthor);
                }
                LoadSelectedAuthor();
            }
            dataGridViewAuthorsList.ClearSelection();
        }

        private void RemoveAuthorButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookAuthors.SelectedRows.Count > 0)
            {
                var a = dataGridViewBookAuthors.SelectedRows[0].Index;
                _selectedListAuthors.RemoveAt(a);
                LoadSelectedAuthor();
            }
            dataGridViewAuthorsList.ClearSelection();

        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenreList.SelectedRows.Count > 0)
            {
                int a = dataGridViewGenreList.SelectedRows[0].Index;
                _genre.GenreID(long.Parse(dataGridViewGenreList.Rows[a].Cells["GenreID"].Value.ToString()));
                _genre.GenreName(dataGridViewGenreList.Rows[a].Cells["GenreName"].Value.ToString());
                var selectedGenre = _genre.Build();

                if (!_selectedListGenres.Contains(selectedGenre))
                {
                    _selectedListGenres.Add(selectedGenre);
                }
                LoadSelectedGenres();
            }
        }

        private void RemoveGenreButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookGenres.SelectedRows.Count > 0)
            {
                var a = dataGridViewBookGenres.SelectedRows[0].Index;
                _selectedListGenres.RemoveAt(a);
                LoadSelectedGenres();
            }
            dataGridViewGenreList.ClearSelection();

        }


    }
}
