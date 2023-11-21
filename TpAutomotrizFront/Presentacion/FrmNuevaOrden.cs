using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;
using System.Runtime.Intrinsics.Arm;
using System.Collections;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaOrden : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador? val;
        private CargarCombo? cargarCbo;
        private int idOrdenPed;
        bool nueva;
        private Factura factura;
        private List<DetalleFactura> detallesSinStock;

        public FrmNuevaOrden() // Constructor default
        {
            InitializeComponent();
            nueva = true;
        }

        public FrmNuevaOrden(Factura fac, List<DetalleFactura> lstFac)
        {
            factura = fac;
            detallesSinStock = lstFac;
            InitializeComponent();
            nueva = true;
            CargarDgvDetalles();

            txtCliente.Text = factura.Cliente.Apellido + "," + factura.Cliente.Nombre;
            txtVendedor.Text = factura.Vendedor.Apellido + "," + factura.Vendedor.Nombre;
            txtCliente.Enabled = false;
            txtVendedor.Enabled = false;
        }

        private void CargarDgvDetalles()
        {
            dgvDetallesFac.Rows.Clear();
            double total = 0;
            foreach (DetalleFactura df in factura.DetallesFactura)
            {

                dgvDetallesFac.Rows.Add(new object[] { df.Producto.IdProducto,
                                                        df.Producto.Descripcion,
                                                       df.Cantidad,
                                                       df.CalcularSubtotal(),
                                                       df.Descuento.CantDescuento,
                                                       df.TipoVenta.Tipo,
                                                        "Eliminar"});
                total = total + df.CalcularSubtotal();
            }

            lblTotal.Text = "TOTAL: " + total;
        }

        public FrmNuevaOrden(int id) // Constructor para ver una orden
        {
            InitializeComponent();
            nueva = false;
            idOrdenPed = id;
        }

        private async void FrmNuevaOrden_LoadAsync(object sender, EventArgs e)
        {
            CargarNroOrden();
        }

        private void HabilitarControles(bool v)
        {
            cboVendedor.Enabled = v;
            cboCliente.Enabled = v;
            dtpFecha.Enabled = v;
            cboProducto.Enabled = v;
            nudCantidad.Enabled = v;
            btnAgregar.Enabled = v;
            dgvDetallesPed.Enabled = v;
            btnGuardar.Enabled = v;
        }

        private async Task<OrdenPedido> TraerOrden(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            OrdenPedido o = JsonConvert.DeserializeObject<OrdenPedido>(dataJson);
            return o;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // VALIDACION
        }


        private async void CargarNroOrden()
        {
            idOrdenPed = await SiguienteNroOrden("/ordenpedido/consultarid");
            lblNOrden.Text = lblNOrden.Text + " " + idOrdenPed.ToString();
        }

        private async Task<int> SiguienteNroOrden(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            int id = JsonConvert.DeserializeObject<int>(dataJson);
            return id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async Task MapearOrden()
        {
            OrdenPedido orden = new OrdenPedido();
            orden.Cliente = factura.Cliente;
            orden.FechaEntrega = AjustarDiaHabil(DateTime.Today.AddDays(90));
            orden.FechaPedido = DateTime.Today;
            orden.IdOrdenPedido = idOrdenPed;

            List<DetallePedido> ldp = new List<DetallePedido>();
            foreach (DetalleFactura df in factura.DetallesFactura)
            {
                DetallePedido dp = new DetallePedido();
                dp.Producto = df.Producto;
                dp.Cantidad = df.Cantidad;
                dp.IdOrdenPedido = orden.IdOrdenPedido;
                ldp.Add(dp);
            }

            factura.OrdenPedido = orden;

            if (await GrabarOrden(orden))
            {
                MessageBox.Show("Se registró con éxito la Orden de Pedido.\n    Fecha de Entrega: " + orden.FechaEntrega.ToString("dd-MM-yyyy")
                                , "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orden = new OrdenPedido();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la Orden de Pedido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task<bool> GrabarOrden(OrdenPedido orden)
        {
            string ordenJson = JsonConvert.SerializeObject(orden);
            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + "/ordenpedido", ordenJson);
            return dataJson.Equals("true");
        }

        public DateTime AjustarDiaHabil(DateTime fecha)
        {
            // Si la fecha cae en sábado, se ajusta al próximo lunes.
            if (fecha.DayOfWeek == DayOfWeek.Saturday)
            {
                return fecha.AddDays(2);
            }
            // Si la fecha cae en domingo, se ajusta al próximo lunes.
            else if (fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                return fecha.AddDays(1);
            }
            // Si la fecha cae en un día de semana, se devuelve sin cambios.
            else
            {
                return fecha;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            await MapearOrden();
            await MapearFactura();
        }

        private async Task MapearFactura()
        {
            if (await GrabarFactura(factura))
            {
                MessageBox.Show("Se registró con éxito la Factura"
                                , "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la Factura...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task<bool> GrabarFactura(Factura factura)
        {
            string facturaJson = JsonConvert.SerializeObject(factura);
            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + "/factura", facturaJson);
            return dataJson.Equals("true");
        }
    }
}
