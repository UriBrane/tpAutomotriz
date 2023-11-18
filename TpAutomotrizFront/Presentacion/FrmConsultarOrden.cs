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
        private CargarCombo cargarCbo;
        public FrmConsultarOrden()
        {
            InitializeComponent();
        }

        private async void FrmConsultarOrden_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            gbxCliente.Enabled = false;
            gbxFecPedido.Enabled = false;
            await cargarCbo.CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");

        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCliente.Checked)
            {
                gbxCliente.Enabled = true;
                gbxFecPedido.Enabled = false;
            }
            if (rbtFecPedido.Checked)
            {
                gbxCliente.Enabled = false;
                gbxFecPedido.Enabled = true;
            }
        }
    }
}
