using System.Collections.Generic;

namespace Library_Domain.Book
{
    public class Book
    {
        public long BookID { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }

        public ICollection<Library_Domain.Author.Author> Authors { get; set; }
        public ICollection<Library_Domain.Genre.Genre> Genres { get; set; }
    }
}