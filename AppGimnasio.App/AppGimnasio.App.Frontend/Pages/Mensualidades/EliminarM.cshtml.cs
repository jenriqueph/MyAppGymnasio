using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppGimnasio.App.Frontend.Pages.Mensualidades
{
    public class EliminarM : PageModel
    {
        private readonly ILogger<EliminarM> _logger;

        public EliminarM(ILogger<EliminarM> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}