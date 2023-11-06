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
        public int IdOrdenPedido { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaPedido { get; set; }
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
        public OrdenPedido(int id_orden, Cliente cliente, DateTime fechaEntrega
                          , DateTime fechaPedido, List<DetallePedido> detPed)
        {
            IdOrdenPedido = id_orden;
            Cliente = cliente;
            FechaEntrega = fechaEntrega;
            FechaPedido = fechaPedido;
            DetallesPedido = detPed;
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
