using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name field is required. Please input Name")]
        [StringLength(255)]
        public string Name { get; set; }


        public bool IsSubscribedToNewsletter { get; set; }


        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}