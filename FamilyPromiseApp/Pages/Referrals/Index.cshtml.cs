using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;

namespace FamilyPromiseApp.Pages.Referrals
{
    public class IndexModel : PageModel
{
    private readonly FamilyPContext _context;
    public IndexModel(FamilyPContext context)
    {
        _context = context;
    }

    public string CategorySort { get; set; }
    public string StatusSort { get; set; }
    public string CurrentFilter { get; set; }
    public string CurrentSort { get; set; }

    public IList<Referral> Referrals { get; set; }

    public async Task OnGetAsync(string sortOrder,string searchString)
    {
        // using System;
        CategorySort = String.IsNullOrEmpty(sortOrder) ? "category_desc" : "";
        StatusSort = String.IsNullOrEmpty(sortOrder) ? "status_desc" : "";
        CurrentFilter = searchString;

        IQueryable<Referral> referallid = from re in _context.Referrals
                                        select re;
        if (!String.IsNullOrEmpty(searchString))
        {
            referallid = referallid.Where(re => re.Category.Contains(searchString)
                                   || re.ReferralName.Contains(searchString));
        }

        switch (sortOrder)
        {
            case "category_desc":
                referallid = referallid.OrderByDescending(re => re.Category);
                break;
            
            case "status_desc":
                referallid = referallid.OrderByDescending(re => re.Status);
                break;
            default:
                referallid = referallid.OrderBy(s => s.Category);
                break;
        }

        Referrals = await referallid.AsNoTracking().ToListAsync();
    }
}
}
