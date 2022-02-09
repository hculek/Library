using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.JunctionObj
{
    [Table("books_authors", Schema = "public")]
    public class BookAuthor
    {
        [Column("book_id")]
        public long BookID { get; set; }
        public Book.Book book { get; set; }

        [Column("author_id")]
        public long AuthorID { get; set; }
        public Author.Author author { get; set; }
    }
}
