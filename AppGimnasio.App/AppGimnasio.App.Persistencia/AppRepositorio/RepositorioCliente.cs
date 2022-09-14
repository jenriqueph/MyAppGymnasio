using System;
using System.Collections.Generic;
using System.Linq;
using AppGimnasio.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AppGimnasio.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext _appContext;
        ///<param name = "appContext"></param>
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Cliente AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        public void DeleteCliente(int idCliente)        
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return GetAllClientes_();
        }

        public IEnumerable<Cliente> GetAllClientes_()
        {
            return _appContext.Clientes;
        }

        public IEnumerable<Cliente> GetClientePorFiltro(string filtro)
        {
            var clientes = GetAllClientes();
            if (clientes != null)
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    clientes = clientes.Where(s => s.Nombres.Contains(filtro));
                }
            }
            return clientes;
        }

        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombres = cliente.Nombres;
                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }

        public Rutina AsignarRutina(int idCliente, int idRutina)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
            if (clienteEncontrado !=  null)
            {
                var rutinaEncontrada = _appContext.Rutinas.FirstOrDefault(r => r.Id == idRutina);
                if (rutinaEncontrada != null)
                {
                    clienteEncontrado.Rutina = rutinaEncontrada;
                    _appContext.SaveChanges();
                }
                return rutinaEncontrada;
            }
            return null;
        }

        // IEnumerable<Rutina> IRepositorioCliente.GetRutinasCliente(int idCliente)
        // {
        //     var cliente = _appContext.Clientes.Where(c => c.Id == idCliente)
        //                                          .Include(c => c.Ejercicio1)
        //                                          .FirstOrDefault();
        //     return cliente.Rutinas;
        // }
    }
}