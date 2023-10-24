using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TpAutomotriz.Entidades
{
    public class Factura
    {

        private DetalleFactura detalleFactura;
        private Vendedor vendedor;
        private Cliente cliente;
        private OrdenPedido ordenPedido;
        private int id_factura;
        private DateTime fecha;
        private List<DetalleFactura> detFac;

        public Factura()
        {
            detalleFactura = null; vendedor = null; cliente = null;
            ordenPedido = null; id_factura = 0; fecha = DateTime.Today;
            DetFac = new List<DetalleFactura>();

        }

        public Factura(DetalleFactura detalleFactura, Vendedor vendedor, Cliente cliente, OrdenPedido ordenPedido, int id_factura, DateTime fecha, List<DetalleFactura> detFac)
        {
            this.DetalleFactura = detalleFactura;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
            this.OrdenPedido = ordenPedido;
            this.Id_factura = id_factura;
            this.Fecha = fecha;
            this.DetFac = detFac;
        }

        public DetalleFactura DetalleFactura { get => detalleFactura; set => detalleFactura = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public OrdenPedido OrdenPedido { get => ordenPedido; set => ordenPedido = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<DetalleFactura> DetFac { get => detFac; set => detFac = value; }

        public void AgregarDetalleFactura(DetalleFactura detalle)
        {
            detFac.Add(detalle);
        }

        public void QuitarDetalleFactura(int posicion)
        {
            detFac.RemoveAt(posicion);
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (DetalleFactura d in detFac)
            {
                total += d.CalcularSubtotal();

            }
            return total;
        }
    }
}

