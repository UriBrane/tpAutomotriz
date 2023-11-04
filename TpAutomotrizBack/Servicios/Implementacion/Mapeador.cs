using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizBack.Servicios.Interfaz;

namespace TpAutomotrizBack.Servicios.Implementacion
{
    public class Mapeador : IMapeador
    {
        public static Mapeador instance;
        private Mapeador() { }
        public static Mapeador GetInstance()
        {
            if (instance == null)
                instance = new Mapeador();
            return instance;
        }

        // CLIENTE
        public Cliente MapearCliente(DataTable dt)
        {
            Cliente? c = null;
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_cliente"]);
                string nombre = dr["nombre"].ToString() ?? "";
                string apellido = dr["apellido"].ToString() ?? "";
                string cuit = (dr["CUIT"]).ToString() ?? "";
                string calle = dr["dire_calle"].ToString() ?? "";
                int calleNro = Convert.ToInt32(dr["dire_nro"]);
                int tipoCli = Convert.ToInt32(dr["id_tipo_cliente"]);
                int barrio = Convert.ToInt32(dr["id_barrio"]);
                c = new Cliente(id, nombre, apellido, cuit, calle, calleNro, tipoCli, barrio);
            }
            return c;
        }

        public List<Cliente> MapearClientes(DataTable dt)
        {
            List<Cliente> l = new List<Cliente>();

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_cliente"]);
                string nombre = dr["nombre"].ToString() ?? "";
                string apellido = dr["apellido"].ToString() ?? "";
                string cuit = (dr["CUIT"]).ToString() ?? "";
                string calle = dr["dire_calle"].ToString() ?? "";
                int calleNro = Convert.ToInt32(dr["dire_nro"]);
                int tipoCli = Convert.ToInt32(dr["id_tipo_cliente"]);
                int barrio = Convert.ToInt32(dr["id_barrio"]);

                Cliente c = new Cliente(id, nombre, apellido, cuit, calle, calleNro, tipoCli, barrio);
                l.Add(c);
            }
            return l;
        }

        // VENDEDOR
        public Vendedor MapearVendedor(DataTable dt)
        {
            Vendedor? v = null;
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_vendedor"]);
                string nombre = dr["nombre"].ToString() ?? "";
                string apellido = dr["apellido"].ToString() ?? "";
                string cuit = (dr["CUIT"]).ToString() ?? "";
                DateTime fecIngr = Convert.ToDateTime(dr["fecha_ingreso"]);
                int idCat = Convert.ToInt32(dr["id_categoria"]);

                v = new Vendedor(id, nombre, apellido, cuit, fecIngr, idCat);
            }
            return v;
        }

        public List<Vendedor> MapearVendedores(DataTable dt)
        {
            List<Vendedor> l = new List<Vendedor>();

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_vendedor"]);
                string nombre = dr["nombre"].ToString() ?? "";
                string apellido = dr["apellido"].ToString() ?? "";
                string cuit = (dr["CUIT"]).ToString() ?? "";
                DateTime fecIngr = Convert.ToDateTime(dr["fecha_ingreso"]);
                int idCat = Convert.ToInt32(dr["id_categoria"]);

                Vendedor v = new Vendedor(id, nombre, apellido, cuit, fecIngr, idCat);
                l.Add(v);
            }
            return l;
        }

        // PRODUCTO
        public Producto MapearProducto(DataTable dt)
        {
            Producto? p = null;
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_producto"]);
                string desc = dr["descripcion"].ToString() ?? "";
                double precio = Convert.ToDouble(dr["precio"]);
                int cant = Convert.ToInt32(dr["cantidad"]);
                int cantMayor = Convert.ToInt32(dr["cant_min_por_mayor"]);
                int cantMin = Convert.ToInt32(dr["cantidad_min"]);
                int idTipoProd = Convert.ToInt32(dr["id_tipo_producto"]);

                p = new Producto(id, desc, precio, cant, cantMayor, cantMin, idTipoProd);
            }
            return p;
        }
        public List<Producto> MapearProductos(DataTable dt)
        {
            List<Producto> l = new List<Producto>();
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_producto"]);
                string desc = dr["descripcion"].ToString() ?? "";
                double precio = Convert.ToDouble(dr["precio"]);
                int cant = Convert.ToInt32(dr["cantidad"]);
                int cantMayor = Convert.ToInt32(dr["cant_min_por_mayor"]);
                int cantMin = Convert.ToInt32(dr["cantidad_min"]);
                int idTipoProd = Convert.ToInt32(dr["id_tipo_producto"]);

                Producto p = new Producto(id, desc, precio, cant, cantMayor, cantMin, idTipoProd);
                l.Add(p);
            }
            return l;
        }

        // DETALLE FACTURA
        public DetalleFactura MapearDetalleFactura(DataTable dt)
        {
            throw new NotImplementedException();
        }
        public List<DetalleFactura> MapearDetallesFactura(DataTable dt)
        {
            throw new NotImplementedException();
        }

        // DETALLE PEDIDO
        public DetallePedido MapearDetallePedido(DataTable dt)
        {
            throw new NotImplementedException();
        }
        public List<DetallePedido> MapearDetallesPedido(DataTable dt)
        {
            throw new NotImplementedException();
        }

        // FACTURA
        public Factura MapearFactura(DataTable dt)
        {
            throw new NotImplementedException();
        }
        public List<Factura> MapearFacturas(DataTable dt)
        {
            throw new NotImplementedException();
        }

        // ORDEN PEDIDO
        public List<OrdenPedido> MapearOrdenesPedido(DataTable dt)
        {
            throw new NotImplementedException();
        }
        public OrdenPedido MapearOrdenPedido(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
