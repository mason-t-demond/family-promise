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
    public class DetailsModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public DetailsModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

      public Person Person { get; set; }
      public Case Case { get; set; }

      public Child Child { get; set; }
        public Adult Adult { get; set; }

      public List<Child> Children { get; set; }
        public List<Adult> Adults { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null || _context.Person == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FirstOrDefaultAsync(m => m.ID == id);
            Case = _context.Case.FirstOrDefault(c => c.ID == id);
            if (person == null)
            {
                return NotFound();
            }
            else 
            {
                Person = person;
            }
            // for each child in the case, if the associated person ID is the same as the ID of the person we are looking at, add that child to the list of children
            // for every child in the databases, add that child to the list of children
            Console.WriteLine("Length of Children: " + _context.Child.Count());
            Console.WriteLine("Length of Adults: " + _context.Adult.Count());
            Children = new List<Child>();
            Adults = new List<Adult>();
            foreach (Child child in _context.Child)
            {
                if (child.PersonID == person.ID)
                {
                    Children.Add(child);
                }
            }
            // for (int i = 0; i < _context.Child.Count(); i++)
            // {
            //     Child = _context.Child.FirstOrDefault(c => c.ID == i);
            //     Children.Add(Child);
            //     // if (Child.PersonID == person.ID)
            //     // {
            //     //     Console.WriteLine("Child ID: " + Child.ID);
            //     //     Children.Add(Child);
            //     // }
            // }
            foreach (Adult adult in _context.Adult)
            {
                if (adult.PersonID == person.ID)
                {
                    Adults.Add(adult);
                }
            }
            // for (int i = 0; i < _context.Adult.Count(); i++)
            // {
            //     Adult = _context.Adult.FirstOrDefault(a => a.ID == i);
            //     Adults.Add(Adult);
            //     // if (Adult.PersonID == person.ID)
            //     // {
            //     //     Console.WriteLine("Adult ID: " + Adult.ID);
            //     //     Adults.Add(Adult);
            //     // }
            // }
            
            
            return Page();
        }
    }
}