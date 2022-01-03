using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain
{
    interface IGenre
    {
        void GenreID(long GenreID);
        void GenreName(string GenreName);
        //Genre GetGenre();
    }
}
