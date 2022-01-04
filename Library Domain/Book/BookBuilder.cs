using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Book
{
    public class BookBuilder : IBook
    {
        private Book book = new Book();

        public BookBuilder() 
        {
            this.Reset();
        }

        public void Author(List<Author.Author> Authors)
        {
            this.book.Authors = Authors;
        }

        public void BookID(long BookID)
        {
            this.book.BookID = BookID;
        }

        public void Genre(List<Genre.Genre> Genres)
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
