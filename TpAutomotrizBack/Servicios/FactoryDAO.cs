using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Implementacion;
using TpAutomotrizBack.Datos.Interfaz;

namespace TpAutomotrizBack.Servicios
{
    public class FactoryDAO : AbstractFactoryDAO
    {
        public override IClienteDAO CrearClienteDAO()
        {
            return new ClienteDAO();
        }

        public override IFacturaDAO CrearFacturaDAO()
        {
            return new FacturaDAO();
        }

        public override IOrdenPedidoDAO CrearOrdenPedidoDAO()
        {
            return new OrdenPedidoDAO();
        }

        public override IProductoDAO CrearProductoDAO()
        {
            return new ProductoDAO();
        }

        public override IVendedorDAO CrearVendedorDAO()
        {
            return new VendedorDAO();
        }
    }
}
