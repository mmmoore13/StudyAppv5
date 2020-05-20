using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudyAppV4.Models;

namespace StudyAppV4.Pages.Input.Words
{
    public class IndexModel : PageModel
    {
        private readonly TermContext _context;

        public IndexModel(TermContext context)
        {
            _context = context;
        }

        public IList<Term> Term { get;set; }

        public async Task OnGetAsync()
        {
            Term = await _context.Term.ToListAsync();
        }
    }
}
