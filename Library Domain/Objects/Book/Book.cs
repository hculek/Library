using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library_Domain.Objects.Book
{
    [Table("books")]
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("book_id")]
        public long BookID { get; set; }

        [Column("book_title"), Display(Name = "Book Title")]
        public string BookTitle { get; set; }

        [Column("book_total_pages"), Display(Name = "Total Pages")]
        public int BookTotalPages { get; set; }


        public virtual ICollection<Author.Author> Authors { get; set; }

        public virtual ICollection<Genre.Genre> Genres { get; set; }
    }
}