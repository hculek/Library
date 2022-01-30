namespace Library_Domain.Objects.LibraryMember
{
    interface ILibraryMember
    {
        void LibraryMemberID(long LibraryMemberID);
        void FirstName(string FirstName);
        void MiddleName(string MiddleName);
        void LastName(string LastName);
        void Adress(string Adress);
        void Email(string email);
        void Telephone(string Telephone);
        //LibraryMember GetLibraryMember();
    }
}
