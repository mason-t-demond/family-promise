namespace FamilyPromiseApp.Models
{
    public enum Status
    {
        Active,
        Inactive
    }


    public class Referral
    {
        public int ID { get; set; }
        public string ReferralName { get; set; }
        public string Category { get; set; }
        public Status Status { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public string Notes { get; set; }

        public ICollection<IntakeModel>? InTake {get;set;}

        public override string ToString()
      {
        return ReferralName;
      }
    }

}