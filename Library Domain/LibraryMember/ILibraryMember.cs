using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.LibraryMember
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
