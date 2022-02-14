using Library_Domain.Objects;
namespace Library_DTO.Builders
{
    public class GenreBuilder : IGenre
    {
        private Genre _genre = new Genre();

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
            this._genre = new Genre();
        }

        public Genre Build() 
        {
            Genre result = this._genre;
            this.Reset();
            return result;
        }
    }
}
