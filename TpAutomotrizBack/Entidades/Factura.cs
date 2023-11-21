using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizBack.Entidades
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public Vendedor Vendedor { get; set; }
        public OrdenPedido OrdenPedido { get; set; }
        public AutoPlan AutoPlan { get; set; }
        public int IdFormaPago { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }

        public Factura()
        {
            IdFactura = 0;
            Cliente = new Cliente();
            Fecha = DateTime.Today;
            Vendedor = new Vendedor();
            OrdenPedido = new OrdenPedido();
            AutoPlan = new AutoPlan();
            IdFormaPago = 0;
            DetallesFactura = new List<DetalleFactura>();
        }
        public Factura(Cliente cliente, DateTime fecha, Vendedor vendedor, OrdenPedido ordenPedido
                       , AutoPlan idAutoPlan, int idFormaPago, List<DetalleFactura> detallesFac)
        {
            Cliente = cliente;
            Fecha = fecha;
            Vendedor = vendedor;
            OrdenPedido = ordenPedido;
            AutoPlan = idAutoPlan;
            IdFormaPago = idFormaPago;
            DetallesFactura = detallesFac;
        }
        public Factura(int idFactura, Cliente cliente, DateTime fecha, Vendedor vendedor, OrdenPedido ordenPedido
                       , AutoPlan idAutoPlan, int idFormaPago, List<DetalleFactura> detallesFac)
        {
            IdFactura = idFactura;
            Cliente = cliente;
            Fecha = fecha;
            Vendedor = vendedor;
            OrdenPedido = ordenPedido;
            AutoPlan = idAutoPlan;
            IdFormaPago = idFormaPago;
            DetallesFactura = detallesFac;
        }

        public void AgregarDetalleFactura(DetalleFactura detalle)
        {
            DetallesFactura.Add(detalle);
        }

        public void QuitarDetalleFactura(int posicion)
        {
            DetallesFactura.RemoveAt(posicion);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura d in DetallesFactura)
                total += d.CalcularSubtotal();
            return total;
        }
    }
}

