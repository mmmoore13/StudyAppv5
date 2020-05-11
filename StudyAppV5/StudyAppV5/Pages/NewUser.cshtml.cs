using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace StudyAppV5.Pages
{
    public class NewUserModel : PageModel
    {
        private readonly ILogger<NewUserModel> _logger;

        public NewUserModel(ILogger<NewUserModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
