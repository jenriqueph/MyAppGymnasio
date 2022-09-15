using AppGimnasio.App.Dominio;
using AppGimnasio.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppGimnasio.App.Frontend.Pages.Clientes
{
    public class ClienteEditModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        [BindProperty]
        public Cliente Cliente { get; set; }

        public ClienteEditModel (IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                Cliente = repositorioCliente.GetCliente(clienteId.Value);
            }
            else
            {
                Cliente = new Cliente();
            }

            if (Cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
