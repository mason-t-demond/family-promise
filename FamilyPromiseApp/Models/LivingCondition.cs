namespace FamilyPromiseApp.Models
{
    public class LivingCondition
    {
        public int LivingConditionID { get; set; }
        public int NewCaseID { get; set; }
        public string CurrentCondition { get; set; }
        public bool IsHoused { get; set; }
        public bool IsEmployed { get; set; }
        public string TransportMethod { get; set; }
        public string Substance { get; set; }
        public string HealthChallenge { get; set; }
        public string DomesticViolenceHistory { get; set;}

        public NewCase NewCase { get; set; }

    }
}