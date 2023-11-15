namespace FamilyPromiseApp.Models
{
    public class Referral
    {
        public int ID { get; set; }
        public int ReferralID { get; set; }
        public string ReferralName { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public string Notes { get; set; }
    }
}