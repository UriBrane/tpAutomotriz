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
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;
using TpAutomotrizFront.Servicios.Client;
using System.Runtime.Intrinsics.Arm;
using System.Collections;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaOrden : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        private OrdenPedido nuevaOrden;
        private int idOrdenPed;
        public FrmNuevaOrden()
        {
            InitializeComponent();
            val = Validador.GetInstance();
            nuevaOrden = new OrdenPedido();
        }
        private async void FrmNuevaOrden_LoadAsync(object sender, EventArgs e)
        {
            await CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            await CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
            idOrdenPed = await SiguienteNroOrden("/orden_pedido/consultar_id");
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
                nuevaOrden.DetallesPedido.Add(dp);

                CargarDgvDetalles();

            }
        }

        private void CargarDgvDetalles()
        {
            dgvDetallesPed.Rows.Clear();
            foreach (DetallePedido dp in nuevaOrden.DetallesPedido)
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
                var item = nuevaOrden.DetallesPedido.FirstOrDefault(x => x.Producto.IdProducto == id);
                if (item != null)
                {
                    nuevaOrden.DetallesPedido.Remove(item);
                    CargarDgvDetalles();
                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDACION
            if (nuevaOrden.DetallesPedido.Count <= 0)
            {
                MessageBox.Show("Debe agregar al menos un Producto a la Orden...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MapearOrden();
        }

        private async void MapearOrden()
        {
            nuevaOrden.Cliente = (Cliente)cboCliente.SelectedItem;
            nuevaOrden.FechaEntrega = AjustarDiaHabil(DateTime.Today.AddDays(90));
            nuevaOrden.FechaPedido = DateTime.Today;
            nuevaOrden.IdOrdenPedido = idOrdenPed;
            if (await GrabarOrden(nuevaOrden))
            {
                MessageBox.Show("Se registró con éxito la Orden de Pedido.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevaOrden = new OrdenPedido();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la Orden de Pedido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task<bool> GrabarOrden(OrdenPedido orden)
        {
            string ordenJson = JsonConvert.SerializeObject(orden);
            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + "/orden_pedido", ordenJson);
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
