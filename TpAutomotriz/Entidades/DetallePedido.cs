using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotriz.Entidades
{
    public class DetallePedido
    {
        private Producto producto;
        private int id_pedido;
        private int cantidad;

        // UNA ORDEN PEDIDO TIENE QUE IR EN DETALLE COMO PRODUCTO COMPRADO, HAY QUE VER
        // COMO SUMA Y DESCUENTA AL STOCK PARA QUE LO PERMITA AGREGAR AL DETALLE HABIENDO
        // UN DETALLE PEDIDO O COMO REFACTORIZAR

        public DetallePedido()
        {
            producto = null;
            id_pedido = 0;
            cantidad = 0;
        }

        public DetallePedido(Producto producto, int id_pedido, int cantidad)
        {
            this.Producto = producto;
            this.Id_pedido = id_pedido;
            this.Cantidad = cantidad;
        }

        public Producto Producto { get => producto; set => producto = value; }
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return id_pedido.ToString();
        }
    }
}
