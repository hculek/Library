using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects
{
    [Table("genres")]
    public class Genre
    {
        //https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-6

        public Genre() 
        {
            this.Books = new HashSet<Book>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("genre_id")]
        public long GenreID { get; set; }

        [Column("genre_name"), DisplayName("Genre Name")]
        [Required(ErrorMessage = "Genre label is required.")]
        public string GenreName { get; set; }


        //https://docs.microsoft.com/en-gb/ef/ef6/querying/related-data?redirectedfrom=MSDN
        //public virtual ICollection<Book> Books { get; set; } baca error

        public virtual ICollection<Book> Books { get; set; }
    }
}
