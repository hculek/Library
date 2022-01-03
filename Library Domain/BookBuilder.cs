using Library_Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain
{
    public class BookBuilder : IBook
    {
        private Book book = new Book();

        public BookBuilder() 
        {
            this.Reset();
        }

        public void BookID(long BookID)
        {
            this.book.BookID = BookID;
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
