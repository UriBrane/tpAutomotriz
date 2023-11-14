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

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaOrden : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        public FrmNuevaOrden()
        {
            InitializeComponent();
            val = Validador.GetInstance();
        }
        private async void FrmNuevaOrden_LoadAsync(object sender, EventArgs e)
        {
            await CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            await CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
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
            // VALI
        }
    }
}
