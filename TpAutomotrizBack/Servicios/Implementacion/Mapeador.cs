using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Servicios.Interfaz;

namespace TpAutomotrizBack.Servicios.Implementacion
{
    public class Mapeador : IMapeador
    {
        public static Mapeador? instance;
        private HelperDAO helper;
        private Mapeador()
        {
            helper = HelperDAO.GetInstance();
        }
        public static Mapeador GetInstance()
        {
            if (instance == null)
                instance = new Mapeador();
            return instance;
        }

        // CLIENTE
        private Cliente MapearCliente(DataRow dr)
        {
            int id = Convert.ToInt32(dr["id_cliente"]);
            string nombre = dr["nombre"].ToString() ?? "";
            string apellido = dr["apellido"].ToString() ?? "";
            long cuit = Convert.ToInt64(dr["CUIT"]);
            string calle = dr["dire_calle"].ToString() ?? "";
            int calleNro = Convert.ToInt32(dr["dire_nro"]);
            int tipoCli = Convert.ToInt32(dr["id_tipo_cliente"]);
            int barrio = Convert.ToInt32(dr["id_barrio"]);
            Cliente c = new Cliente(id, nombre, apellido, cuit, calle, calleNro, tipoCli, barrio);
            return c;
        }
        public Cliente MapearCliente(DataTable dt)
        {
            Cliente? c = null;
            foreach (DataRow dr in dt.Rows)
            {
                c = MapearCliente(dr);
            }
            return c;
        }
        public List<Cliente> MapearClientes(DataTable dt)
        {
            List<Cliente> l = new List<Cliente>();

            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = MapearCliente(dr);
                l.Add(c);
            }
            return l;
        }

        // VENDEDOR
        private Vendedor MapearVendedor(DataRow dr)
        {
            int id = Convert.ToInt32(dr["id_vendedor"]);
            string nombre = dr["nombre"].ToString() ?? "";
            string apellido = dr["apellido"].ToString() ?? "";
            long cuit = Convert.ToInt64(dr["CUIT"]);
            DateTime fecIngr = Convert.ToDateTime(dr["fecha_ingreso"]);
            int idCat = Convert.ToInt32(dr["id_categoria"]);
            string contrasenia = dr["contrasenia"].ToString() ?? "";
            Vendedor v = new Vendedor(id, nombre, apellido, cuit, fecIngr, idCat, contrasenia);
            return v;
        }
        public Vendedor MapearVendedor(DataTable dt)
        {
            Vendedor? v = null;
            foreach (DataRow dr in dt.Rows)
            {
                v = MapearVendedor(dr);
            }
            return v;
        }
        public List<Vendedor> MapearVendedores(DataTable dt)
        {
            List<Vendedor> l = new List<Vendedor>();

            foreach (DataRow dr in dt.Rows)
            {
                Vendedor v = MapearVendedor(dr);
                l.Add(v);
            }
            return l;
        }

        // PRODUCTO
        private Producto MapearProducto(DataRow dr)
        {
            int id = Convert.ToInt32(dr["id_producto"]);
            string desc = dr["descripcion"].ToString() ?? "";
            double precio = Convert.ToDouble(dr["precio"]);
            int cant = Convert.ToInt32(dr["cantidad"]);
            int cantMayor = Convert.ToInt32(dr["cant_min_por_mayor"]);
            int cantMin = Convert.ToInt32(dr["cantidad_min"]);
            int idTipoProd = Convert.ToInt32(dr["id_tipo_producto"]);
            Producto p = new Producto(id, desc, precio, cant, cantMayor, cantMin, idTipoProd);
            return p;
        }
        public Producto MapearProducto(DataTable dt)
        {
            Producto? p = null;
            foreach (DataRow dr in dt.Rows)
            {
                p = MapearProducto(dr);
            }
            return p;
        }
        public List<Producto> MapearProductos(DataTable dt)
        {
            List<Producto> l = new List<Producto>();
            foreach (DataRow dr in dt.Rows)
            {
                Producto p = MapearProducto(dr);
                l.Add(p);
            }
            return l;
        }

        // DETALLE FACTURA
        private DetalleFactura MapearDetalleFactura(DataRow dr)
        {
            int idDetalleFac = Convert.ToInt32(dr["id_detalle"]);
            TipoVenta tipoVenta;
            if (Convert.ToInt32(dr["id_tipo_venta"]) == 1)
            {
                tipoVenta = new TipoVenta(1, "Venta al por mayor");
            }
            else {
                tipoVenta = new TipoVenta(2, "Venta al por menor");
                    
                   }

            int idFac = Convert.ToInt32(dr["id_factura"]);
            int idProd = Convert.ToInt32(dr["id_producto"]);
            DataTable dt = helper.ConsultarTabla("SP_CONSULTAR_PRODUCTO", "id", idProd);
            Producto p = MapearProducto(dt);
            int cant = Convert.ToInt32(dr["cantidad"]);
            double pre = Convert.ToDouble(dr["precio"]);
            DataTable dt2 = helper.ConsultarTabla("SP_CONSULTAR_DESCUENTO", "id", Convert.ToInt32(dr["id_descuento"]));
            Descuento des = MapearDescuento(dt2);
            string ent = dr["entregado"].ToString() ?? "";


            DetalleFactura dF = new DetalleFactura(idDetalleFac, tipoVenta, idFac, p, cant, pre, des, ent);
            return dF;
        }
        public DetalleFactura MapearDetalleFactura(DataTable dt)
        {
            DetalleFactura? dF = null;
            foreach (DataRow dr in dt.Rows)
            {
                dF = MapearDetalleFactura(dr);
            }
            return dF;
        }
        public List<DetalleFactura> MapearDetallesFactura(DataTable dt)
        {
            List<DetalleFactura> l = new List<DetalleFactura>();
            foreach (DataRow dr in dt.Rows)
            {
                DetalleFactura dF = MapearDetalleFactura(dr);
                l.Add(dF);
            }
            return l;
        }

        // DETALLE PEDIDO
        private DetallePedido MapearDetallePedido(DataRow dr)
        {
            int idDetalle = Convert.ToInt32(dr["id_pedido"]);

            int idProd = Convert.ToInt32(dr["id_producto"]);
            DataTable dtP = helper.ConsultarTabla("SP_CONSULTAR_PRODUCTO", "id", idProd);
            Producto p = MapearProducto(dtP);

            int idOrdenPed = Convert.ToInt32(dr["id_orden_pedido"]);
            int cantidad = Convert.ToInt32(dr["cantidad"]);

            DetallePedido dp = new DetallePedido(idDetalle, p, idOrdenPed, cantidad);
            return dp;
        }
        public DetallePedido MapearDetallePedido(DataTable dt)
        {
            DetallePedido? dp = null;
            foreach (DataRow dr in dt.Rows)
            {
                dp = MapearDetallePedido(dr);
            }
            return dp;
        }
        public List<DetallePedido> MapearDetallesPedido(DataTable dt)
        {
            List<DetallePedido> l = new List<DetallePedido>();
            foreach (DataRow dr in dt.Rows)
            {
                DetallePedido dp = MapearDetallePedido(dr);
                l.Add(dp);
            }
            return l;
        }

        // FACTURA
        private Factura MapearFactura(DataRow dr)
        {
            int idFac = Convert.ToInt32(dr["id_factura"]);

            int idCliente = Convert.ToInt32(dr["id_cliente"]);

            DataTable dtC = helper.ConsultarTabla("SP_CONSULTAR_CLIENTE", "@id", idCliente);
            Cliente c = MapearCliente(dtC);

            DateTime fec = Convert.ToDateTime(dr["fecha"]);

            int idVendedor = Convert.ToInt32(dr["id_vendedor"]);
            DataTable dtV = helper.ConsultarTabla("SP_CONSULTAR_CLIENTE", "@id", idVendedor);
            Vendedor v = MapearVendedor(dtV);

            int idOrdenPedido = Convert.ToInt32(dr["id_orden_pedido"]);
            DataTable dtOP = helper.ConsultarTabla("SP_CONSULTAR_ORDEN_PEDIDO", "@id", idOrdenPedido);
            OrdenPedido oP = MapearOrdenPedido(dtOP);

            int idAutoPlan = Convert.ToInt32(dr["id_autoplan"]);
            DataTable dtAP = helper.ConsultarTabla("SP_CONSULTAR_AUTOPLAN", "@id", idAutoPlan);
            AutoPlan autoplan = MapearAutoplan(dtAP);


            int idFormaPago = Convert.ToInt32(dr["id_forma_pago"]);

            DataTable dtF = helper.ConsultarTabla("", "id_factura", idFac);
            List<DetalleFactura> lDetalles = MapearDetallesFactura(dtF);

            Factura f = new Factura(idFac, c, fec, v, oP, autoplan, idFormaPago, lDetalles);
            return f;
        }

        private AutoPlan MapearAutoplan(DataTable dt)
        {
            AutoPlan ap = new AutoPlan();
            foreach (DataRow dr in dt.Rows)
            {
                ap.ID = Convert.ToInt32(dr["id_autoplan"]);
                ap.Cliente.IdCliente = Convert.ToInt32(dr["id_cliente"]);
                ap.Cuotas = Convert.ToInt32(dr["cant_coutas"]);
                ap.Interes = Convert.ToInt32(dr["interes"]);
            }

            return ap;
        }

        public Factura MapearFactura(DataTable dt)
        {
            Factura? f = null;
            foreach (DataRow dr in dt.Rows)
            {
                f = MapearFactura(dr);
            }
            return f;
        }
        public List<Factura> MapearFacturas(DataTable dt)
        {
            List<Factura> l = new List<Factura>();
            foreach (DataRow dr in dt.Rows)
            {
                Factura f = MapearFactura(dr);
                l.Add(f);
            }
            return l;
        }

        // ORDEN PEDIDO
        private OrdenPedido MapearOrdenPedido(DataRow dr)
        {
            int idOrden = Convert.ToInt32(dr["id_orden_pedido"]);

            int idCliente = Convert.ToInt32(dr["id_cliente"]);
            DataTable dtC = helper.ConsultarTabla("SP_CONSULTAR_CLIENTE", "@id", idCliente);
            Cliente c = MapearCliente(dtC);

            DateTime fecEntrega = Convert.ToDateTime(dr["fecha_entrega"]);
            DateTime fecPedido = Convert.ToDateTime(dr["fecha_pedido"]);

            DataTable dtDP = helper.ConsultarTabla("SP_CONSULTAR_DETALLES_PEDIDO", "@id_orden_pedido", idOrden);
            List<DetallePedido> lDetalles = MapearDetallesPedido(dtDP);

            OrdenPedido oP = new OrdenPedido(idOrden, c, fecEntrega, fecPedido, lDetalles);
            return oP;
        }
        public OrdenPedido MapearOrdenPedido(DataTable dt)
        {
            OrdenPedido? oP = null;
            foreach (DataRow dr in dt.Rows)
            {
                oP = MapearOrdenPedido(dr);
            }
            return oP;
        }
        public List<OrdenPedido> MapearOrdenesPedido(DataTable dt)
        {
            List<OrdenPedido> l = new List<OrdenPedido>();
            foreach (DataRow dr in dt.Rows)
            {
                OrdenPedido oP = MapearOrdenPedido(dr);
                l.Add(oP);
            }
            return l;
        }

        public Descuento MapearDescuento(DataTable dt)
        {
            Descuento descuento = new Descuento();
            foreach (DataRow dr in dt.Rows)
            {
                descuento.ID = Convert.ToInt32(dr["id_descuento"]);
                descuento.CantDescuento = Convert.ToInt32(dr["porcentaje"]);
            }

            return descuento;
        }
    }
}
