using Library_Domain.Objects.JunctionObj;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library_Domain.Objects.Book
{
    [Table("books", Schema = "public")]
    public class Book
    {
        [Key]
        [Column("book_id")]
        public long BookID { get; set; }
        [Column("book_title")]
        public string BookTitle { get; set; }
        [Column("book_total_pages")]
        public int BookTotalPages { get; set; }

        [ForeignKey("AuthorID")]
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        [ForeignKey("GenreID")]
        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}