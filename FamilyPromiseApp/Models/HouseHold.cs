namespace FamilyPromiseApp.Models
{
    public class HouseHold
    {
        public int HouseHoldID { get; set; }
        public int NewCaseID { get; set; }
        public int NumAdults { get; set; }
        public string NameAdult { get; set; }
        public int AgeAdult { get; set; }
        public DateTime AdultDOB { get; set; }
        public string AdultPhone { get; set; }
        public int AdultWorkPhone { get; set; }
        public string AdultEmail { get; set; }

        public int NumChild { get; set; }
        public DateTime ChildDOB { get; set; }
        public int ChildAge { get; set; }
        
        public NewCase NewCase { get; set; }

    }
}