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
        // public DetalleFactura DetalleFactura { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public OrdenPedido OrdenPedido { get; set; }
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> DetFac { get; set; }

        public Factura()
        {
            // DetalleFactura = null;
            Vendedor = new Vendedor();
            Cliente = new Cliente();
            OrdenPedido = new OrdenPedido();
            IdFactura = 0;
            Fecha = DateTime.Today;
            DetFac = new List<DetalleFactura>();

        }

        public Factura( // DetalleFactura detalleFactura, 
            Vendedor vendedor, Cliente cliente, OrdenPedido ordenPedido, int idFactura, DateTime fecha, List<DetalleFactura> detFac)
        {
            //this.DetalleFactura = detalleFactura;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
            this.OrdenPedido = ordenPedido;
            this.IdFactura = idFactura;
            this.Fecha = fecha;
            this.DetFac = detFac;
        }

        public void AgregarDetalleFactura(DetalleFactura detalle)
        {
            DetFac.Add(detalle);
        }

        public void QuitarDetalleFactura(int posicion)
        {
            DetFac.RemoveAt(posicion);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura d in DetFac)
                total += d.CalcularSubtotal();
            return total;
        }
    }
}

