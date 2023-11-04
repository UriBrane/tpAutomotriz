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
using TpAutomotrizFront.Servicios.Client;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaFactura : Form
    {
        public FrmNuevaFactura()
        {
            InitializeComponent();
        }

        private async void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            await CargarComboProductosAsync();
        }

        private async Task CargarComboProductosAsync()
        {
            // URL para el pc de Andres, cambia para cada pc
            string url = "https://localhost:7106/producto";

            var dataJson = await ClientSingleton.GetInstance().GetAsync(url);

            List<Producto> lProductos = JsonConvert.DeserializeObject<List<Producto>>(dataJson);

            cboProducto.DataSource = lProductos;
            cboProducto.ValueMember = "IdProducto";
            cboProducto.DisplayMember = "Descripcion";
            cboProducto.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

    }
}
