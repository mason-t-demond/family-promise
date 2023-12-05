using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Cases
{
    public class DetailsModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DetailsModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

      public NewCase NewCase { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.NewCase == null)
            {
                return NotFound();
            }

            var newcase = await _context.NewCase.FirstOrDefaultAsync(m => m.ID == id);
            if (newcase == null)
            {
                return NotFound();
            }
            else 
            {
                NewCase = newcase;
            }
            return Page();
        }
    }
}
