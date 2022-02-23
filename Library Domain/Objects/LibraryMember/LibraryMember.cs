using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Domain.Objects
{
    [Table("libmembers")]
    public class LibraryMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("member_id"), DisplayName("Member ID")]
        public long LibraryMemberID { get; set; }

        [Column("first_name"), DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName {get; set;}

        [Column("middle_name"), DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Column("last_name"), DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        public string Lastname { get; set; }

        [Column("adress"), DisplayName("Adress")]
        public string Adress { get; set; }

        [Column("email"), DisplayName("E-mail")]
        public string Email { get; set; }

        [Column("phone_number"), DisplayName("Phone number")]
        public string PhoneNumber { get; set; }

        [Column("membership_start_date"), DisplayName("Membership start date")]
        public DateTime MembershipStartDate { get; set; }

        [Column("membership_renewal_date"), DisplayName("Membership renewal date")]
        public DateTime MembershipRenewalDate { get; set; }

        [Column("membership_expiry_date"), DisplayName("Membership expiry date")]
        public DateTime MembershipExpiryDate { get; set; }

        [Column("membership_active_status"), DisplayName("Membership active status")]
        bool MembershipStatus { get; set; }

    }
}
