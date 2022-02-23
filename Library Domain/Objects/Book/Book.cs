using System.Collections.Generic;
using System.ComponentModel;
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
        public long? BookID { get; set; }

        [Column("book_title"), DisplayName("Book Title")]
        [Required(ErrorMessage = "Book title is required.")]
        public string BookTitle { get; set; }

        [Column("book_total_pages"), DisplayName("Total Pages")]
        [Required(ErrorMessage = "Book total page number is required.")]
        public int BookTotalPages { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}