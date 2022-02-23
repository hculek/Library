using System;

namespace Library_Domain.Objects
{
    public interface ILibraryMember
    {
        void LibraryMemberID(long LibraryMemberID);
        void FirstName(string FirstName);
        void MiddleName(string MiddleName);
        void LastName(string LastName);
        void Adress(string Adress);
        void Email(string Email);
        void PhoneNumber(string PhoneNumber);

        void MemberShipStartDate(DateTime MemberShipStartDate);

        void MembershipRenewalDate(DateTime MembershipRenewalDate);

        void MembershipExpiryDate(DateTime MembershipExpiryDate);

        //LibraryMember GetLibraryMember();
    }
}
