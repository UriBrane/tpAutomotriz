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
        private IClienteDAO clienteDAO;

        public OrdenPedidoDAO()
        {
            helper = HelperDAO.GetInstance();
            mapeo = Mapeador.GetInstance();
            clienteDAO = new ClienteDAO();
        }

        public bool PostOrdenPedido(OrdenPedido oP)
        {
            List<Parametro> lParamDetalles = new List<Parametro>
            {
                new Parametro( "@", oP.Cliente.IdCliente),
                new Parametro( "@", oP.FechaEntrega),
                new Parametro( "@", oP.FechaPedido)
            };

        }

        public List<OrdenPedido> GetOrdenesPedido()
        {
            DataTable dt = helper.ConsultarTabla("SP_SELECT_ORDENES_PEDIDOS");
            List<OrdenPedido> l = mapeo.MapearOrdenesPedido(dt);
            return l;
        }

        public OrdenPedido GetOrdenPedido(int id)
        {
            DataTable dt = helper.ConsultarObjeto("SP_CONSULTAR_ORDEN_PEDIDO", id);
            OrdenPedido oP = mapeo.MapearOrdenPedido(dt);
            return oP;
        }

    }
}
