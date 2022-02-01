using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Book
{
    [Table("books")]
    public class Book
    {
        [Key]
        public long bookid { get; set; }
        public string title { get; set; }
        public int totalpages { get; set; }

        //public ICollection<Library_Domain.Author.Author> Authors { get; set; }
        //public ICollection<Library_Domain.Genre.Genre> Genres { get; set; }
    }
}