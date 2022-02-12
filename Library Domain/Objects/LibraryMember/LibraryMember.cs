using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects.LibraryMember
{
    [Table("librarymembers")]
    public class LibraryMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long librarymemberid { get; set; }
        public string firstname {get; set;}
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string adress { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }

        public DateTime membershipstartdate { get; set; }

    }
}
