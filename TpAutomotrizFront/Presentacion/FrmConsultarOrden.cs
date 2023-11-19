using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmConsultarOrden : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador? val;
        private CargarCombo? cargarCbo;
        public FrmConsultarOrden()
        {
            InitializeComponent();
        }

        private async void FrmConsultarOrden_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            val = Validador.GetInstance();
            await cargarCbo.CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");

        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck(rbtCliente, rbtFec, gbxCliente, gbxFec);
            rbtFecPedido.Checked = rbtFecEntrega.Checked = false;
            cboCliente.SelectedIndex = -1;
        }

        private void rbtFec_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck(rbtCliente, rbtFec, gbxCliente, gbxFec);
            cboCliente.SelectedIndex = -1;
        }

        private void RadioButtonCheck(RadioButton a, RadioButton b, Control c, Control d)
        {
            if (a.Checked)
            {
                c.Enabled = true;
                d.Enabled = false;
            }
            if (rbtFec.Checked)
            {
                c.Enabled = false;
                d.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool a = false;
            while (true)
            {
                if (rbtCliente.Checked)
                { if (!val.ValidarCombo(cboCliente)) break; }
                if (rbtFec.Checked)
                {
                    if (!rbtFecEntrega.Checked && !rbtFecPedido.Checked)
                    {
                        MessageBox.Show("Debe seleccionar Fecha de Entrega o de Pedido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbxFec.Focus();
                        break;
                    }
                }
                a = true;
                break;
            }
            if (a)
            {
                CargarDgv();
            }
        }
        private async Task<List<T>> TraerLista<T>(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(dataJson);
            return lst;
        }

        private void CargarDgv()
        {
            dgvOrdenes.Rows.Clear();
            if (rbtFec.Checked)
            {
                if (rbtFecEntrega.Checked)
                    CargarDgvPorFecha(dtpFecha.Value, true);
                if (rbtFecPedido.Checked)
                    CargarDgvPorFecha(dtpFecha.Value, false);
            }
            if (rbtCliente.Checked)
            {
                Cliente c = (Cliente)cboCliente.SelectedItem;
                CargarDgvPorCliente(c);
            }
        }

        private async void CargarDgvPorCliente(Cliente c)
        {
            List<OrdenPedido> lst = await TraerLista<OrdenPedido>("/ordenpedido");
            foreach (OrdenPedido o in lst)
            {
                if (o.Cliente.IdCliente == c.IdCliente)
                {
                    dgvOrdenes.Rows.Add(o.IdOrdenPedido, o.Cliente.NombreCompleto, o.FechaEntrega.ToString("dd-MM-yyyy"), o.FechaPedido.ToString("dd-MM-yyyy"), "Ver");
                }
            }
        }

        private async void CargarDgvPorFecha(DateTime fecha, bool a)
        {
            List<OrdenPedido> lst = await TraerLista<OrdenPedido>("/ordenpedido");
            foreach (OrdenPedido o in lst)
            {
                if (!a)
                {
                    if (o.FechaPedido.Date == fecha.Date)
                        dgvOrdenes.Rows.Add(o.IdOrdenPedido, o.Cliente.NombreCompleto, o.FechaEntrega.ToString("dd-MM-yyyy"), o.FechaPedido.ToString("dd-MM-yyyy"), "Ver");
                }
                else
                {
                    if (o.FechaEntrega == fecha)
                        dgvOrdenes.Rows.Add(o.IdOrdenPedido, o.Cliente.NombreCompleto, o.FechaEntrega.ToString("dd-MM-yyyy"), o.FechaEntrega.ToString("dd-MM-yyyy"), "Ver");
                }
            }
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrdenes.CurrentCell.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(dgvOrdenes.CurrentRow.Cells["ColId"].Value);
               // FrmNuevaPersona frm = new FrmNuevaOrden(id);
                frm.ShowDialog();
            }
            CargarDgv();
        }
    }
}
