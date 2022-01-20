using System.Collections.Generic;

namespace Library_Domain.Book
{
    public class BookBuilder : IBook
    {
        private Book book = new Book();

        public BookBuilder() 
        {
            this.Reset();
        }

        public void Author(ICollection<Author.Author> Authors)
        {
            this.book.Authors = Authors;
        }

        public void BookID(long BookID)
        {
            this.book.BookID = BookID;
        }

        public void Genre(ICollection<Genre.Genre> Genres)
        {
            this.book.Genres = Genres;
        }

        public void Reset() 
        { 
            this.book = new Book();
        }

        public void Title(string Title)
        {
            this.book.Title = Title;
        }

        public void TotalPages(int TotalPages)
        {
            this.book.TotalPages = TotalPages;
        }
    }
}
