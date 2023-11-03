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
    public class ClienteDAO : IClienteDAO
    {
        public bool PostCliente(Cliente c)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@nombre", c.Nombre),
                new Parametro( "@apellido", c.Apellido),
                new Parametro( "@CUIT", c.Cuit),
                new Parametro( "@id_tipo_cliente", c.TipoCliente),
                new Parametro( "@dire_calle", c.Calle),
                new Parametro( "@dire_nro", c.CalleNro),
                new Parametro( "@id_barrio", c.IdBarrio)
            };
            return HelperDAO.GetInstance().EjecutarSQL("SP_INSERT_CLIENTE", parametros);
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> l = new List<Cliente>();
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_SELECT_CLIENTES");
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
    }
}
