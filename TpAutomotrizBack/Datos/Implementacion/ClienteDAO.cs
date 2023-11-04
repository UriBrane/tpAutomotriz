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
    public class ClienteDAO : IClienteDAO
    {
        private HelperDAO helper;
        private IMapeador mapeo;

        public ClienteDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo = Mapeador.GetInstance();
        }
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
            return helper.EjecutarSQL("SP_INSERT_CLIENTE", parametros);
        }

        public List<Cliente> GetClientes()
        {
            DataTable dt = helper.ConsultarTabla("SP_SELECT_CLIENTES");
            List<Cliente> l = mapeo.MapearClientes(dt);
            return l;
        }

        public Cliente GetCliente(int id)
        {
            DataTable dt = helper.ConsultarObjeto("SP_CONSULTAR_CLIENTE", id);
            Cliente c = mapeo.MapearCliente(dt);
            return c;
        }
    }
}
