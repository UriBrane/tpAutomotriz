using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class DetallePedido
    {
        [JsonProperty("idDetallePedido")]
        public int IdDetallePedido { get; set; }

        [JsonProperty("producto")]
        public Producto Producto { get; set; }

        [JsonProperty("idOrdenPedido")]
        public int IdOrdenPedido { get; set; }

        [JsonProperty("cantidad")]
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

        [JsonConstructor]
        public DetallePedido(int idDetallePedido, Producto producto, int idOrdenPedido, int cantidad)
        {
            IdDetallePedido = idDetallePedido;
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
