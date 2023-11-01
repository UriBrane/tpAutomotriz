using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Fachada.Interfaz
{
    public interface IApplication
    {
        bool CrearCliente(Cliente c);
        List<Cliente> GetClientes();
    }
}
