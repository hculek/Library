namespace Library_Domain.Objects.LibraryMember
{
    class LibraryMemberBuilder : ILibraryMember
    {
        LibraryMember member = new LibraryMember();

        public LibraryMemberBuilder()
        {
            this.Reset();
        }

        public void Adress(string Adress)
        {
            this.member.adress = Adress;
        }

        public void Email(string Email)
        {
            this.member.email = Email;
        }

        public void FirstName(string FirstName)
        {
            this.member.firstname = FirstName;
        }

        public void LastName(string LastName)
        {
            this.member.lastname = LastName;
        }

        public void LibraryMemberID(long LibraryMemberID)
        {
            this.member.librarymemberid = LibraryMemberID;
        }

        public void MiddleName(string MiddleName)
        {
            this.member.middlename = MiddleName;
        }

        public void Reset()
        {
            this.member = new LibraryMember();
        }

        public void Telephone(string Telephone)
        {
            this.member.telephone = Telephone;
        }
    }
}
