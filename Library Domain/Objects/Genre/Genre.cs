using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Genre
{
    [Table("genres")]
    public class Genre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("genre_id")]
        public long GenreID { get; set; }

        [Column("genre_name"), Display(Name = "Genre Name")]
        public string GenreName { get; set; }


        //https://docs.microsoft.com/en-gb/ef/ef6/querying/related-data?redirectedfrom=MSDN
        //public virtual ICollection<Book.Book> Books { get; set; } baca error
        public ICollection<Book.Book> Books { get; set; }
    }
}
