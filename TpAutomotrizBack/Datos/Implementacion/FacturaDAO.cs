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
                new Parametro( "@id_forma_pago", f.IdFormaPago)
            };

            if(f.OrdenPedido.IdOrdenPedido != 0)
            {
                lParamMaestro.Add(new Parametro("@id_orden_pedido", f.OrdenPedido.IdOrdenPedido));
            }

            else
            {
                lParamMaestro.Add(new Parametro("@id_orden_pedido", DBNull.Value));
            }

            if (f.AutoPlan.ID != 0)
            {
                List<Parametro> lp = new List<Parametro>();
                lp.Add(new Parametro("@id_cliente", f.Cliente.IdCliente));
                lp.Add(new Parametro("@cant_cuotas", f.AutoPlan.Cuotas));
                lp.Add(new Parametro("@interes", f.AutoPlan.Interes));

                if (HelperDAO.GetInstance().EjecutarSQL("SP_INSERT_AUTOPLAN", lp))

                lParamMaestro.Add(new Parametro("@id_autoplan", f.AutoPlan.ID));
            }

            else
            {
                lParamMaestro.Add(new Parametro("@id_autoplan", DBNull.Value));
            }

            List<List<Parametro>> lParamDetalles = new List<List<Parametro>>();

            foreach (DetalleFactura d in f.DetallesFactura)
            {
                List<Parametro> l = new List<Parametro>
                {
                    new Parametro( "@id_tipo_venta", d.TipoVenta.ID),
                    new Parametro( "@id_producto", d.Producto.IdProducto),
                    new Parametro( "@cantidad", d.Cantidad),
                    new Parametro( "@precio", d.Precio),
                    new Parametro( "@id_descuento", d.Descuento.ID)
                };
                lParamDetalles.Add(l);
            }

            return helper.EjecutarSQL("SP_INSERT_FACTURA", "SP_INSERT_DETALLES_FAC", lParamMaestro, lParamDetalles);
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
