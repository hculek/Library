using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.JunctionObj
{
    [Table("books_genres", Schema = "public")]
    public class BookGenre
    {

        [ForeignKey("Book")]
        [Column("book_id")]
        public long BookID { get; set; }
        
        [ForeignKey("BookID")]
        public Book.Book book { get; set; }


        [ForeignKey("Genre")]
        [Column("genre_id")]
        public long GenreID { get; set; }

        [ForeignKey("GenreID")]
        public Genre.Genre genre { get; set; }
    }
}
