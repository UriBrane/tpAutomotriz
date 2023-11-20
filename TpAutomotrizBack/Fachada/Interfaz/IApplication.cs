using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Implementacion;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Fachada.Interfaz
{
    public interface IApplication
    {
        int ConsultarEscalar(string nombreSP, string nombreParamOut);
        
        // CLIENTE

        bool PostCliente(Cliente c);
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);
        bool PutCliente(Cliente c);

        // VENDEDOR

        bool PostVendedor(Vendedor v);
        List<Vendedor> GetVendedores();
        Vendedor GetVendedor(int id);
        bool PutVendedor(Vendedor v);

        // PRODUCTO

        bool PostProducto(Producto p);
        bool PutProducto(Producto p);
        List<Producto> GetProductos();
        List<Producto> GetProductos(int id);
        Producto GetProducto(int id);

        // ORDEN PEDIDO
        bool PostOrden(OrdenPedido op);
        OrdenPedido GetOrden(int id);
        List<OrdenPedido> GetOrdenes();

        // Factura
        bool PostFactura(Factura fac);
        Factura GetFactura(int id);
        List<Factura> GetFacturas();
    }
}
