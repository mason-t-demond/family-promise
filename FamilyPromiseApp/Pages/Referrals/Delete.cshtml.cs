using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Referrals
{
    public class DeleteModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DeleteModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Referral Referral { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Referral == null)
            {
                return NotFound();
            }

            var referral = await _context.Referral.FirstOrDefaultAsync(m => m.ID == id);

            if (referral == null)
            {
                return NotFound();
            }
            else 
            {
                Referral = referral;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Referral == null)
            {
                return NotFound();
            }
            var referral = await _context.Referral.FindAsync(id);

            if (referral != null)
            {
                Referral = referral;
                _context.Referral.Remove(Referral);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
