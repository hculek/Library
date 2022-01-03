using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain
{
    interface IAuthor
    {
        void AuthorID(long AuthorID);
        void FirstName(string FirstName);
        void MiddleName(string MiddleName);
        void LastName(string LastName);
        //Author GetAuthor();
    }
}
