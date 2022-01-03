using Library_Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain
{
    public class GenreBuilder : IGenre
    {
        private Genre genre = new Genre();

        public GenreBuilder() 
        {
            this.Reset();
        }

        public void GenreID(long GenreID)
        {
            this.genre.GenreID = GenreID;
        }

        public void GenreName(string GenreName)
        {
            this.genre.GenreName = GenreName;
        }

        public void Reset()
        {
            this.genre = new Genre();
        }
    }
}
