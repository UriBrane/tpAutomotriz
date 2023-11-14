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
        // CLIENTE

        bool PostCliente(Cliente c);
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);

        // VENDEDOR

        bool PostVendedor(Vendedor v);
        List<Vendedor> GetVendedores();
        Vendedor GetVendedor(int id);

        // PRODUCTO

        bool PostProducto(Producto p);
        List<Producto> GetProductos();
        Producto GetProducto(int id);


    }
}
