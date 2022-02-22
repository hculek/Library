using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Domain.Objects;
using Library_Service.UOW;

namespace Library_Service.dbAccess
{
    public class Books
    {
        public static List<Book> Load()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    var list = uow.Books.GetAll(b => b.Authors, b => b.Genres).OrderBy(b => b.BookTitle).ToList();
                    return list;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(Book book)
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    List<Author> authors = new List<Author>();
                    foreach (var bookAuthor in book.Authors)
                    {
                        var author = uow.Authors.GetById((int)bookAuthor.AuthorID);
                        authors.Add(author);
                    }

                    List<Genre> genres = new List<Genre>();
                    foreach (var bookGenre in book.Genres)
                    {
                        var genre = uow.Genres.GetById((int)bookGenre.GenreID);
                        genres.Add(genre);
                    }

                    book.Authors = authors;
                    book.Genres = genres;

                    uow.Books.Add(book);
                    uow.Save();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Book book)
        {
            try
            {
                if (book.BookID.HasValue)
                {

                    //load book from context using edited book ID
                    //insert book details from edited book
                    //save with same context
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        var updatedBook = uow.Books.GetById((int)book.BookID);
                        updatedBook.BookTitle = book.BookTitle;
                        updatedBook.BookTotalPages = book.BookTotalPages;

                        List<Author> authors = new List<Author>();
                        foreach (var bookAuthor in book.Authors)
                        {
                            var author = uow.Authors.GetById((int)bookAuthor.AuthorID);

                            updatedBook.Authors.Add(author);
                        }

                        List<Genre> genres = new List<Genre>();
                        foreach (var bookGenre in book.Genres)
                        {
                            var genre = uow.Genres.GetById((int)bookGenre.GenreID);

                            updatedBook.Genres.Add(genre);
                        }

                        uow.Books.Update(updatedBook);
                        uow.Save();
                    }
                }
                else
                {
                    throw new Exception("Error. Record does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Remove(Book book)
        {
            try
            {
                if (book.BookID.HasValue)
                {

                    //load book from context using edited book ID
                    //insert book details from edited book
                    //save with same context
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        var removeBook = uow.Books.GetById((int)book.BookID);

                        List<Author> authors = new List<Author>();
                        foreach (var bookAuthor in book.Authors)
                        {
                            var author = uow.Authors.GetById((int)bookAuthor.AuthorID);

                            removeBook.Authors.Add(author);
                        }

                        List<Genre> genres = new List<Genre>();
                        foreach (var bookGenre in book.Genres)
                        {
                            var genre = uow.Genres.GetById((int)bookGenre.GenreID);

                            removeBook.Genres.Add(genre);
                        }

                        uow.Books.Remove(removeBook);
                        uow.Save();
                    }



                }
                else
                {
                    throw new Exception("Error. Record does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool CheckExistingBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
