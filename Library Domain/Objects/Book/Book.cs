using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library_Domain.Objects
{
    [Table("books")]
    public class Book
    {
        public Book() 
        { 
            this.Authors = new HashSet<Author>();
            this.Genres = new HashSet<Genre>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("book_id")]
        public long BookID { get; set; }

        [Column("book_title"), Display(Name = "Book Title")]
        public string BookTitle { get; set; }

        [Column("book_total_pages"), Display(Name = "Total Pages")]
        public int BookTotalPages { get; set; }

        [ForeignKey("author_id")]
        public ICollection<Author> Authors { get; set; }

        [ForeignKey("genre_id")]
        public ICollection<Genre> Genres { get; set; }
    }
}