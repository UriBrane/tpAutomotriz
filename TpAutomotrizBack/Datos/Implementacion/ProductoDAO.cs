using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Interfaz;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Datos.Implementacion
{
    public class ProductoDAO : IProductoDAO
    {
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
            return HelperDAO.GetInstance().EjecutarSQL("INSERT_PRODUCTO", parametros);
        }
        public List<Producto> GetProductos()
        {
            List<Producto> l = new List<Producto>();
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_SELECT_PRODUCTOS");
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

    }
}
