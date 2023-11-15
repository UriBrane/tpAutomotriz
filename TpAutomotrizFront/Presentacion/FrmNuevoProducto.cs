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
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;
using TpAutomotrizFront.Servicios.Client;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevoProducto : Form
    {
        string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        public FrmNuevoProducto()
        {
            InitializeComponent();
            val = Validador.GetInstance();
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            CargarCbo("SP_SELECT_TIPO_PRODUCTOS", cboTipoProductos);
        }
        private void CargarCbo(string nombreSP, ComboBox combo)
        {
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla(nombreSP);

            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto p;

            // VALIDACION
            bool validado = false;
            while (true)
            {
                if (!val.ValidarString(txtDescripcion.Text, txtDescripcion)) break;
                if (!val.ValidarDouble(txtPrecio.Text, txtPrecio)) break;
                if (!val.ValidarCombo(cboTipoProductos)) break;
                if (!val.ValidarInt(txtCantidad.Text, txtCantidad)) break;
                if (!val.ValidarInt(txtCantMinPorMayor.Text, txtCantMinPorMayor)) break;
                if (!val.ValidarInt(txtCantMin.Text, txtCantMin)) break;
                // Si todas las validaciones pasan, rompe el ciclo
                validado = true;
                break;
            }

            // MAPEO
            if (validado)
            {
                string desc = txtDescripcion.Text;
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int cantMinPorMayor = Convert.ToInt32(txtCantMinPorMayor.Text);
                int cantMin = Convert.ToInt32(txtCantMin.Text);
                int idTipoProd = Convert.ToInt32(cboTipoProductos.SelectedValue);

                p = new Producto(desc, precio, cantidad, cantMinPorMayor, cantMin, idTipoProd);

                if (await GrabarProducto(p))
                {
                    MessageBox.Show("Se guardó con éxito el Producto...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("NO se pudo guardar el Producto...", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> GrabarProducto(Producto p)
        {
            string productoJson = JsonConvert.SerializeObject(p);

            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + "/producto", productoJson);

            return dataJson.Equals("true");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // COMPLETAR...
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // COMPLETAR...
            if da
        }
    }
}
