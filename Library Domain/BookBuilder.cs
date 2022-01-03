using Library_Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain
{
    public class BookBuilder : IAuthor, IBook, IGenre
    {
        private Author author = new Author();
        private Book book = new Book();
        private Genre genre = new Genre();

        public void AuthorID()
        {
            throw new NotImplementedException();
        }

        public void BookID()
        {
            throw new NotImplementedException();
        }

        public void FirstName()
        {
            throw new NotImplementedException();
        }

        public void GenreID()
        {
            throw new NotImplementedException();
        }

        public void GenreName()
        {
            throw new NotImplementedException();
        }

        public void LastName()
        {
            throw new NotImplementedException();
        }

        public void MiddleName()
        {
            throw new NotImplementedException();
        }

        public void Title()
        {
            throw new NotImplementedException();
        }

        public void TotalPages()
        {
            throw new NotImplementedException();
        }
    }
}
