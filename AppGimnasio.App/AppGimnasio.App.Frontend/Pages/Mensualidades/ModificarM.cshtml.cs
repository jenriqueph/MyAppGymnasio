using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppGimnasio.App.Frontend.Pages.Mensualidades
{
    public class ModificarM : PageModel
    {
        private readonly ILogger<ModificarM> _logger;

        public ModificarM(ILogger<ModificarM> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}