using Library_Domain.Objects.Genre;
namespace Library_DTO.Objects.Genre
{
    public class GenreBuilder : IGenre
    {
        private Library_Domain.Objects.Genre.Genre _genre = new Library_Domain.Objects.Genre.Genre();

        public GenreBuilder() 
        {
            this.Reset();
        }

        public void GenreID(long GenreID)
        {
            this._genre.GenreID = GenreID;
        }

        public void GenreName(string GenreName)
        {
            this._genre.GenreName = GenreName;
        }

        public void Reset()
        {
            this._genre = new Library_Domain.Objects.Genre.Genre();
        }

        public Library_Domain.Objects.Genre.Genre Build() 
        {
            Library_Domain.Objects.Genre.Genre result = this._genre;
            this.Reset();
            return result;
        }
    }
}
