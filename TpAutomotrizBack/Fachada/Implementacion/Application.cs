using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Implementacion;
using TpAutomotrizBack.Datos.Interfaz;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Interfaz;

namespace TpAutomotrizBack.Fachada.Implementacion
{
    public class Application : IApplication
    {
        private IClienteDAO clienteDao;
        public Application()
        {
            clienteDao = new ClienteDAO();
        }

        public List<Cliente> GetClientes()
        {
            return clienteDao.GetClientes();
        }

        public bool CrearCliente(Cliente c)
        {
            return clienteDao.CrearCliente(c);
        }
    }
}
