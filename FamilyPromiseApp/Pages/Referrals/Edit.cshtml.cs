using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Referrals
{
    public class EditModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public EditModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Referral Referral { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Referral == null)
            {
                return NotFound();
            }

            var referral =  await _context.Referral.FirstOrDefaultAsync(m => m.ID == id);
            if (referral == null)
            {
                return NotFound();
            }
            Referral = referral;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Referral).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReferralExists(Referral.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ReferralExists(int id)
        {
          return _context.Referral.Any(e => e.ID == id);
        }
    }
}
