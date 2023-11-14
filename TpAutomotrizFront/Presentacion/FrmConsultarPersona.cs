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
using TpAutomotrizFront.Servicios.Client;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmConsultarPersona : Form
    {
        string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        public FrmConsultarPersona()
        {
            InitializeComponent();
        }

        private void FrmConsultarPersona_Load(object sender, EventArgs e)
        {
            CargarCboTipo();
        }

        private void CargarDgv()
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
                dgvPersonas.Rows.Add(v.IdVendedor, v.NombreCompleto, v.Cuit, "Editar","v");
            }
        }

        private async void CargarDgvClientes()
        {
            List<Cliente> lst = await TraerLista<Cliente>("/cliente");
            foreach (Cliente c in lst)
            {
                dgvPersonas.Rows.Add(c.IdCliente, c.NombreCompleto, c.Cuit, "Editar","c");
            }
        }

        private void CargarCboTipo()
        {
            string[] tipo = { "Cliente", "Vendedor" };
            cboTipoPersona.DataSource = tipo;
        }

        private void cboTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Clear();
            CargarDgv();
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonas.CurrentCell.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(dgvPersonas.CurrentRow.Cells["ColId"].Value);
                string tipo = Convert.ToString(dgvPersonas.CurrentRow.Cells["ColTipo"].Value);
                FrmNuevaPersona frm = new FrmNuevaPersona(id, tipo);
                frm.ShowDialog();
            }
        }
    }
}
