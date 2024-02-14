using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore; // Add this namespace for Entity Framework Core

namespace FamilyPromiseApp.Pages.Intakes
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public CreateModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public SelectList ReferralSelectList { get; set; } // Use SelectList instead of List<Referral>

        public IActionResult OnGet()
        {
            // Populate the ReferralSelectList with data from the database
            var referrals = _context.Referrals.ToList(); // Assuming Referrals is the DbSet in your context
            ReferralSelectList = new SelectList(referrals, "ID", "ReferralName"); // Assuming ID is the primary key property of Referral
            return Page();
        }

        [BindProperty]
        public IntakeModel IntakeModel { get; set; }
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Intake.Add(IntakeModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}