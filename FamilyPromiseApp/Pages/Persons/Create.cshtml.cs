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
using System.Globalization;


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
        [BindProperty]
        public Person Person { get; set; }

        [BindProperty]
        public Case Case { get; set; }
        public Child Child { get; set; }
        public Adult Adult { get; set; }
        public List<Child> Children { get; set; }
        public List<Adult> Adults { get; set; }
        
        public List<int> SelectedReferralIds { get; set; }
        public List<SelectListItem> AvailableReferrals { get; set; }

        public int numChildren { get; set; }

        public IActionResult OnGet()
        {
            _logger.LogInformation("OnGet called" );
            Debug.WriteLine("OnGet called" );
            Console.WriteLine("OnGet called" );
            Person = new Person();
            // find the highest ID of any person in the DB
            Case = new Case();
            Children = new List<Child>();
            Adults = new List<Adult>();
            for (int i = 0; i < 12; i++)
            {   
                Child = new Child();
                Children.Add(Child); 
                Adult = new Adult();
                Adults.Add(Adult);               
            }
            Debug.WriteLine("Number of Children at Initial: " + Children.Count());


            Person.AvailableReferrals = _context.Referrals
                .Select(r => new SelectListItem
                {
                    Value = r.ReferralName.ToString(),
                    Text = r.ReferralName
                })
                .ToList();

            return Page();
        }

        



        // [BindProperty]
        // public HouseHold NewCase { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        foreach (string name in Request.Form.Keys) {
            string value = Request.Form[name];
            Console.WriteLine("The name of this form is: " + name);
            Console.WriteLine("The value of this form is: " + value);
        }
        var BackChildren = new List<Child>();
        var BackAdults = new List<Adult>();
        int numAdult = 0;
        int numChild = 0;
        string requestNumAdult = Request.Form.Keys.FirstOrDefault(key => key == "Person.HouseHoldNum");
        if (requestNumAdult != null) {
            string requestValueAdult = Request.Form[requestNumAdult];
            numAdult = int.Parse(requestValueAdult);
        }
        string requestNumChild = Request.Form.Keys.FirstOrDefault(key => key == "Person.ChildNum");
        if (requestNumChild != null) {
            string requestValueChild = Request.Form[requestNumChild];
            numChild = int.Parse(requestValueChild);
        }
        

        Console.WriteLine("Number of Adults: " + numAdult);
        Console.WriteLine("Number of Children: " + numChild);
        
        _context.Person.Add(Person);
        await _context.SaveChangesAsync();
        _context.Case.Add(Case);
        var maxID = 0;
        var maxIDAdult = 0;
        if (_context.Child.Any()){
            maxID = _context.Child.Max(c => c.ID);
        }
        if (_context.Adult.Any()){
            maxIDAdult = _context.Adult.Max(a => a.ID);
        }
        for (int i = 1; i < numChild +1; i++)
        {
            Child = new Child
            {
                ID = maxID + 1 + i,
                PersonID = Person.ID,
                FirstMidName = Request.Form["Children[" + i + "].FirstMidName"],
                LastName = Request.Form["Children[" + i + "].LastName"],
                DateOfBirth = DateTime.Parse(Request.Form["Children[" + i + "].DateOfBirth"]),
                ChildNumber = i,
                CaseID = Case.ID
            };
            BackChildren.Add(Child);
        }
        for (int i = 0; i <BackChildren.Count; i++)
        {
            _context.Child.Add(BackChildren[i]);
            Console.WriteLine("Child added to DB");
        }
        for (int i = 1; i < numAdult +1; i++)
        {
            Adult = new Adult
            {
                ID = maxIDAdult + 1 + i,
                PersonID = Person.ID,
                FirstMidName = Request.Form["Adults[" + i + "].FirstMidName"],
                LastName = Request.Form["Adults[" + i + "].LastName"],
                DateOfBirth = DateTime.Parse(Request.Form["Adults[" + i + "].DateOfBirth"]),
                AdultNumber = i,
                CellPhone = Request.Form["Adults[" + i + "].CellPhone"],
                WorkPhone = Request.Form["Adults[" + i + "].WorkPhone"],
                Email = Request.Form["Adults[" + i + "].Email"],
                CaseID = Case.ID,
            };
            BackAdults.Add(Adult);
        }
        for (int i = 0; i <BackAdults.Count; i++)
        {
            _context.Adult.Add(BackAdults[i]);
            Console.WriteLine("Adult added to DB");
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