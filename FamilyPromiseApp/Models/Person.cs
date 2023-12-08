using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyPromiseApp.Models
{

    public enum AnyHouseHold
    {
        Yes, No
    }

    public enum AnyChildren
    {
        Yes, No
    }

    public enum WorkStudy
    {
        Yes, No
    }

     public enum HouseType
    {
        Apartment, House, MobileHome
    }

    public enum RecentHousing
    {
        Renting, Purchased, Outside, Shelter, Car, Hotel
    }

    public class Person
    {
        [Display(Name = "Client ID")]
        public int ID { get; set; }
        // [Key]
        // public int CaseID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


[       Display(Name = "Highest Form of Education: High School Dropout, High School, GED, Started College, Completed Degree, Post High School Vocational Completion, etc.")]
        public string Education { get; set; }


        [Display(Name = "Relationship")]
        public string Relationship { get; set; }

        [Display(Name = "Were you or are you a part of the Work Study Program?")]
        public string WorkStudy { get; set; }

        
        [Display(Name = "SSN")]
        public int SSN { get; set; }



        [Display(Name = "What is your reason for being homeless? Eviction, Kicked Out, Diasaster, Moved, Other, etc.")]
        public int Reason { get; set; }


        [Display(Name = "ID Number")]
        public int IDNum { get; set; }

        
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Display(Name = "Marital Status- if so, where are they located?")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Does he/she attend school? If so, where and what grade?")]
        public string ChildSchool { get; set; }



        
        [Display(Name = "Age")]
        public int Age { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        
        [Display(Name = "Date Admitted")]
        public int DateAdmitted { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        
        [Display(Name = "Completion Date")]
        public int CompletionDate { get; set; }
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

        [Display(Name = "Address")]
        public string Address { get; set;}
        
        [Display(Name = "Are there any additional adults in the household?")]
        public AnyHouseHold? HouseHoldMemberExist { get; set; }

        [Display(Name = "Number of additional adults in household")]
        public int HouseHoldNum { get; set; }

        [Display(Name = "Name")]
        public string AdultName { get; set; }

        [Display(Name = "Age")]
        public int AdultAge { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime AdultDateOfBirth { get; set; }

        [Display(Name = "Cell Phone")]
        public string AdultCellPhone { get; set; }

        [Display(Name = "Work Phone")]
        public string AdultWorkPhone { get; set; }
        [Display(Name = "Email")]
        public string AdultEmail { get; set; }
        
        [Display(Name = "Are there any additional children in the household?")]
        public AnyChildren? HouseHoldChildrenExist { get; set; }



        [Display(Name = "Most Recent Housing")]
        public RecentHousing? RecentHousing { get; set; }

        [Display(Name = "What type of housing were you living in?")]
        public HouseType? HouseType { get; set; }

        [Display(Name = "Number of children in household")]
        public int ChildNum { get; set; }

        [Display(Name = "Name")]
        public string ChildName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime ChildDateOfBirth { get; set; }
        [Display(Name = "Age")]
        public int ChildAge { get; set; }



        // public Case Case { get; set; }

    }
}