using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Genre
{
    //[Table("genre")]
    public class Genre
    {
        public long GenreID { get; set; }
        public string GenreName { get; set; }
    }
}
