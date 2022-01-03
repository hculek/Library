using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain
{
    public interface IBook
    {
        void BookID(long BookID);
        void Title(string Title);
        void TotalPages(int TotalPages);
        //Book GetBook();
    }
}
