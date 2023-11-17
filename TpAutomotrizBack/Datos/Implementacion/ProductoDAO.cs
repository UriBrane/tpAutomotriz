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
    public class ProductoDAO : IProductoDAO
    {
        private HelperDAO helper;
        private IMapeador mapeo;

        public ProductoDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo= Mapeador.GetInstance();
        }
        public bool PostProducto(Producto p)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@descripcion", p.Descripcion),
                new Parametro( "@precio", p.Precio),
                new Parametro( "@cantidad", p.Cantidad),
                new Parametro( "@cant_min_por_mayor", p.CantMinPorMayor),
                new Parametro( "@cantidad_min", p.CantidadMin),
                new Parametro( "@id_tipo_producto", p.IdTipoProducto),
            };
            return helper.EjecutarSQL("SP_INSERT_PRODUCTO", parametros);
        }

        public bool PutProducto(Producto p)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@IdProducto", p.IdProducto),
                new Parametro( "@Descripcion", p.Descripcion),
                new Parametro( "@precio", p.Precio),
                new Parametro( "@cantidad", p.Cantidad),
                new Parametro( "@CantMinPorMayor", p.CantMinPorMayor),
                new Parametro( "@CantidadMin", p.CantidadMin),
                new Parametro( "@IdTipoProducto", p.IdTipoProducto),
            };
            return helper.EjecutarSQL("SP_UPDATE_PRODUCTOS", parametros);
        }

        public List<Producto> GetProductos()
        {
            DataTable dt = helper.ConsultarTabla("SP_SELECT_PRODUCTOS");
            List<Producto> l = mapeo.MapearProductos(dt);
            return l;
        }

        public Producto GetProducto(int id)
        {
            DataTable dt = helper.ConsultarTabla("SP_CONSULTAR_PRODUCTO", "@id", id);
            Producto p = mapeo.MapearProducto(dt);
            return p;
        }

        public List<Producto> GetProductos(int idTipo)
        {
            DataTable dt = helper.ConsultarTabla("SP_CONSULTAR_PRODUCTOS", "@idTipo", idTipo);
            List<Producto> l = mapeo.MapearProductos(dt);
            return l;
        }
    }
}
