using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Author
{
    [Table("authors")]
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("author_id")]
        public long AuthorID { get; set; }

        [Column("first_name"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Column("middle_name"), Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Column("last_name"), Display(Name = "Last Name")]
        public string LastName { get; set; }

        //https://docs.microsoft.com/en-gb/ef/ef6/querying/related-data?redirectedfrom=MSDN
        // public virtual... baca error
        public ICollection<Book.Book> Books{ get; set; }
    }
}
