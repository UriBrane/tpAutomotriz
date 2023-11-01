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
        public bool CrearCliente(Cliente c)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro( "@tipo",c.TipoCliente),
                new Parametro( "@nombre", c.Nombre),
                new Parametro( "@apellido", c.Apellido),
                new Parametro( "@cuit", c.Cuit),
                new Parametro( "@calle", c.Calle),
                new Parametro( "@nro", c.CalleNro),
                new Parametro( "@barrio", c.Barrio)
            };

            return HelperDAO.GetInstance().EjecutarSQL("INSERT_CLIENTES", parametros);
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> l = new List<Cliente>();
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SELECT_CLIENTES");
            foreach (DataRow dr in dt.Rows)
            {
                string nombre = dr["nombre"].ToString();
                string apellido = dr["apellido"].ToString();
                int cuit = Convert.ToInt32(dr["CUIT"]);
                string calle = dr["dire_calle"].ToString();
                int calleNro = Convert.ToInt32(dr["dire_nro"]);
                int tipoCli = Convert.ToInt32(dr["id_tipo_cliente"]);
                int barrio = Convert.ToInt32(dr["id_barrio"]);

                Cliente c = new Cliente(nombre, apellido, cuit, calle, calleNro, tipoCli, barrio);
                l.Add(c);
            }
            return l;
        }
    }
}
