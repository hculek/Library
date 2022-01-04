using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Author
{
    public class AuthorBuilder : IAuthor
    {
        private Author author = new Author();

        public AuthorBuilder() 
        {
            this.Reset();
        }

        public void AuthorID(long AuthorID)
        {
            this.author.AuthorID = AuthorID;
        }

        public void FirstName(string FirstName)
        {
            this.author.FirstName = FirstName;
        }

        public void LastName(string LastName)
        {
            this.author.LastName = LastName;
        }

        public void MiddleName(string MiddleName)
        {
            this.author.MiddleName = MiddleName;
        }

        public void Reset() 
        { 
            this.author = new Author();
        }
    }
}
