using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class OrdenPedido
    {
        [JsonProperty("idOrdenPedido")]
        public int IdOrdenPedido { get; set; }

        [JsonProperty("cliente")]
        public Cliente Cliente { get; set; }

        [JsonProperty("fechaEntrega")]
        public DateTime FechaEntrega { get; set; }

        [JsonProperty("fechaPedido")]
        public DateTime FechaPedido { get; set; }

        [JsonProperty("detallesPedido")]
        public List<DetallePedido> DetallesPedido { get; set; }


        public OrdenPedido()
        {
            IdOrdenPedido = 0;
            Cliente = new Cliente();
            FechaEntrega = DateTime.Today.AddDays(1);
            FechaPedido = DateTime.Today;
            DetallesPedido = new List<DetallePedido>();
        }
        public OrdenPedido(Cliente cliente, DateTime fechaEntrega
                          , DateTime fechaPedido, List<DetallePedido> detPed)
        {
            Cliente = cliente;
            FechaEntrega = fechaEntrega;
            FechaPedido = fechaPedido;
            DetallesPedido = detPed;
        }

        [JsonConstructor]
        public OrdenPedido(int idOrdenPedido, Cliente cliente, DateTime fechaEntrega
                          , DateTime fechaPedido, List<DetallePedido> detallesPedido)
        {
            IdOrdenPedido = idOrdenPedido;
            Cliente = cliente;
            FechaEntrega = fechaEntrega;
            FechaPedido = fechaPedido;
            DetallesPedido = detallesPedido;
        }

        //hacer consulta para ver que ordenes estan pendientes y modificar estado entregado o no

        public void AgregarPedido(DetallePedido detalle)
        {
            DetallesPedido.Add(detalle);
        }

        public void QuitarPedido(int posicion)
        {
            DetallesPedido.RemoveAt(posicion);
        }

    }
}
