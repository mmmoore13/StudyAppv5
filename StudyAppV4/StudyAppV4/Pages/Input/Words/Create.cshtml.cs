using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudyAppV4.Models;

namespace StudyAppV4.Pages.Input.Words
{
    public class CreateModel : PageModel
    {
        private readonly TermContext _context;

        public CreateModel(TermContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Term Term { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Term.Add(Term);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
