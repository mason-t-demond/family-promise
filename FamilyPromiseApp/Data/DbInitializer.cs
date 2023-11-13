using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FamilyPContext context)
        {
            // Look for any students.
            if (context.Referrals.Any())
            {
                return;   // DB has been seeded
            }

            var LIHWAP = new Referral
            {
                ReferralName ="LIHWAP",
                Category ="Utility Assistance",
                Status ="Inactive",
                Address ="",
                ContactInfo= "888-985-6441",
                Notes=""
                
            };
            
            var referrals = new Referral[]
            {
               LIHWAP
               
            };

            context.Referrals.AddRange(referrals);
            context.SaveChanges();
        }
    }
}