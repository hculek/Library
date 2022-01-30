namespace Library_Domain.Objects.Genre
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
