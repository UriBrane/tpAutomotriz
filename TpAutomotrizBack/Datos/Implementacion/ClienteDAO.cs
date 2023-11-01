using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos.Interfaz;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizBack.Datos.Implementacion
{
    public class ClienteDAO : IClienteDAO
    {
        public int CrearCliente(Cliente c)
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
            throw new NotImplementedException();
        }
    }
}
