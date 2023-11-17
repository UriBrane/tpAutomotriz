using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Datos.Implementacion;
using TpAutomotrizBack.Datos.Interfaz;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Fachada.Interfaz;

namespace TpAutomotrizBack.Fachada.Implementacion
{
    public class Application : IApplication
    {
        private IClienteDAO clienteDAO;
        private IVendedorDAO vendedorDAO;
        private IProductoDAO productoDAO;
        private IOrdenPedidoDAO ordenDAO;
        public Application()
        {
            clienteDAO = new ClienteDAO();
            vendedorDAO = new VendedorDAO();
            productoDAO = new ProductoDAO();
            ordenDAO = new OrdenPedidoDAO();
        }
        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            return HelperDAO.GetInstance().ConsultarEscalar(nombreSP,nombreParamOut);
        }

        // CLIENTE

        public bool PostCliente(Cliente c)
        {
            return clienteDAO.PostCliente(c);
        }
        public List<Cliente> GetClientes()
        {
            return clienteDAO.GetClientes();
        }
        public Cliente GetCliente(int id)
        {
            return clienteDAO.GetCliente(id);
        }
        public bool PutCliente(Cliente c)
        {
            return clienteDAO.PutCliente(c);
        }

        // VENDEDOR

        public bool PostVendedor(Vendedor v)
        {
            return vendedorDAO.PostVendedor(v);
        }
        public List<Vendedor> GetVendedores()
        {
            return vendedorDAO.GetVendedores();
        }
        public Vendedor GetVendedor(int id)
        {
            return vendedorDAO.GetVendedor(id);
        }
        public bool PutVendedor(Vendedor v)
        {
            return vendedorDAO.PutVendedor(v);
        }

        // PRODUCTO

        public bool PostProducto(Producto p)
        {
            return productoDAO.PostProducto(p);
        }
        public List<Producto> GetProductos()
        {
            return productoDAO.GetProductos();
        }
        public List<Producto> GetProductos(int idTipo)
        {
            return productoDAO.GetProductos(idTipo);
        }
        public Producto GetProducto(int id)
        {
            return productoDAO.GetProducto(id);
        }
        public bool PutProducto(Producto p)
        {
            return productoDAO.PutProducto(p);
        }

        // ORDEN PEDIDO

        public bool PostOrden(OrdenPedido op)
        {
            return ordenDAO.PostOrdenPedido(op);
        }
    }
}
