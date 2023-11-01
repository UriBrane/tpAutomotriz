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
        // public DetallePedido DetallePedido { get; set; }
        public int IdOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaPedido { get; set; }
        public List<DetallePedido> DetallesPedido { get; set; }

        public OrdenPedido()
        {
            // DetallePedido = null;
            IdOrden = 0;
            FechaEntrega = DateTime.Today.AddDays(1);
            FechaPedido = DateTime.Today;
            DetallesPedido = new List<DetallePedido>();
        }



        public OrdenPedido( // DetallePedido detallePedido, 
            int id_orden, DateTime fechaEntrega, DateTime fechaPedido, List<DetallePedido> detPed)
        {
            //DetallePedido = detallePedido;
            this.IdOrden = id_orden;
            this.FechaEntrega = fechaEntrega;
            this.FechaPedido = fechaPedido;
            this.DetallesPedido = detPed;
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
