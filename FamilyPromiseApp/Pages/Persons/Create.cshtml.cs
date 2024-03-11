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
using SQLitePCL;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace FamilyPromiseApp.Pages.Persons
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ILogger<PageModel> _logger;

        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public CreateModel(ILogger<PageModel> ilogger, FamilyPromiseApp.Data.FamilyPContext context)
        {
            _logger = ilogger;
            _context = context;
        }

        public IActionResult OnGet()
        {
            _logger.LogInformation("OnGet called" );
            Debug.WriteLine("OnGet called" );
            Console.WriteLine("OnGet called" );
            Person = new Person();
            Case = new Case();
            List<Child> Children = new List<Child>();
            for (int i = 0; i < 12; i++)
            {
                Child = new Child();
                Children.Add(Child);                
            }

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
            int PerID = Person.ID;
            _context.Person.Add(Person);
            _context.Case.Add(Case);
            List<Child> Children = new List<Child>();
            // find the highest ID of any child in the DB
            // find the Person who is getting added to the DB
            int maxID = _context.Child.Max(c => c.ID);
            for (int j = 0; j < 3; j++) {
                Child = new Child
                {
                    // set the child's ID to the highest ID in the DB
                    ID = maxID + 1 + j,
                    PersonID = PerID,
                    FirstMidName = "Baxter",
                    LastName = Person.LastName,
                };
                Children.Add(Child);
                _logger.LogInformation("Child added to list");
                // put info into the child object
                // function addDataChildren(Children)
            }
            // add the children to the DB
            for (int i = 0; i <Children.Count; i++)
            {
                _context.Child.Add(Children[i]);
            }
            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }

        public List<Child> AddDataChildren(List<Child> Children)
        {
            for (int i = 0; i < Children.Count; i++)
            {
                Children[i].FirstMidName = "Ram";
                Children[i].LastName = "harvey";
            }
            return Children;
        }
        public List<Child> BuildChildren(int num, List<Child> children, Person Person, Case Case)
        {
            for (int i = 0; i < num; i++)
            {
                // get persons ID
                var pID = _context.Person.FirstOrDefault(p => p.ID == Person.ID);
                var cID = _context.Case.FirstOrDefault(c => c.ID == Case.ID);
                // children[i].PersonID = pID.ID;
                // children[i].CaseID = cID.ID;
                children[i].FirstMidName = "Jonah";
                children[i].LastName = "Bostrum";
            }
            return children;
        }
        public IActionResult OnPostNumChildren(int numChildren)
        {    
            Children = BuildChildren(numChildren, Children, Person, Case);
            // Optionally return a response
            return new JsonResult(Children);
        }



    }
}