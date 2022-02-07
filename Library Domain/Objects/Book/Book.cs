using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library_Domain.Objects.Book
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("book_id")]
        public long BookID { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("total_pages")]
        public int TotalPages { get; set; }

        public ICollection<Author.Author> Authors { get; set; }
        public ICollection<Genre.Genre> Genres { get; set; }
    }
}