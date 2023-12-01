using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyPromiseApp.Models
{
    public class NewCase
    {
        [Display(Name = "Case ID")]
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Cell Number")]
        public string CellPhone { get; set; }
        [Display(Name = "Work Number")]
        public string WorkPhone { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set;}

    }
}