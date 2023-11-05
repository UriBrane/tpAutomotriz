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
    public class OrdenPedidoDAO : IOrdenPedidoDAO
    {
        private HelperDAO helper;
        private IMapeador mapeo;

        public OrdenPedidoDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo = Mapeador.GetInstance();
        }

        public bool PostOrdenPedido(OrdenPedido oP)
        {
            List<Parametro> lParamMaestro = new List<Parametro>
            {
                new Parametro( "@id_cliente", oP.Cliente.IdCliente),
                new Parametro( "@fecha_entrega", oP.FechaEntrega),
                new Parametro( "@fecha_pedido", oP.FechaPedido)
            };

            List<List<Parametro>> lParamDetalles = new List<List<Parametro>>();

            foreach (DetallePedido d in oP.DetallesPedido)
            {
                List<Parametro> l = new List<Parametro>
                {
                    new Parametro( "@id_orden_pedido", d.IdOrdenPedido),
                    new Parametro( "@id_producto", d.Producto.IdProducto),
                    new Parametro( "@cantidad", d.Cantidad)
                };
                lParamDetalles.Add(l);
            }
            return helper.EjecutarSQL("SP_INSERT_ORDEN_PEDIDO", "SP_INSERT_DETALLES_PED", lParamMaestro, lParamDetalles);
        }

        public List<OrdenPedido> GetOrdenesPedido()
        {
            DataTable dt = helper.ConsultarTabla("SP_SELECT_ORDENES_PEDIDOS");
            List<OrdenPedido> l = mapeo.MapearOrdenesPedido(dt);
            return l;
        }

        public OrdenPedido GetOrdenPedido(int id)
        {
            DataTable dt = helper.ConsultarTabla("SP_CONSULTAR_ORDEN_PEDIDO", "@id", id);
            OrdenPedido oP = mapeo.MapearOrdenPedido(dt);
            return oP;
        }

    }
}
