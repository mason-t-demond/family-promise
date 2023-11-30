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
        public string CategorySort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Resource> Resources { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder,string searchString)
        {
            CategorySort = String.IsNullOrEmpty(sortOrder) ? "category_desc" : "";
            CurrentFilter = searchString;
            IQueryable<Resource> resourceid = from r in _context.Resources
                                        select r;
            if (!String.IsNullOrEmpty(searchString))
            {
                resourceid = resourceid.Where(r => r.Category.Contains(searchString)
                                   );
            }

            switch (sortOrder)
            {
                case "category_desc":
                    resourceid = resourceid.OrderByDescending(r => r.Category);
                    break;
            
                default:
                    resourceid = resourceid.OrderBy(s => s.Category);
                    break;
            }

            Resources = await resourceid.AsNoTracking().ToListAsync();
        }
    }
}
