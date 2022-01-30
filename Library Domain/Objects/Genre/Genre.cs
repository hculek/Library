using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Genre
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        public long GenreID { get; set; }
        public string GenreName { get; set; }
    }
}
