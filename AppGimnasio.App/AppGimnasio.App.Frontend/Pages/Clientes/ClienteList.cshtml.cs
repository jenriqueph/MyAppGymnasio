using System.ComponentModel;
using System;
using AppGimnasio.App.Dominio;
using AppGimnasio.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppGimnasio.App.Frontend.Pages.Clientes
{
    public class ClienteListModel : PageModel
    {
        //[BindProperty(SupportsGet =true)]
        //public string FiltroBusqueda { get; set; }
        //public readonly IRepositorioCliente repositorioCliente;
        //public IEnumerable<Cliente> Clientes { get; set; }
        
        //public ClienteListModel(IRepositorioCliente repositorioCliente) 
        //{
        //    this.repositorioCliente = repositorioCliente;
        //}

        public void OnGet()//String filtroBusqueda)
        {
            //FiltroBusqueda = filtroBusqueda;
            //Clientes = repositorioCliente.GetClientePorFiltro(filtroBusqueda);
        }
    }
}
