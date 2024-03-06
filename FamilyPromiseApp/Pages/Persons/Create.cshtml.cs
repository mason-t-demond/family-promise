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
            for (int i = 0; i <3; i++)
            {
                Child kid = new Child
                {
                    DateOfBirth = new DateTime(2010, 1, 1),
                    FirstMidName = "Bobby M",
                    LastName = "Broccoli"
                };
                _context.Child.Add(kid);
            }
            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }

        public void AddFillerChild(Child child)
        {
            if (Children == null)
            {
                Children = new List<Child>();
            }
            Children.Add(child);
        }

        public List<Child> PopulateChildren(int numChildren)
        {
            for (int i = 0; i < numChildren; i++)
            {
                Child kid = new Child
            {
                DateOfBirth = new DateTime(2010, 1, 1),
                FirstMidName = "Bobby M",
                LastName = "Broccoli"
            };
                AddFillerChild(kid);
            }
            return Children;
        }

        public List<Child> AddChildren(List<Child> children, int numChildren)
        {
            if (children == null)
            {
                children = new List<Child>();
            }
            for (int i = 0; i < numChildren; i++)
            {
                Child kid = new Child
                {
                    DateOfBirth = new DateTime(2010, 1, 1),
                    FirstMidName = "Bobby M",
                    LastName = "Broccoli"
                };
                children.Add(kid);
            }
            return children;
        }
        

    }
}