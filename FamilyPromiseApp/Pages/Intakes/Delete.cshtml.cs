using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Intakes
{
    public class DeleteModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DeleteModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        [BindProperty]
      public IntakeModel IntakeModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Intake == null)
            {
                return NotFound();
            }

            var intakemodel = await _context.Intake.FirstOrDefaultAsync(m => m.ID == id);

            if (intakemodel == null)
            {
                return NotFound();
            }
            else 
            {
                IntakeModel = intakemodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Intake == null)
            {
                return NotFound();
            }
            var intakemodel = await _context.Intake.FindAsync(id);

            if (intakemodel != null)
            {
                IntakeModel = intakemodel;
                _context.Intake.Remove(IntakeModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
