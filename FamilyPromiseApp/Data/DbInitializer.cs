using System.ComponentModel.Design;
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
                ID = 1,
                ReferralName = "LIHWAP",
                Category = "Utility Assistance",
                Status = "Inactive",
                Address = "N/A",
                ContactInfo= "888-985-6441",
                Notes= "N/A"
            };
            var Central_AR_Development_Council_LiHEAP = new Referral
            {
                ID = 2,
                ReferralName = "Central AR Development Council LiHEAP",
                Category = "Utility Assistance",
                Status = "Inactive",
                Address = "N/A",
                ContactInfo= "501-326-6229",
                Notes= "Intake form must be completed in-person."
            };
            var Entergy = new Referral
            {
                ID = 3,
                ReferralName = "Entergy",
                Category = "Utility Assistance",
                Status = "Active",
                Address = "N/A",
                ContactInfo= "N/A",
                Notes= "N/A"
            };
            var St_Francis_House_Utility_Assistance_Program = new Referral
            {
                ID = 4,
                ReferralName = "St. Francis House Utility Assistance Program",
                Category = "Utility Assistance",
                Status = "Active",
                Address = "N/A",
                ContactInfo= "501-777-5803",
                Notes= "Serves veterans only."
            };
            var St_Vincent_De_Paul_Assistance_Program = new Referral
            {
                ID = 5,
                ReferralName = "St. Vincent De Paul Assistance Program",
                Category = "Utility Assistance",
                Status = "Active",
                Address = "N/A",
                ContactInfo= "501-819-2059",
                Notes= "NLR and Sherwood residents only."
            };
            var CAPCA = new Referral
            {
                ID = 6,
                ReferralName = "Community Action Program for Central Arkansas (CAPCA)",
                Category = "Rental Assistance",
                Status = "Active",
                Address = "N/A",
                ContactInfo = "501-329-0977",
                Notes = "N/A"
            };
            var Better_Community_Development_Inc = new Referral
            {
                ID = 7,
                ReferralName = "Better Community Development, Inc.",
                Category = "Housing Assistance",
                Status = "Active",
                Address = "N/A",
                ContactInfo = "501-663-7221",
                Notes = "N/A"
            };
            var Stew_Pot = new Referral
            {
                ID = 8,
                ReferralName = "Stew Pot",
                Category = "Hot Meals",
                Status = "Active",
                Address = "800 Scott St. LR, AR 72201",
                ContactInfo = "501-372-1804",
                Notes = "M-F 12:00-1:00 PM"
            };
            var Salvation_Army = new Referral
            {
                ID = 9,
                ReferralName = "Salvation Army",
                Category = "Hot Meals",
                Status = "Active",
                Address = "1111 W. Markham St. LR, AR 72201",
                ContactInfo = "501-374-9296",
                Notes = "Every day 7:00-7:50 AM"
            };
            var Canvas_Community_Church = new Referral
            {
                ID = 10,
                ReferralName = "Canvas Community Church",
                Category = "Hot Meals",
                Status = "Active",
                Address = "1111 W. 7th St. LR, AR 72201",
                ContactInfo = "501-351-1531",
                Notes = "M-W 4:00-6:00 PM; 1st and 3rd Saturdays 11:00 AM-12:30 PM"
            };
            var Friendly_Chapel = new Referral
            {
                ID = 11,
                ReferralName = "Friendly Chapel",
                Category = "Hot Meals",
                Status = "Active",
                Address = "116 S. Pine St. NLR, AR 72114",
                ContactInfo = "501-371-0912",
                Notes = "F 10:00 AM-12:00 PM"
            };
            var LR_Compassion_Center = new Referral
            {
                ID = 12,
                ReferralName = "Little Rock Compassion Center",
                Category = "Hot Meals",
                Status = "Active",
                Address = "3618 W. Roosevelt Rd. LR, AR 72204",
                ContactInfo = "501-296-9114",
                Notes = "Every day 6:30-7:00 AM, 12:00-12:30 PM, and 4:30-5:30 PM"
            };
            var From_His_Throne_Ministries = new Referral
            {
                ID = 13,
                ReferralName = "From His Throne Ministries",
                Category = "Hot Meals",
                Status = "Active",
                Address = "2501 S. Arch St. LR, AR 72206",
                ContactInfo = "501-944-1209",
                Notes = "Sun 11:00 AM; M,T, and F 5:00-7:00 PM"
            };
            var Jericho_Way_HotMeals = new Referral
            {
                ID = 14,
                ReferralName = "Jericho Way",
                Category = "Hot Meals",
                Status = "Active",
                Address = "3000 Springer Blvd. LR, AR 72206",
                ContactInfo = "501-916-9858",
                Notes = "M-F 7:30-8:30 AM and 11:00 AM-12:00 PM"
            };
            var River_City_Ministry_HotMeals = new Referral
            {
                ID = 15,
                ReferralName = "River City Ministry",
                Category = "Hot Meals",
                Status = "Active",
                Address = "1021 E. Washington Ave. NLR, AR 72214",
                ContactInfo = "501-376-6694",
                Notes = "M-F 7:30 AM and 11:30 AM; Sun. 2:00 PM"
            };
            var St_Mark_Baptist_Church = new Referral
            {
                ID = 16,
                ReferralName = "St. Mark Baptist Church",
                Category = "Hot Meals",
                Status = "Active",
                Address = "5722 W. 12th St. LR, AR 72204",
                ContactInfo = "501-663-3955",
                Notes = "4th Sun. 10:00 AM-12:00 PM"
            };
            var Quapaw_Quarter= new Referral
            {
                ID = 17,
                ReferralName = "Quapaw Quarter United Methodist Church",
                Category = "Hot Meals",
                Status = "Active",
                Address = "1601 S. Louisiana St. LR, AR 72206",
                ContactInfo = "501-375-1600",
                Notes = "Sun. 7:30-8:30 AM and 3:00 PM; Kits available 8:30 AM-12:30 PM"
            };
            var River_City_Ministry_Hygeine = new Referral
            {
                ID = 18,
                ReferralName = "River City Ministry",
                Category = "Hygeine Resources: Shower Facilities",
                Status = "Active",
                Address = "1021 E. Washington Ave. NLR, AR 72114",
                ContactInfo = "501-376-6694",
                Notes = "M-F 9:00-10:45 AM"
            };
            var Jericho_Way_HygeineShower = new Referral
            {
                ID = 19,
                ReferralName = "Jericho Way",
                Category = "Hygeine Resources: Shower Facilities",
                Status = "Active",
                Address = "3000 Springer Blvd. LR, AR 72206",
                ContactInfo = "501-916-9858",
                Notes = "M-F 7:30-11:45 AM and 12:00-1:00 PM"
            };
            var Immerse_AR_HygeineShower = new Referral
            {
                ID = 20,
                ReferralName = "Immerse AR",
                Category = "Hygeine Resources: Shower Facilities",
                Status = "Active",
                Address = "5300 Asher Ave. LR, AR",
                ContactInfo = "N/A",
                Notes = "M,T, and R 8:00 AM-5:00 PM; W 10:00 AM-5:00 PM; F 8:00 AM-3:00 PM; Ages 14-24 only",
            };
            var Lucies_Place_HygeineShower = new Referral
            {
                ID = 21,
                ReferralName = "Lucie's Place",
                Category = "Hygeine Resources: Shower Facilities",
                Status = "Active",
                Address = "307 W. 7th St. LR, AR",
                ContactInfo = "N/A",
                Notes = "F 11:00 AM-5:00 PM; LGBTQ+ youth only",
            };
            var Jericho_Way_HygeineLaundry = new Referral
            {
                ID = 22,
                ReferralName = "Jericho Way",
                Category = "Hygeine Resources: Laundry Facilities",
                Status = "Active",
                Address = "3000 Springer Blvd. LR, AR 72206",
                ContactInfo = "501-916-9858",
                Notes = "M-W 7:00 AM; 25 loads per day",
            };
            var Immerse_AR_HygeineLaundry = new Referral
            {
                ID = 23,
                ReferralName = "Immerse AR",
                Category = "Hygeine Resources: Laundry Facilities",
                Status = "Active",
                Address = "5300 Asher Ave. LR, AR",
                ContactInfo = "N/A",
                Notes = "M,T, and R 8:00 AM-5:00 PM; W 10:00 AM-5:00 PM; F 8:00 AM-3:00 PM; Ages 14-24 only",
            };
            var Lucies_Place_HygeineLaundry = new Referral
            {
                ID = 24,
                ReferralName = "Lucie's Place",
                Category = "Hygeine Resources: Laundry Facilities",
                Status = "Active",
                Address = "307 W. 7th St. LR, AR",
                ContactInfo = "N/A",
                Notes = "F 11:00 AM-5:00 PM; LGBTQ+ youth only"
            };
            var Arkansas_Legal_Aid = new Referral
            {
                ID = 25,
                ReferralName = "Arkansas Legal Aid",
                Category = "Legal Services",
                Status = "Active",
                Address = "N/A",
                ContactInfo = "1-800-952-9243",
                Notes = "N/A"
            };
            var Center_AR_Legal_Services = new Referral
            {
                ID = 26,
                ReferralName = "Center for Arkansas Legal Services",
                Category = "Legal Services",
                Status = "Active",
                Address = "N/A",
                ContactInfo = "501-376-3423",
                Notes = "N/A"
            };
            
            var referrals = new Referral[]
            {
               LIHWAP,
               Central_AR_Development_Council_LiHEAP,
               Entergy,
               St_Francis_House_Utility_Assistance_Program,
               St_Vincent_De_Paul_Assistance_Program,
               CAPCA,
               Better_Community_Development_Inc,
               Stew_Pot,
               Salvation_Army,
               Canvas_Community_Church,
               LR_Compassion_Center,
               From_His_Throne_Ministries,
               Jericho_Way_HotMeals,
               River_City_Ministry_HotMeals,
               St_Mark_Baptist_Church,
               Quapaw_Quarter,
               River_City_Ministry_Hygeine,
               Jericho_Way_HygeineShower,
               Immerse_AR_HygeineShower,
               Lucies_Place_HygeineShower,
               Jericho_Way_HygeineLaundry,
               Immerse_AR_HygeineLaundry,
               Lucies_Place_HygeineLaundry,
               Arkansas_Legal_Aid,
               Center_AR_Legal_Services
            };

            context.Referrals.AddRange(referrals);
            context.SaveChanges();

            var Social_Supports = new Resource
            {
                ID = 1,
                Category ="Social Supports",
            };
            var Solutions_for_Immediate_Housing_Crisis = new Resource
            {
                ID = 2,
                Category ="Solutions for Immediate Housing Crisis",
            };
            var Mediation_Conflict_Resolution_Services = new Resource
            {
                ID = 3,
                Category ="Mediation/Conflict Resolution Services",
            };
            var Stable_Housing_Plan = new Resource
            {
                ID = 4,
                Category ="Stable Housing Plan",
            };
            var Financial_Education = new Resource
            {
                ID = 5,
                Category ="Financial Education",
            };
            var Employment_Services = new Resource
            {
                ID = 6,
                Category = "Employment Services"
            };
            var Financial_Assistance = new Resource
            {
                ID = 7,
                Category = "Financial Assistance"
            };

            var resources = new Resource[]
            {
               Social_Supports,
               Solutions_for_Immediate_Housing_Crisis,
               Mediation_Conflict_Resolution_Services,
               Stable_Housing_Plan,
               Financial_Education,
               Employment_Services,
               Financial_Assistance
            };
            context.Resource.AddRange(resources);
            context.SaveChanges();
        }
    }
}