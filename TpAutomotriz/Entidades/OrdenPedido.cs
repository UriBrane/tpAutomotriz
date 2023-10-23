using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotriz.Entidades
{
    public class OrdenPedido
    {
        private List<DetallePedido> detPed;
        private DetallePedido DetallePedido;
        private int id_orden;
        private DateTime fechaEntrega;
        private DateTime fechaPedido;

        public OrdenPedido()
        {
            DetallePedido = null;
            id_orden = 0;
            fechaEntrega =  DateTime.Today.AddDays(1);
            fechaPedido = DateTime.Today;
            DetPed = new List<DetallePedido>();

        }

       

        public OrdenPedido(DetallePedido detallePedido, int id_orden, DateTime fechaEntrega, DateTime fechaPedido, List<DetallePedido> detPed)
        {
            DetallePedido1 = detallePedido;
            this.Id_orden = id_orden;
            this.FechaEntrega = fechaEntrega;
            this.FechaPedido = fechaPedido;
            this.DetPed = detPed;
        }

        public DetallePedido DetallePedido1 { get => DetallePedido; set => DetallePedido = value; }
        public int Id_orden { get => id_orden; set => id_orden = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public List<DetallePedido> DetPed { get => detPed; set => detPed = value; }

        //hacer consulta para ver que ordenes estan pendientes y modificar estado entregado o no

        public void AgregarPedido(DetallePedido detalle)
        {
            detPed.Add(detalle);

        }

        public void QuitarPedido(int posicion)
        {
            detPed.RemoveAt(posicion);

        }



    }
}
