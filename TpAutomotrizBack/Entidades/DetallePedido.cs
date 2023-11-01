using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class DetallePedido
    {
        public Producto Producto { get; set; }
        public int IdPedido { get; set; }
        public int Cantidad { get; set; }

        // UNA ORDEN PEDIDO TIENE QUE IR EN DETALLE COMO PRODUCTO COMPRADO, HAY QUE VER
        // COMO SUMA Y DESCUENTA AL STOCK PARA QUE LO PERMITA AGREGAR AL DETALLE HABIENDO
        // UN DETALLE PEDIDO O COMO REFACTORIZAR

        public DetallePedido()
        {
            Producto = new Producto();
            IdPedido = 0;
            Cantidad = 0;
        }

        public DetallePedido(Producto producto, int idPedido, int cantidad)
        {
            this.Producto = producto;
            this.IdPedido = idPedido;
            this.Cantidad = cantidad;
        }

        public override string ToString()
        {
            return IdPedido.ToString();
        }
    }
}
