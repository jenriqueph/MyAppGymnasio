using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AppGimnasio.App.Dominio;

namespace AppGimnasio.App.Persistencia
{
    public interface IRepositorioCliente
    {
     IEnumerable<Cliente> GetAllClientes();
     Cliente AddCliente(Cliente cliente);
     Cliente UpdateCliente(Cliente cliente);
     void DeleteCliente(int idCliente);
     Cliente GetCliente(int idCliente);
     Rutina AsignarRutina(int idCliente, int idRutina);
     IEnumerable<Cliente> GetClientePorFiltro(string filtro);
    //  IEnumerable<Rutina> GetRutinasCliente(int idCliente);
    }
}