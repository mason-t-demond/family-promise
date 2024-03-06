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
    public class CreateModel : IntakesNamePageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public CreateModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public SelectList ReferralSelectList { get; set; } // Use SelectList instead of List<Referral>

        public IActionResult OnGet()
        {
            PopulateReferralDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public IntakeModel IntakeModel { get; set; }  = default!;
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyIntakes = new IntakeModel();

         if (await TryUpdateModelAsync<IntakeModel>(
            emptyIntakes,
            "intakes",   // Prefix for form value.
            c => c.ReferralAgency 
            ))
            {
            _context.Intake.Add(IntakeModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
            }

            PopulateReferralDropDownList(_context, emptyIntakes.ReferralAgency);
            return Page();

        }
    }
}