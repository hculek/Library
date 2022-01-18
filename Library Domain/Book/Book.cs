using System.Collections.Generic;

namespace Library_Domain.Book
{
    public class Book
    {
        public long BookID { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }

        public List<Library_Domain.Author.Author> Authors = new List<Library_Domain.Author.Author>();
        public List<Library_Domain.Genre.Genre> Genres = new List<Library_Domain.Genre.Genre>();
    }
}
