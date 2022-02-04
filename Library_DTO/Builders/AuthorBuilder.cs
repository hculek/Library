﻿using Library_Domain.Objects.Author;
namespace Library_DTO.Builders
{
    public class AuthorBuilder : IAuthor
    {
        private Library_Domain.Objects.Author.Author _author = new Library_Domain.Objects.Author.Author();

        public AuthorBuilder() 
        {
            this.Reset();
        }

        public void AuthorID(long AuthorID)
        {
            this._author.authorid = AuthorID;
        }

        public void FirstName(string FirstName)
        {
            this._author.firstname = FirstName;
        }

        public void LastName(string LastName)
        {
            this._author.lastname = LastName;
        }

        public void MiddleName(string MiddleName)
        {
            this._author.middlename = MiddleName;
        }

        public void Reset() 
        { 
            this._author = new Library_Domain.Objects.Author.Author();
        }

        public Library_Domain.Objects.Author.Author Build()
        {
            Library_Domain.Objects.Author.Author result = this._author;
            this.Reset();
            return result;
        }
    }
}
