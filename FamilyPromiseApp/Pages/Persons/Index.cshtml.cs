using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public IndexModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;
        public IList<Case> Case { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }

            if (_context.Case != null)
            {
                Case = await _context.Case.ToListAsync();
            }
        }
    }
}
