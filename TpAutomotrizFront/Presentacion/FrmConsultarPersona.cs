using Newtonsoft.Json;
using System;
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

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmConsultarPersona : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        private CargarCombo? cargarCbo;
        public FrmConsultarPersona()
        {
            InitializeComponent();
            val = Validador.GetInstance();
        }

        private void FrmConsultarPersona_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            cargarCbo.CargarCboTipoPersona(cboTipoPersona);
            gbxFiltro.Enabled = false;
        }

        private void CargarDgv()
        {
            dgvPersonas.Rows.Clear();
            if (!cbxFiltro.Checked)
            {
                if (cboTipoPersona.SelectedIndex == 0)
                {
                    CargarDgvClientes();
                }
                if (cboTipoPersona.SelectedIndex == 1)
                {
                    CargarDgvVendedores();
                }
            }
            if (cbxFiltro.Checked)
            {
                if (cboTipoPersona.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    CargarDgvCliente(id);
                }
                if (cboTipoPersona.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    CargarDgvVendedor(id);
                }
            }
        }

        private async void CargarDgvVendedor(int id)
        {
            Vendedor v = await TraerPersona<Vendedor>("/vendedor/" + id);
            if (v != null)
                dgvPersonas.Rows.Add(v.IdVendedor, v.NombreCompleto, v.Cuit, "Ver", "v");
            else
                MessageBox.Show("EL ID no corresponde a un Vendedor.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void CargarDgvCliente(int id)
        {
            Cliente c = await TraerPersona<Cliente>("/cliente/" + id);
            if (c != null)
                dgvPersonas.Rows.Add(c.IdCliente, c.NombreCompleto, c.Cuit, "Ver", "c");
            else
                MessageBox.Show("EL ID no corresponde a un Cliente.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task<T> TraerPersona<T>(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            T t = JsonConvert.DeserializeObject<T>(dataJson);
            return t;
        }

        private async Task<List<T>> TraerLista<T>(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(dataJson);
            return lst;
        }

        private async void CargarDgvVendedores()
        {
            List<Vendedor> lst = await TraerLista<Vendedor>("/vendedor");
            foreach (Vendedor v in lst)
            {
                dgvPersonas.Rows.Add(v.IdVendedor, v.NombreCompleto, v.Cuit, "Ver", "v");
            }
        }

        private async void CargarDgvClientes()
        {
            List<Cliente> lst = await TraerLista<Cliente>("/cliente");
            foreach (Cliente c in lst)
            {
                dgvPersonas.Rows.Add(c.IdCliente, c.NombreCompleto, c.Cuit, "Ver", "c");
            }
        }

        private async void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonas.CurrentCell.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(dgvPersonas.CurrentRow.Cells["ColId"].Value);
                string tipo = Convert.ToString(dgvPersonas.CurrentRow.Cells["ColTipo"].Value);
                FrmNuevaPersona frm = new FrmNuevaPersona(id, tipo);
                frm.ShowDialog();
            }

            CargarDgv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbxFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.Checked)
            {
                gbxFiltro.Enabled = true;
            }
            if (!cbxFiltro.Checked)
            {
                gbxFiltro.Enabled = false;
                txtId.Text = string.Empty;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool v = false;
            while (true)
            {
                if (!val.ValidarCombo(cboTipoPersona)) break;
                if (cbxFiltro.Checked)
                { if (!val.ValidarInt(txtId.Text, txtId)) break; }

                v = true;
                break;
            }
            if (v)
            {
                CargarDgv();
            }
        }
    }
}
