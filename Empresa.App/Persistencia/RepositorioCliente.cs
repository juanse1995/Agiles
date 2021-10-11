using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using Dominio;
using Persistencia;
using Microsoft.EntityFrameworkCore;


//Falta llevar al Main()

namespace Persistencia
{
    public class RepositorioCliente : I_RepositorioCliente

    {
        private readonly ApplicationContext  _appContext;
        public RepositorioCliente(ApplicationContext  appContext)
        {
            _appContext = appContext;
        }

        Cliente I_RepositorioCliente.AddCliente(Cliente cliente)
        {
            var ClienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return ClienteAdicionado.Entity;
        }

        void I_RepositorioCliente.DeleteCliente(int IdCliente)
        {
            var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(cli => cli.Id == IdCliente);
            if (ClienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(ClienteEncontrado);
            _appContext.SaveChanges();
        }

        /*Cliente I_RepositorioCliente.EsCliente(int IdCliente, int IdEmpresa)
        {
            var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(cli => cli.Id == IdCliente);
            if (ClienteEncontrado != null)
            {
                var empresaEncontrada = _appContext.Empresas.FirstOrDefault(em => em.Id == IdEmpresa);
                if (empresaEncontrada != null)
                {
                    ClienteEncontrado.EsCliente = empresaEncontrada;
                    _appContext.SaveChanges();
                }
                return ClienteEncontrado;
            }
            return null;
        }*/

        IEnumerable<Cliente> I_RepositorioCliente.GetAllCliente()
        {
            return _appContext.Clientes.AsNoTracking().Include(p => p.PerRef).Include(e => e.EmpRef);
        }

        Cliente I_RepositorioCliente.GetCliente(int IdCliente)
        {
            return _appContext.Clientes.Include(p => p.PerRef).Include(e => e.EmpRef).Where(cli => cli.Id == IdCliente).FirstOrDefault();            
        }

        Cliente I_RepositorioCliente.UpdateCliente(Cliente cliente)
        {
            //var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(cli => cli.Id == cliente.Id);            
            var ClienteEncontrado =_appContext.Clientes.Include(p => p.PerRef).Include(e => e.EmpRef).FirstOrDefault(cli => cli.Id == cliente.Id);
            Console.WriteLine("Cliente Encontrado:" + ClienteEncontrado.Id);
            Console.WriteLine("Cliente Actualizar:" + cliente.Id);
            if (ClienteEncontrado != null)
            {
                ClienteEncontrado.PerRef.Nombre = cliente.PerRef.Nombre;
                ClienteEncontrado.PerRef.Apellidos = cliente.PerRef.Apellidos;
                ClienteEncontrado.PerRef.Documento = cliente.PerRef.Documento;
                ClienteEncontrado.PerRef.FechaNacimiento = cliente.PerRef.FechaNacimiento;
                ClienteEncontrado.Telefono = cliente.Telefono;
                ClienteEncontrado.EmpresaId = cliente.EmpresaId;           
                _appContext.SaveChanges();
            }               
            return ClienteEncontrado;
        }
    }
}