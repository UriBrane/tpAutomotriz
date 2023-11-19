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
        private OrdenPedido? orden;
        private CargarCombo? cargarCbo;
        private int idOrdenPed;
        bool nueva;

        public FrmNuevaOrden() // Constructor default
        {
            InitializeComponent();
            nueva = true;
            orden = new OrdenPedido();
        }

        public FrmNuevaOrden(int id) // Constructor para ver una orden
        {
            InitializeComponent();
            nueva = false;
            idOrdenPed = id;
        }

        private async void FrmNuevaOrden_LoadAsync(object sender, EventArgs e)
        {
            val = Validador.GetInstance();
            cargarCbo = CargarCombo.GetInstance();
            await cargarCbo.CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await cargarCbo.CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            await cargarCbo.CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
            if (!nueva)
                CargarControles(idOrdenPed);
            else
                CargarNroOrden();
        }

        private async void CargarControles(int id)
        {
            orden = await TraerOrden("/ordenpedido/" + id);


            lblNOrden.Text = lblNOrden.Text + " " + orden.IdOrdenPedido.ToString();
            cboCliente.SelectedValue = orden.Cliente.IdCliente;
            dtpFecha.Value = orden.FechaPedido;
            cboProducto.Visible = false;
            nudCantidad.Visible = false;
            btnAgregar.Visible = false;
            dgvDetallesPed.Columns["ColEliminar"].Visible = false;
            CargarDgvDetalles();
            HabilitarControles(false);
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

        private void CargarDgvDetalles()
        {
            dgvDetallesPed.Rows.Clear();
            foreach (DetallePedido dp in orden.DetallesPedido)
            {
                dgvDetallesPed.Rows.Add(dp.Producto.IdProducto, dp.Producto.Descripcion, dp.Cantidad
                , dp.Producto.Cantidad, dp.Producto.CantidadMin, "Eliminar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // VALIDACION
            if (ValidarProducto())
            {
                foreach (DataGridViewRow r in dgvDetallesPed.Rows)
                {
                    if (r.Cells["ColDescripcion"].Value.ToString().Equals(cboProducto.Text))
                    {
                        MessageBox.Show("Este Producto ya está en la lista...", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                // AGREGAR
                Producto p = (Producto)cboProducto.SelectedItem;
                int cant = Convert.ToInt32(nudCantidad.Value);

                DetallePedido dp = new DetallePedido(p, idOrdenPed, cant);
                orden.DetallesPedido.Add(dp);

                CargarDgvDetalles();

            }
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

        private bool ValidarProducto()
        {
            bool v = false;
            while (true)
            {
                if (!val.ValidarCombo(cboProducto)) break;
                if (!val.ValidarInt(nudCantidad.Value.ToString(), nudCantidad)) break;
                v = true;
                break;
            }
            return v;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetallesPed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesPed.CurrentCell.ColumnIndex == 5)
            {
                int id = (int)dgvDetallesPed.CurrentRow.Cells["ColID"].Value;
                var item = orden.DetallesPedido.FirstOrDefault(x => x.Producto.IdProducto == id);
                if (item != null)
                {
                    orden.DetallesPedido.Remove(item);
                    CargarDgvDetalles();
                }

            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDACION
            if (orden.DetallesPedido.Count <= 0)
            {
                MessageBox.Show("Debe agregar al menos un Producto a la Orden...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            await MapearOrden();
        }

        private async Task MapearOrden()
        {
            orden.Cliente = (Cliente)cboCliente.SelectedItem;
            orden.FechaEntrega = AjustarDiaHabil(DateTime.Today.AddDays(90));
            orden.FechaPedido = DateTime.Today;
            orden.IdOrdenPedido = idOrdenPed;
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

    }
}
