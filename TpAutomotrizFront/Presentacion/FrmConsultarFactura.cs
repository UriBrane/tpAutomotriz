using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmConsultarFactura : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador? val;
        private CargarCombo? cargarCbo;
        public FrmConsultarFactura()
        {
            InitializeComponent();
        }

        private async void FrmConsultarFactura_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            val = Validador.GetInstance();
            await cargarCbo.CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await cargarCbo.CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
        }
    }
}