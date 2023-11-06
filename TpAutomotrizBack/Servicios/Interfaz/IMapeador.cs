using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Servicios.Interfaz
{
    public interface IMapeador
    {
        // CLIENTE
        Cliente MapearCliente(DataTable dt);
        List<Cliente> MapearClientes(DataTable dt);

        // VENDEDOR
        Vendedor MapearVendedor(DataTable dt);
        List<Vendedor> MapearVendedores(DataTable dt);

        // PRODUCTO
        Producto MapearProducto(DataTable dt);
        List<Producto> MapearProductos(DataTable dt);

        // FACTURA
        Factura MapearFactura(DataTable dt);
        List<Factura> MapearFacturas(DataTable dt);

        // DETALLE FACTURA
        DetalleFactura MapearDetalleFactura(DataTable dt);
        List<DetalleFactura> MapearDetallesFactura(DataTable dt);

        // DETALLE PEDIDO
        DetallePedido MapearDetallePedido(DataTable dt);
        List<DetallePedido> MapearDetallesPedido(DataTable dt);

        // ORDEN PEDIDIO
        OrdenPedido MapearOrdenPedido(DataTable dt);
        List<OrdenPedido> MapearOrdenesPedido(DataTable dt);
    }
}
