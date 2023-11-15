using System.Net.Sockets;
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
                ReferralID = 1,
                ReferralName ="LIHWAP",
                Category ="Utility Assistance",
                Status ="Inactive",
                Address = "N/A",
                ContactInfo= "888-985-6441",
                Notes=""
                
            };
            var Central_AR_Development_Council_LiHEAP = new Referral
            {
                ReferralID = 2,
                ReferralName = "Central AR Development Council LiHEAP",
                Category ="Utility Assistance",
                Status ="Inactive",
                Address ="N/A",
                ContactInfo= "501-326-6229",
                Notes="Intake form must be completed in-person."
            };
            var Entergy = new Referral
            {
                ReferralID = 3,
                ReferralName = "Entergy",
                Category ="Utility Assistance",
                Status ="active",
                Address ="N/A",
                ContactInfo= "N/A",
                Notes="N/A"
            };
            var St_Francis_House_Utility_Assistance_Program = new Referral
            {
                ReferralID = 4,
                ReferralName = "St. Francis House Utility Assistance Program",
                Category ="Utility Assistance",
                Status ="active",
                Address ="N/A",
                ContactInfo= "501-777-5803",
                Notes="Serves veterans only."
            };
            var St_Vincent_De_Paul_Assistance_Program = new Referral
            {
                ReferralID = 5,
                ReferralName = "St. Vincent De Paul Assistance Program",
                Category ="Utility Assistance",
                Status ="active",
                Address ="N/A",
                ContactInfo= "501-819-2059",
                Notes="NLR and Sherwood residents only."
            };
            
            var referrals = new Referral[]
            {
               LIHWAP,
               Central_AR_Development_Council_LiHEAP,
               Entergy,
               St_Francis_House_Utility_Assistance_Program,
               St_Vincent_De_Paul_Assistance_Program
            };

            context.Referrals.AddRange(referrals);
            context.SaveChanges();

            var Social_Supports = new Resource
            {
                ResourceID = 1,
                Category ="Utility Assistance",
 
            };
            var Solutions_for_Immediate_Housing_Crisis = new Resource
            {
                ResourceID = 2,
                Category ="Solutions for Immediate Housing Crisis",
            };
            var Mediation_Conflict_Resolution_Services = new Resource
            {
                ResourceID = 3,
                Category ="Mediation/Conflict Resolution Services",
            };
            var Stable_Housing_Plan = new Resource
            {
                ResourceID = 4,
                Category ="Stable Housing Plan",
            };
            var Financial_Education = new Resource
            {
                ResourceID = 5,
                Category ="Financial Education",
            };
            var resources = new Resource[]
            {
               Social_Supports,
               Solutions_for_Immediate_Housing_Crisis,
               Mediation_Conflict_Resolution_Services,
               Stable_Housing_Plan,
               Financial_Education
            };
            context.Resource.AddRange(resources);
            context.SaveChanges();
            

        }
    }
}