using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppGimnasio.App.Frontend.Pages.Mensualidades
{
    public class RegistraM : PageModel
    {
        private readonly ILogger<RegistraM> _logger;

        public RegistraM(ILogger<RegistraM> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}