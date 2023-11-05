using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class DetallePedido
    {
        public int IdDetallePedido { get; set; }
        public Producto Producto { get; set; }
        public int IdOrdenPedido { get; set; }
        public int Cantidad { get; set; }

        // UNA ORDEN PEDIDO TIENE QUE IR EN DETALLE COMO PRODUCTO COMPRADO, HAY QUE VER
        // COMO SUMA Y DESCUENTA AL STOCK PARA QUE LO PERMITA AGREGAR AL DETALLE HABIENDO
        // UN DETALLE PEDIDO O COMO REFACTORIZAR

        public DetallePedido()
        {
            IdDetallePedido = 0;
            Producto = new Producto();
            IdOrdenPedido = 0;
            Cantidad = 0;
        }
        public DetallePedido(Producto producto, int idOrdenPedido, int cantidad)
        {
            Producto = producto;
            IdOrdenPedido = idOrdenPedido;
            Cantidad = cantidad;
        }
        public DetallePedido(int idDetPed,Producto producto, int idOrdenPedido, int cantidad)
        {
            IdDetallePedido = idDetPed;
            Producto = producto;
            IdOrdenPedido = idOrdenPedido;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return IdOrdenPedido.ToString();
        }
    }
}
