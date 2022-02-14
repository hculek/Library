using Library_Domain.Objects;
namespace Library_DTO.Builders
{
    public class AuthorBuilder : IAuthor
    {
        private Author _author = new Author();

        public AuthorBuilder() 
        {
            this.Reset();
        }

        public void AuthorID(long AuthorID)
        {
            this._author.AuthorID = AuthorID;
        }

        public void FirstName(string FirstName)
        {
            this._author.FirstName = FirstName;
        }

        public void LastName(string LastName)
        {
            this._author.LastName = LastName;
        }

        public void MiddleName(string MiddleName)
        {
            this._author.MiddleName = MiddleName;
        }

        public void Reset() 
        { 
            this._author = new Author();
        }

        public Author Build()
        {
            Author result = this._author;
            this.Reset();
            return result;
        }
    }
}
