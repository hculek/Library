using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Objects.JunctionObj
{
    [Table("books_authors", Schema = "public")]
    public class bookAuthor
    {
        [Column("book_id")]
        public long BookID { get; set; }

        [Column("author_id")]
        public long AuthorID { get; set; }

    }
}
