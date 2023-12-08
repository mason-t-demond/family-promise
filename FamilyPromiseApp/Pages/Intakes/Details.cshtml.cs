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
    public class DetailsModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DetailsModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

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
    }
}
