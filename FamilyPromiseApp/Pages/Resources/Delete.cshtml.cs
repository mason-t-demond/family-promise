using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Resources
{
    public class DeleteModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DeleteModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Resource Resource { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Resources == null)
            {
                return NotFound();
            }

            var resource = await _context.Resources.FirstOrDefaultAsync(m => m.ID == id);

            if (resource == null)
            {
                return NotFound();
            }
            else 
            {
                Resource = resource;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Resources == null)
            {
                return NotFound();
            }
            var resource = await _context.Resources.FindAsync(id);

            if (resource != null)
            {
                Resource = resource;
                _context.Resources.Remove(Resource);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
