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
using System.Linq;
using System.Security.Cryptography.Xml;


namespace FamilyPromiseApp.Pages.Persons
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public CreateModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Person = new Person();

            Person.AvailableReferrals = _context.Referrals
                .Select(r => new SelectListItem
                {
                    Value = r.ReferralName.ToString(),
                    Text = r.ReferralName
                })
                .ToList();

            return Page();
        }

        [BindProperty]
        public Person Person { get; set; }

        [BindProperty]
        public Case Case { get; set; }
        public Child Child { get; set; }
        public List<Child> Children { get; set; }
        
        public List<int> SelectedReferralIds { get; set; }
        public List<SelectListItem> AvailableReferrals { get; set; }

        public int numChildren { get; set; }



        // [BindProperty]
        // public HouseHold NewCase { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Person.Add(Person);
            _context.Case.Add(Case);
            Children = BuildChildren(3);
            for (int i = 0; i <Children.Count; i++)
            {
                _context.Child.Add(Children[i]);
            }
            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }
        public List<Child> BuildChildren(int numChildren)
        {
            List<Child> children = new List<Child>();
            for (int i = 0; i < numChildren; i++)
            {
                Child kid = new Child
                {
                    FirstMidName = "Ricky",
                    LastName = "Ricardo",
                };
                children.Add(kid);
            }
            return children;
        }
        public IActionResult OnPostNumChildren(int numChildren)
        {    
            Children = BuildChildren(numChildren);
            // Optionally return a response
            return new JsonResult(Children);
        }



    }
}