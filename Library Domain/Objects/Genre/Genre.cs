using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Genre
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        public long genreid { get; set; }
        public string genrename { get; set; }
    }
}
