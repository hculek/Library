using Library_Domain.Genre;

namespace Library_DTO.Genre
{
    public class GenreBuilder : IGenre
    {
        private Library_Domain.Genre.Genre genre = new Library_Domain.Genre.Genre();

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
            this.genre = new Library_Domain.Genre.Genre();
        }
    }
}
