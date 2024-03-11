using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FamilyPromiseApp.Pages.Intakes
{
    public class IntakesNamePageModel : PageModel
    {
        
        public SelectList ReferralNameSL { get; set; }


        public void PopulateReferralDropDownList(FamilyPContext _context,
            object selectedIntake = null)
        {
            var intakesQuery = from d in _context.Referrals
                                   orderby d.ReferralName // Sort by name.
                                   select d;

            ReferralNameSL = new SelectList(intakesQuery.AsNoTracking(),
                nameof(Referral.ID),
                nameof(Referral.ReferralName),
                selectedIntake);
        }
    }
}