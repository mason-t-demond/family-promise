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

namespace FamilyPromiseApp.Pages.Cases
{
    public class EditModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public EditModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NewCase NewCase { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.NewCase == null)
            {
                return NotFound();
            }

            var newcase =  await _context.NewCase.FirstOrDefaultAsync(m => m.ID == id);
            if (newcase == null)
            {
                return NotFound();
            }
            NewCase = newcase;
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

            _context.Attach(NewCase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewCaseExists(NewCase.ID))
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

        private bool NewCaseExists(int id)
        {
          return _context.NewCase.Any(e => e.ID == id);
        }
    }
}
