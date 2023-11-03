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
    public class VendedorDAO : IVendedorDAO
    {
        public bool PostVendedor(Vendedor v)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@nombre", v.Nombre),
                new Parametro( "@apellido", v.Apellido),
                new Parametro( "@CUIT", v.Cuit),
                new Parametro( "@fecha_ingreso", v.FechaIngreso),
                new Parametro( "@id_categoria", v.IdCategoria),
            };
            return HelperDAO.GetInstance().EjecutarSQL("SP_INSERT_VENDEDOR", parametros);
        }
        public List<Vendedor> GetVendedores()
        {
            List<Vendedor> l = new List<Vendedor>();
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_SELECT_VENDEDORES");
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

    }
}
