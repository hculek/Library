namespace Library_Domain.Objects
{
    public interface IAuthor
    {
        void AuthorID(long AuthorID);
        void FirstName(string FirstName);
        void MiddleName(string MiddleName);
        void LastName(string LastName);
        //Author GetAuthor();
    }
}
