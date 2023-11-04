using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Datos.Interfaz
{
    public interface IClienteDAO
    {
        Cliente GetCliente(int id);
        List<Cliente> GetClientes();
        bool PostCliente(Cliente c);
    }
}
