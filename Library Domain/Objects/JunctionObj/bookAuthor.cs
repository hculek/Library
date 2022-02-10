using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.JunctionObj
{
    [Table("books_authors", Schema = "public")]
    public class BookAuthor
    {
        [ForeignKey("Book")]
        [Column("book_id")]
        public long BookID { get; set; }

        //[ForeignKey("BookID")]
        public virtual Book.Book book { get; set; }


        [ForeignKey("Author")]
        [Column("author_id")]
        public long AuthorID { get; set; }

        //[ForeignKey("AuthorID")]
        public virtual Author.Author author { get; set; }
    }
}
