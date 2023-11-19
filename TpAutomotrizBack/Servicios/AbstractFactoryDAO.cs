using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Interfaz;

namespace TpAutomotrizBack.Servicios
{
    public abstract class AbstractFactoryDAO
    {
        public abstract IClienteDAO CrearClienteDAO();
        public abstract IFacturaDAO CrearFacturaDAO();
        public abstract IOrdenPedidoDAO CrearOrdenPedidoDAO();
        public abstract IProductoDAO CrearProductoDAO();
        public abstract IVendedorDAO CrearVendedorDAO();

    }
}
