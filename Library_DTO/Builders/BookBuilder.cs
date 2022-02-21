using Library_Domain.Objects;
using System.Collections.Generic;


namespace Library_Service.Builders
{
    public class BookBuilder : IBook
    {
        private Book _book = new Book();

        public BookBuilder() 
        {
            this.Reset();
        }

        public void Author(ICollection<Author> Authors)
        {
            this._book.Authors = Authors;
        }

        public void BookID(long BookID)
        {
            this._book.BookID = BookID;
        }

        public void Genre(ICollection<Genre> Genres)
        {
            this._book.Genres = Genres;
        }

        public void Reset() 
        { 
            this._book = new Book();
        }

        public void Title(string Title)
        {
            this._book.BookTitle = Title;
        }

        public void TotalPages(int TotalPages)
        {
            this._book.BookTotalPages = TotalPages;
        }

        public Book Build()
        {
            Book result = this._book;
            this.Reset();
            return result;
        }
    }
}
