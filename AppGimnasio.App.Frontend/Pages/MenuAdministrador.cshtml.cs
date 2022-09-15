using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppGimnasio.App.Frontend.Pages
{
    public class MenuAdministrador : PageModel
    {
        private readonly ILogger<MenuAdministrador> _logger;

        public MenuAdministrador(ILogger<MenuAdministrador> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}