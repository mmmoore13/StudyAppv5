using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudyAppV2.Models;

namespace StudyAppV2.Pages.Input.Terms
{
    public class DeleteModel : PageModel
    {
        private readonly TermContext _context;

        public DeleteModel(TermContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Term Term { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Term = await _context.Term.FirstOrDefaultAsync(m => m.ID == id);

            if (Term == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Term = await _context.Term.FindAsync(id);

            if (Term != null)
            {
                _context.Term.Remove(Term);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
