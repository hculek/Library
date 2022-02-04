using Library_Domain.Objects.Book;
using System.Collections.Generic;

namespace Library_DTO.Builders
{
    public class BookBuilder : IBook
    {
        private Library_Domain.Objects.Book.Book _book = new Library_Domain.Objects.Book.Book();

        public BookBuilder() 
        {
            this.Reset();
        }

        public void Author(ICollection<Library_Domain.Objects.Author.Author> Authors)
        {
            //this.book.Authors = Authors;
        }

        public void BookID(long BookID)
        {
            this._book.bookid = BookID;
        }

        public void Genre(ICollection<Library_Domain.Objects.Genre.Genre> Genres)
        {
            //this.book.Genres = Genres;
        }

        public void Reset() 
        { 
            this._book = new Library_Domain.Objects.Book.Book();
        }

        public void Title(string Title)
        {
            this._book.title = Title;
        }

        public void TotalPages(int TotalPages)
        {
            this._book.totalpages = TotalPages;
        }

        public Library_Domain.Objects.Book.Book Build()
        {
            Library_Domain.Objects.Book.Book result = this._book;
            this.Reset();
            return result;
        }
    }
}
