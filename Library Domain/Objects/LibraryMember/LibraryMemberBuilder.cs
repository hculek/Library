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
            this.member.Adress = Adress;
        }

        public void Email(string Email)
        {
            this.member.Email = Email;
        }

        public void FirstName(string FirstName)
        {
            this.member.FirstName = FirstName;
        }

        public void LastName(string LastName)
        {
            this.member.LastName = LastName;
        }

        public void LibraryMemberID(long LibraryMemberID)
        {
            this.member.LibraryMemberID = LibraryMemberID;
        }

        public void MiddleName(string MiddleName)
        {
            this.member.MiddleName = MiddleName;
        }

        public void Reset()
        {
            this.member = new LibraryMember();
        }

        public void Telephone(string Telephone)
        {
            this.member.Telephone = Telephone;
        }
    }
}
