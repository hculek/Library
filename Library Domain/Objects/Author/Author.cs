using Library_Domain.Objects.JunctionObj;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.Author
{
    [Table("authors")]
    public class Author
    {
        [Key]
        [Column("author_id")]
        public long AuthorID { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("middle_name")]
        public string MiddleName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }

        [ForeignKey("AuthorID")]
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
