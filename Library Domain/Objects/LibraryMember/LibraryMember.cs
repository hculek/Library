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
        [Column("member_id"), Display(Name = "Member ID")]
        public long LibraryMemberID { get; set; }

        [Column("first_name"), Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName {get; set;}

        [Column("middle_name"), Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Column("last_name"), Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        public string Lastname { get; set; }

        [Column("adress"), Display(Name = "Adress")]
        public string Adress { get; set; }

        [Column("email"), Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column("phone_number"), Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Column("membership_start_date"), Display(Name = "Membership start date")]
        public DateTime MembershipStartDate { get; set; }

        [Column("membership_renewal_date"), Display(Name = "Membership renewal date")]
        public DateTime MembershipRenewalDate { get; set; }

        [Column("membership_expiry_date"), Display(Name = "Membership expiry date")]
        public DateTime MembershipExpiryDate { get; set; }

        [Column("membership_active_status"), Display(Name = "Membership active status")]
        bool MembershipStatus { get; set; }

    }
}
