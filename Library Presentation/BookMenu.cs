using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Domain.Objects;
using Library_Service.Builders;
using Library_Service.dbAccess;

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
            ToggleCreateControls(false);
            ToggleEditControls(false);
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                _listBooks = Books.Load();

                BooksGridFormat();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
        }

        private DataTable formatBookData() 
        {

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] 
            {
                new DataColumn("Book ID"),
                new DataColumn("Book Title"),
                new DataColumn("Total Pages"),
                new DataColumn("Authors"),
                new DataColumn("Genres")  });

            foreach (var book in _listBooks)
            {

                StringBuilder authors = new StringBuilder();

                authors.Clear();
                foreach (var author in book.Authors)
                {
                    //authors += String.Format("{0} {1} {2}, ", author.FirstName, author.MiddleName, author.LastName);

                    if (!String.IsNullOrEmpty(author.FirstName))
                    {
                        authors.Append(author.FirstName + " ");
                    }
                    if (!String.IsNullOrEmpty(author.MiddleName))
                    {
                        authors.Append(author.MiddleName + " ");
                    }
                    if (!String.IsNullOrEmpty(author.LastName))
                    {
                        authors.Append(author.LastName);
                    } 
                    authors.Append(", ");
                }
                authors = authors.Remove(authors.Length - 2 ,2);

                string genres = "";
                foreach (var genre in book.Genres)
                {
                    genres += String.Format("{0}, ", genre.GenreName);
                }
                genres = genres.Remove(genres.Length - 2, 2);

                //dt.Rows.Add(new{book.BookID, book.BookTitle, book.BookTotalPages, authors, genres});
                
                dt.Rows.Add(new Object[]{ book.BookID, book.BookTitle, book.BookTotalPages, authors, genres });
            }
            return dt;
        
        }

        private void BooksGridFormat() 
        {
            //dataGridViewBooks.DataSource = _listBooks;
            dataGridViewBooks.DataSource = formatBookData();
            dataGridViewBooks.AutoGenerateColumns = true;
            dataGridViewBooks.Columns[0].Visible = false;
            dataGridViewBooks.ClearSelection();
        }



        void LoadGenres()
        {
            try
            {

                _listGenres = Genres.Load();

                dataGridViewGenreList.DataSource = null;
                dataGridViewGenreList.DataSource = _listGenres;
                dataGridViewGenreList.Columns["GenreID"].Visible = false;
                dataGridViewGenreList.Columns["Books"].Visible = false;
                dataGridViewGenreList.ClearSelection();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
        }

        private void LoadSelectedGenres()
        {
            dataGridViewBookGenres.DataSource = null;
            dataGridViewBookGenres.DataSource = _selectedListGenres;
            dataGridViewBookGenres.Columns["GenreID"].Visible = false;
            dataGridViewBookGenres.Columns["Books"].Visible = false;
            dataGridViewBookGenres.ClearSelection();
        }

        private void LoadAuthors()
        {
            try
            {
                _listAuthors = Authors.Load();


                dataGridViewAuthorsList.DataSource = null;
                dataGridViewAuthorsList.DataSource = _listAuthors;
                dataGridViewAuthorsList.Columns["AuthorID"].Visible = false;
                dataGridViewAuthorsList.Columns["Books"].Visible = false;

                //dataGridViewAuthorsList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //dataGridViewAuthorsList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

                dataGridViewAuthorsList.ClearSelection();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
        }

        private void LoadSelectedAuthor()
        {
            dataGridViewBookAuthors.DataSource = null;
            dataGridViewBookAuthors.DataSource = _selectedListAuthors;
            dataGridViewBookAuthors.Columns["AuthorID"].Visible = false;
            dataGridViewBookAuthors.Columns["Books"].Visible = false;
            dataGridViewBookAuthors.ClearSelection();
        }

        private void ToggleCreateEditButtons(bool input) 
        {
            buttonCreate.Enabled = input;
            buttonEdit.Enabled = input;
        }

        private void ToggleCreateControls(bool input)
        {
            buttonAdd.Enabled = input;
            buttonCancel.Enabled = input;
            AddAuthorButton.Enabled = input;
            RemoveAuthorButton.Enabled = input;
            AddGenreButton.Enabled = input;
            RemoveGenreButton.Enabled = input;
            //buttonClear.Enabled = input ? false : true;

            ToggleCreateEditButtons(input ? false : true);
            LoadEditingElements(input);
        }

        private void ToggleEditControls(bool input)
        {
            buttonDelete.Enabled = input;
            buttonUpdate.Enabled = input;
            buttonCancel.Enabled = input;
            AddAuthorButton.Enabled = input;
            RemoveAuthorButton.Enabled = input;
            AddGenreButton.Enabled = input;
            RemoveGenreButton.Enabled = input;
            buttonClear.Enabled = input ? false : true;

            ToggleCreateEditButtons(input ? false : true);
            LoadEditingElements(input);
        }

        private void Cleanup() 
        {
            _book.Reset();
            dataGridViewAuthorsList.DataSource = null;
            dataGridViewGenreList.DataSource = null;
            ClearEditingElements();
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

        private void LoadEditingElements(bool input)
        {
            if (input == true)
            {
                LoadAuthors();
                LoadGenres();
            }
            else
            {
                Cleanup();
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _book.Reset();
            ToggleCreateControls(true);
            LoadEditingElements(true);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                _book.Reset();
                PrepareToEditBook(FindBook());
                ToggleEditControls(true);
            }


        }

        private Book CreateBook()
        {
            _book.Title(textBoxBookTitle.Text.ToString());
            _book.TotalPages(int.Parse(textBoxNumberPages.Text.ToString()));
            _book.Author(_selectedListAuthors);
            _book.Genre(_selectedListGenres);
            var book = _book.Build();
            return book;
        }


        private Book FindBook()
        {
            Book book = new Book();
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int a = dataGridViewBooks.SelectedRows[0].Index;
                var bookID = long.Parse(dataGridViewBooks.Rows[a].Cells[0].Value.ToString());
                book = _listBooks.Find(b => b.BookID.Equals(bookID));
            }
            return book;
        }

        private void PrepareToEditBook(Book book)
        {
            if (book.BookID.HasValue)
            {
                _book.BookID((book.BookID.Value));
                textBoxBookTitle.Text = book.BookTitle.ToString();
                textBoxNumberPages.Text = book.BookTotalPages.ToString();
                _selectedListAuthors = book.Authors.ToList();
                dataGridViewBookAuthors.DataSource = _selectedListAuthors;
                _selectedListGenres = book.Genres.ToList();
                dataGridViewBookGenres.DataSource = _selectedListGenres;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBoxBookTitle.Text.ToString()) && !String.IsNullOrEmpty(textBoxNumberPages.Text.ToString()))
                {
                    var book = CreateBook();

                    Books.Add(book);

                    Cleanup();
                }
                else
                {
                    MessageBox.Show("Please add missing book title or total page number.");
                }

            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }
            ToggleCreateControls(false);
            LoadBooks();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var book = CreateBook();

                Books.Update(book);

                Cleanup();
                

            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }

            ToggleEditControls(false);
            LoadBooks();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var book = FindBook();

                Books.Remove(book);

                Cleanup();
                
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex);
            }

            ToggleEditControls(false);
            LoadBooks();



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cleanup();
            ToggleCreateControls(false);
            ToggleEditControls(false);
            LoadBooks();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearEditingElements();
            //LoadEditingElements();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
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

        private void buttonRemoveAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookAuthors.SelectedRows.Count > 0)
            {
                var a = dataGridViewBookAuthors.SelectedRows[0].Index;
                _selectedListAuthors.RemoveAt(a);
                LoadSelectedAuthor();
            }
            dataGridViewAuthorsList.ClearSelection();
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
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

        private void buttonRemoveGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookGenres.SelectedRows.Count > 0)
            {
                var a = dataGridViewBookGenres.SelectedRows[0].Index;
                _selectedListGenres.RemoveAt(a);
                LoadSelectedGenres();
            }
            dataGridViewGenreList.ClearSelection();

        }

        private void textBoxSearchAuthors_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxSearchAuthors.Text.ToString()))
            {
                var searchAuthors =
                    _listAuthors.Where(a => a.FirstName.ToLower().Contains(textBoxSearchAuthors.Text.ToLower())
                || a.MiddleName.ToLower().Contains(textBoxSearchAuthors.Text.ToLower())
                || a.LastName.ToLower().Contains(textBoxSearchAuthors.Text.ToLower()));

                dataGridViewAuthorsList.DataSource = searchAuthors.ToList();

            }
            else
            {
                dataGridViewAuthorsList.DataSource = _listAuthors;
            }

        }

        private void textBoxSearchGenres_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSearchGenres.Text.ToString()))
            {

                var result = from genre in _listGenres
                             where genre.GenreName.ToLower().Contains(textBoxSearchGenres.Text.ToLower())
                             select genre;
                dataGridViewGenreList.DataSource = result.ToList();
            }
            else
            {
                dataGridViewGenreList.DataSource = _listGenres;
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSearch.Text.ToString()))
            {
                var result = from book in _listBooks
                             where book.BookTitle.ToLower().Contains(textBoxSearch.Text.ToLower())
                             select book;
                dataGridViewBooks.DataSource = result.ToList();
            }
            else 
            {
                Cleanup();
                LoadBooks();
            }
        }
    }
}
