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

        public FacturaDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo = Mapeador.GetInstance();
        }
        public bool PostFactura(Factura f)
        {
            List<Parametro> lParamMaestro = new List<Parametro>
            {
                new Parametro( "@id_cliente", f.Cliente.IdCliente),
                new Parametro( "@fecha", f.Fecha),
                new Parametro( "@id_vendedor", f.Vendedor.IdVendedor),
                new Parametro( "@id_orden_pedido", f.OrdenPedido.IdOrdenPedido),
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

            return helper.EjecutarSQL("SP_INSERT_FACTURA", "SP_INSERT_DETALLES_FAC", " crear sp ", lParamMaestro, lParamDetalles);
        }

        public List<Factura> GetFacturas()
        {
            DataTable dt = helper.ConsultarTabla("SP_SELECT_FACTURAS");
            List<Factura> l = mapeo.MapearFacturas(dt);
            return l;
        }

        public Factura GetFactura(int id)
        {
            DataTable dt = helper.ConsultarTabla("SP_CONSULTAR_FACTURA");
            Factura f = mapeo.MapearFactura(dt);
            return f;
        }
    }
}
