using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Library_Domain.Objects;
using Library_DTO.Builders;
using Library_DTO.UOW;

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


                    //_listBooks = uow.Books.Get().OrderBy(a => a.BookTitle).ToList();
                    //_listBooks = uow.Books.GetAll(b => b.Authors.ToList(), b => b.Genres.ToList()).OrderBy(b => b.BookTitle).ToList();
                    _listBooks = uow.Books.GetAll(b => b.Authors, b => b.Genres).OrderBy(b => b.BookTitle).ToList();
                }

                dataGridViewBooks.DataSource = _listBooks;
                dataGridViewBooks.Columns["BookID"].Visible = false;
                dataGridViewBooks.Columns["BookTitle"].HeaderText = "Book Title";
                dataGridViewBooks.Columns["BookTotalPages"].HeaderText = "Total Pages";
                dataGridViewBooks.ClearSelection();

                //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-bind-objects-to-windows-forms-datagridview-controls?view=netframeworkdesktop-4.8
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
                    _listGenres = uow.Genres.Get().OrderBy(g => g.GenreName).ToList();
                }

                dataGridViewGenreList.DataSource = null;
                dataGridViewGenreList.DataSource = _listGenres;
                dataGridViewGenreList.Columns["GenreID"].Visible = false;
                dataGridViewGenreList.Columns["Books"].Visible = false;
                dataGridViewGenreList.Columns["GenreName"].HeaderText = "Genre";
                dataGridViewGenreList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadSelectedGenres()
        {
            dataGridViewBookGenres.DataSource = null;
            dataGridViewBookGenres.DataSource = _selectedListGenres;
            dataGridViewBookGenres.Columns["GenreID"].Visible = false;
            dataGridViewBookGenres.Columns["Books"].Visible = false;
            dataGridViewBookGenres.Columns["GenreName"].HeaderText = "Genre";
            dataGridViewBookGenres.ClearSelection();
        }

        private void LoadAuthors()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    _listAuthors = uow.Authors.Get().OrderBy(a => a.LastName).ToList();
                }
                dataGridViewAuthorsList.DataSource = null;
                dataGridViewAuthorsList.DataSource = _listAuthors;
                dataGridViewAuthorsList.Columns["AuthorID"].Visible = false;
                dataGridViewAuthorsList.Columns["Books"].Visible = false;
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
            dataGridViewBookAuthors.Columns["AuthorID"].Visible = false;
            dataGridViewBookAuthors.Columns["Books"].Visible = false;
            dataGridViewBookAuthors.Columns["FirstName"].HeaderText = "First Name";
            dataGridViewBookAuthors.Columns["MiddleName"].HeaderText = "Middle Name";
            dataGridViewBookAuthors.Columns["LastName"].HeaderText = "Last Name";
            dataGridViewBookAuthors.ClearSelection();
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
            ClearButton.Enabled = input ? false : true;
        }

        private void ClearEditingElements()
        {
            dataGridViewBooks.ClearSelection();
            textBoxBookTitle.Clear();
            textBoxNumberPages.Clear();
            dataGridViewBookAuthors.DataSource = null;
            _selectedListAuthors.Clear();
            dataGridViewBookGenres.DataSource = null;
            _selectedListGenres.Clear();
        }

        private void LoadEditingElements()
        {
            LoadAuthors();
            LoadGenres();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PrepareToEditBook(FindBook());
            ToggleButtons(true);
            LoadEditingElements();
        }


        private Book FindBook()
        {
            Book book = new Book();
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int a = dataGridViewBooks.SelectedRows[0].Index;
                var bookID = long.Parse(dataGridViewBooks.Rows[a].Cells["BookID"].Value.ToString());
                book = _listBooks.Find(b => b.BookID.Equals(bookID));
            }
            return book;
        }

        private void PrepareToEditBook(Book book)
        {
            if (!(book.BookTitle == null))
            {
                textBoxBookTitle.Text = book.BookTitle.ToString();
                textBoxNumberPages.Text = book.BookTotalPages.ToString();
                _selectedListAuthors = book.Authors.ToList();
                dataGridViewBookAuthors.DataSource = _selectedListAuthors;
                _selectedListGenres = book.Genres.ToList();
                dataGridViewBookGenres.DataSource = _selectedListGenres;
            }
        }

        private Book CreateNewBook() 
        {
            _book.Title(textBoxBookTitle.Text.ToString());
            _book.TotalPages(int.Parse(textBoxNumberPages.Text.ToString()));
            _book.Author(_selectedListAuthors);
            _book.Genre(_selectedListGenres);
            var book = _book.Build();
            return book;
        }

        private Book EditExistingBook(long bookID)
        {
            _book.BookID(bookID);
            _book.Title(textBoxBookTitle.Text.ToString());
            _book.TotalPages(int.Parse(textBoxNumberPages.Text.ToString()));
            _book.Author(_selectedListAuthors);
            _book.Genre(_selectedListGenres);
            var book = _book.Build();
            return book;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBoxBookTitle.Text.ToString()) && !String.IsNullOrEmpty(textBoxNumberPages.Text.ToString()))
                {
                    var book = CreateNewBook();
                    
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        List<Author> authors = new List<Author>();
                        foreach (var bookAuthor in book.Authors)
                        {
                            var author = uow.Authors.GetById(int.Parse(bookAuthor.AuthorID.ToString()));
                            authors.Add(author);
                        }

                        List<Genre> genres = new List<Genre>();
                        foreach (var bookGenre in book.Genres)
                        {
                            var genre = uow.Genres.GetById(int.Parse(bookGenre.GenreID.ToString()));
                            genres.Add(genre);
                        }

                        book.Authors = authors;
                        book.Genres = genres;

                        uow.Books.Add(book);
                        uow.Save();
                    }
                }
                else
                {
                    MessageBox.Show("Please add missing book title or total page number.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            ToggleButtons(false);
            LoadBooks();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var findBook= FindBook();
                var editedBook = EditExistingBook(findBook.BookID);

                if (!String.IsNullOrEmpty(findBook.BookID.ToString()))
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        var book = uow.Books.GetById(int.Parse(editedBook.BookID.ToString()));
                        book.Authors.Clear();
                        book.Genres.Clear();

                        List<Author> authors = new List<Author>();
                        foreach (var bookAuthor in editedBook.Authors)
                        {
                            var author = uow.Authors.GetById(int.Parse(bookAuthor.AuthorID.ToString()));

                            book.Authors.Add(author);
                        }

                        List<Genre> genres = new List<Genre>();
                        foreach (var bookGenre in editedBook.Genres)
                        {
                            var genre = uow.Genres.GetById(int.Parse(bookGenre.GenreID.ToString()));
                            
                            book.Genres.Add(genre);
                        }

                        uow.Books.Update(book);
                        uow.Save();
                    }
                }
                else
                {
                    MessageBox.Show("Please add missing book title or total page number.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            LoadBooks();


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fb = FindBook();

                if (!String.IsNullOrEmpty(fb.BookID.ToString()))
                {

                    using (var uow = UnitOfWorkFactory.Create())
                    {

                        var book = uow.Books.GetById(int.Parse(fb.BookID.ToString()));

                        List<Author> authors = new List<Author>();
                        foreach (var bookAuthor in fb.Authors)
                        {
                            var author = uow.Authors.GetById(int.Parse(bookAuthor.AuthorID.ToString()));

                            book.Authors.Add(author);
                        }

                        List<Genre> genres = new List<Genre>();
                        foreach (var bookGenre in fb.Genres)
                        {
                            var genre = uow.Genres.GetById(int.Parse(bookGenre.GenreID.ToString()));

                            book.Genres.Add(genre);
                        }

                        uow.Books.Remove(book);
                        uow.Save();
                    }
                }
                else
                {
                    MessageBox.Show("Please add missing book title or total page number.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ToggleButtons(false);
            LoadBooks();



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
            //LoadEditingElements();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthorsList.SelectedRows.Count>0)
            {
                var i = dataGridViewAuthorsList.SelectedRows[0].Index;
                _author.AuthorID(long.Parse(dataGridViewAuthorsList.Rows[i].Cells["AuthorID"].Value.ToString()));
                _author.FirstName(dataGridViewAuthorsList.Rows[i].Cells["FirstName"].Value.ToString());
                _author.MiddleName(dataGridViewAuthorsList.Rows[i].Cells["MiddleName"].Value.ToString());
                _author.LastName(dataGridViewAuthorsList.Rows[i].Cells["LastName"].Value.ToString());

                var selectedAuthor = _author.Build();

                if (!_selectedListAuthors.Exists(a => a.AuthorID.Equals(selectedAuthor.AuthorID)))
                {
                    _selectedListAuthors.Add(selectedAuthor);
                }
                else
                {
                    MessageBox.Show("Error!" +
                        "\nAuthor is already added.");
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
                int i = dataGridViewGenreList.SelectedRows[0].Index;
                _genre.GenreID(long.Parse(dataGridViewGenreList.Rows[i].Cells["GenreID"].Value.ToString()));
                _genre.GenreName(dataGridViewGenreList.Rows[i].Cells["GenreName"].Value.ToString());
                var selectedGenre = _genre.Build();

                if (!_selectedListGenres.Exists(g => g.GenreID.Equals(selectedGenre.GenreID)))
                {
                    _selectedListGenres.Add(selectedGenre);
                }
                else
                {
                    MessageBox.Show("Error!" +
                        "\nGenre is already added.");
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
