using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Interfaz;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Servicios.Implementacion;
using TpAutomotrizBack.Servicios.Interfaz;

namespace TpAutomotrizBack.Datos.Implementacion
{
    public class FacturaDAO : IFacturaDAO
    {
        private HelperDAO helper;
        private IMapeador mapeo;
        private IClienteDAO clienteDAO;
        private IVendedorDAO vendedorDAO;

        public FacturaDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo = Mapeador.GetInstance();
            clienteDAO = new ClienteDAO();
            vendedorDAO = new VendedorDAO();
        }
        public bool PostFactura(Factura f)
        {
            List<Parametro> lParamMaestro = new List<Parametro>
            {
                new Parametro( "@id_cliente", f.Cliente.IdCliente),
                new Parametro( "@fecha", f.Fecha),
                new Parametro( "@id_vendedor", f.Vendedor.IdVendedor),
                new Parametro( "@id_orden_pedido", f.OrdenPedido.IdOrden),
                new Parametro( "@id_autoplan", f.IdAutoPlan),
                new Parametro( "@id_forma_pago", f.IdFormaPago)
            };

            List<List<Parametro>> lParamDetalles = new List<List<Parametro>>();

            foreach (DetalleFactura d in f.DetallesFactura)
            {
                List<Parametro> l = new List<Parametro>
                {
                    new Parametro( "@id_tipo_venta", d.IdTipoVenta),
                    new Parametro( "@id_factura", d.IdFactura),
                    new Parametro( "@id_producto", d.Producto.IdProducto),
                    new Parametro( "@cantidad", d.Cantidad),
                    new Parametro( "@precio", d.Precio),
                    new Parametro( "@id_descuento", d.IdDescuento)
                };
                lParamDetalles.Add(l);
            }

            return helper.EjecutarSQL("SP_INSERT_FACTURA", "SP_INSERT_DETALLES_FAC", lParamMaestro, lParamDetalles);
        }

        public List<Factura> GetFacturas()
        {
            List<Factura> l = new List<Factura>();
            DataTable dt = helper.ConsultarTabla("SP_SELECT_FACTURAS");
            foreach (DataRow dr in dt.Rows)
            {
                int idFac = Convert.ToInt32(dr["id_factura"]);

                int idCliente = Convert.ToInt32(dr["id_cliente"]);

                // Mapeo del cliente de la Factura
                DataTable dtC = helper.ConsultarObjeto("SP_CONSULTAR_CLIENTE", idCliente);
                Cliente c = mapeo.MapearCliente(dtC);                

                DateTime fec = Convert.ToDateTime(dr["fecha"]);

                // Mapeo del Vendedor de la Factura
                int idVendedor = Convert.ToInt32(dr["id_vendedor"]);
                DataTable dtV = helper.ConsultarObjeto("SP_CONSULTAR_CLIENTE", idVendedor);
                Vendedor v = mapeo.MapearVendedor(dtV);

                // Mapeo del Orden de Pedido de la Factura
                int idOrdenPedido = Convert.ToInt32(dr["id_orden_pedido"]);
                DataTable dtOP = helper.ConsultarObjeto("SP_CONSULTAR_ORDEN_PEDIDO", idOrdenPedido);
                OrdenPedido oP = mapeo.MapearOrdenPedido(dtOP);

                int idAutoPlan = Convert.ToInt32(dr["id_autoplan"]);
                int idFormaPago = Convert.ToInt32(dr["id_forma_pago"]);



                Factura f = new Factura(idFac,c, fec, v, oP, idAutoPlan, idFormaPago, lDetalles);
            }
        }
    }
}
