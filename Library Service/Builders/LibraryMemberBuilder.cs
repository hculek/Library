using Library_Domain.Objects;
using System;

namespace Library_Service.Builders
{
    class LibraryMemberBuilder : ILibraryMember
    {
        private LibraryMember _libraryMember = new LibraryMember();


        public LibraryMemberBuilder() 
        {
            this.Reset();
        }

        public void Reset()
        {
            this._libraryMember = new LibraryMember();
        }

        public LibraryMember Build()
        {
            LibraryMember result = this._libraryMember;
            this.Reset();
            return result;
        }

        public void Adress(string Adress)
        {
            this._libraryMember.Adress = Adress;
        }

        public void Email(string Email)
        {
            this._libraryMember.Email = Email;
        }

        public void FirstName(string FirstName)
        {
            this._libraryMember.FirstName = FirstName;
        }

        public void LastName(string LastName)
        {
            this._libraryMember.Lastname = LastName;
        }

        public void LibraryMemberID(long LibraryMemberID)
        {
            this._libraryMember.LibraryMemberID = LibraryMemberID;
        }

        public void MembershipExpiryDate(DateTime MembershipExpiryDate)
        {
            this._libraryMember.MembershipExpiryDate = MembershipExpiryDate;
        }

        public void MembershipRenewalDate(DateTime MembershipRenewalDate)
        {
            this._libraryMember.MembershipRenewalDate = MembershipRenewalDate;
        }

        public void MemberShipStartDate(DateTime MemberShipStartDate)
        {
            this._libraryMember.MembershipStartDate = MemberShipStartDate;
        }

        public void MiddleName(string MiddleName)
        {
            this._libraryMember.MiddleName = MiddleName;
        }

        public void PhoneNumber(string PhoneNumber)
        {
            this._libraryMember.PhoneNumber = PhoneNumber;
        }
    }

}
