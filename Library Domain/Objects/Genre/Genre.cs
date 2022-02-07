using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Genre
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        [Column("genre_id")]
        public long GenreID { get; set; }
        [Column("genre_name")]
        public string GenreName { get; set; }
    }
}
