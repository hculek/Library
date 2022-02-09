using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.JunctionObj
{
    [Table("books_genres", Schema = "public")]
    public class bookGenre
    {
        [Column("book_id")]
        public long BookID { get; set; }

        [Column("genre_id")]
        public long GenreID { get; set; }
    }
}
