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
    public class IndexModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public IndexModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public IList<Resource> Resource { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Resources != null)
            {
                Resource = await _context.Resources.ToListAsync();
            }
        }
    }
}
