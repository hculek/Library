using System;

namespace Library_Domain.Objects.LibraryMember
{
    public class LibraryMember
    {
        public long LibraryMemberID { get; set; }
        public string FirstName {get; set;}
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public DateTime MembershipStartDate { get; set; }

    }
}
