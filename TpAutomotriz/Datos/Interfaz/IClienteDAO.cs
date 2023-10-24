using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotriz.Entidades;

namespace TpAutomotriz.Datos.Interfaz
{
    public interface IClienteDAO
    {
        List<Cliente> GetClientes();
        int CrearCliente(Cliente c);
    }
}
