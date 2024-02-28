using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;


namespace FamilyPromiseApp.Models
{
    
    public enum YorN
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
    public enum Reason1
    {
        Eviction, KickedOut, Diasaster, Moved, Other
    }
    public enum Reason2
    {
        LostJob, FamilyDissolution, BenefitsStopped, MedicalProblems, Other
    }

    public enum MaritalStatus
    {
        Married, Single
    }

    public class IntakeModel
    {
        [Display(Name = "Client ID")]
        public int ID { get; set; }
        // [Key]
        // public int CaseID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Substance Issues")]
        public string SubstanceIss { get; set; }


        [Display(Name = "Referral taken by:")]
        public string TakenByNow { get; set; }

        [DataType(DataType.Time)]
        public DateTime TimeNow { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateToday { get; set;}

        [Display(Name = "If over 16: Highest Form of Education: High School Dropout, High School, GED, Started College, Completed Degree, Post High School Vocational Completion, etc.")]
        public string Education { get; set; }

        [Display(Name = "Transportation Method")]
        public string TransportMethod { get; set; }

        [Display(Name = "Referring Agency / Source:")]
        public string ReferralAgency { get; set;}

        [Display(Name = "Employment")]
        public string IsEmployed { get; set; }

        [Display(Name = "Income")]
        public string Income { get; set; }

        [Display(Name = "Monthly Rent, if applicable.")]
        public string IsHoused { get; set; }

        [Display(Name = "Relationship")]
        public string Relationships { get; set; }


        [Display(Name = "Were you or are you a part of the Work Study Program?")]
        public string WorkStudy { get; set; }

        [Display(Name = "How many adults?")]
        public string AdultNum { get; set; }

        
        [Display(Name = "SSN")]
        public int SSN { get; set; }

        [Display(Name = "What is your main reason for being homeless? Eviction, Kicked Out, Diasaster, Moved, Other")]
        public Reason1? Reason { get; set; }

        [Display(Name = "What is your secondary reason for being homeless? Lost Job, Family Dissolution (Death, Divorce, etc.), Benefits Stopped, Medical Problems, Other")]
        public Reason2? Reason2 { get; set; }

        [Display(Name = "ID Number")]
        public int IDNum { get; set; }
        
        [Display(Name = "Race")]
        public string Race { get; set; }

        [Display(Name = "Gender Identity")]
        public string Gender { get; set; }

        public string FirstName { get; set; }
        [Column("FirstName")]
        [Display(Name = "First Name")]

        public string FirstMidName { get; set; }
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        [Display(Name = "Where is your spouse located?")]
        public string SpouseLocation { get; set; }

        [Display(Name = "How many children do you have in school?")]
        public int ChildSchool { get; set; }

        [Display(Name = "Grade of Child")]
        public int ChildGrade { get; set; }

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
        public DateTime DOB { get; set; }
        
        [Display(Name = "Cell Number")]
        public string CellPhoneNum { get; set; }

        [Display(Name = "Work Number")]
        public string WorkPhoneNum { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAdd { get; set;}

        [Display(Name = "Address")]
        public string HomeAddress { get; set;}
        
        [Display(Name = "Are there any additional adults in the household?")]
        public AnyHouseHold? HouseHoldMemberExists { get; set; }

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
        public AnyChildren? HouseHoldChildrenExists { get; set; }

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

    }
}
