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
using Newtonsoft.Json;
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;
using TpAutomotrizFront.Servicios.Client;
using System.Runtime.Intrinsics.Arm;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaOrden : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        private List<DetallePedido> lDetallePed;
        private int idOrdenPed;
        public FrmNuevaOrden()
        {
            InitializeComponent();
            val = Validador.GetInstance();
            lDetallePed = new List<DetallePedido>();
        }
        private async void FrmNuevaOrden_LoadAsync(object sender, EventArgs e)
        {
            await CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            await CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
            int idOrdenPed = await SiguienteNroOrden("/orden_pedido/consultar_id");
            lblNOrden.Text = lblNOrden.Text + " " + idOrdenPed.ToString();
        }
        private async Task CargarComboAsync<T>(ComboBox cbo, string url, string valueMember, string displayMember)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(dataJson);
            cbo.DataSource = lst;
            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.SelectedIndex = -1;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
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
                lDetallePed.Add(dp);

                CargarDgvDetalles();

            }
        }

        private void CargarDgvDetalles()
        {
            dgvDetallesPed.Rows.Clear();
            foreach (DetallePedido dp in lDetallePed)
            {
                dgvDetallesPed.Rows.Add(dp.Producto.IdProducto, dp.Producto.Descripcion, dp.Cantidad
                , dp.Producto.Cantidad, dp.Producto.CantidadMin, "Eliminar");
            }
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
                //lDetallePed.Remove(Producto.)
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
