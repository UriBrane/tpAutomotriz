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
    public partial class FrmNuevaFactura : Form
    {
        string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        Validador val;
        public FrmNuevaFactura()
        {
            InitializeComponent();
            val = Validador.GetInstance();
        }

        private async void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            await CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
            await CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            CargarCbo("SP_SELECT_FORMAS_PAGO", cboFormaPago, "id_forma_pago", "descripcion");
            CargarCbo("SP_SELECT_TARJETAS", cboTargeta, "id_tarjeta", "descripcion");
            CargarCbo("SP_SELECT_CUOTAS", cboCuotas, "id_cuota", "cantidad");

        }
        private void CargarCbo(string nombreSP, ComboBox combo, string valueMember, string displayMember)
        {
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla(nombreSP);

            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[valueMember].ColumnName;
            combo.DisplayMember = dt.Columns[displayMember].ColumnName;
            combo.SelectedIndex = -1;
        }
        private async Task CargarComboAsync<T>(ComboBox cbo, string url, string valueMember, string displayMember)
        {
            // Metodo genérico para cargar Combos con una lista de objetos traida por la API

            var dataJson = await ClientSingleton.GetInstance().GetAsync(url);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(dataJson);
            cbo.DataSource = lst;
            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // COMPLETAR
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool validado = false;
            // VALIDACION 

            while (true)
            {
                if (!val.ValidarCombo(cboVendedor)) break;
                if(!val.ValidarCombo(cboCliente)) break;
                if(!val.ValidarCombo(cboProducto)) break;
                if(!val.ValidarInt(nudCantidad.Value.ToString(),nudCantidad)) break;
                
                validado = true;
                break;
            }

            if(validado)
            {
                Producto p = (Producto)cboProducto.SelectedItem;
                int cant = Convert.ToInt32(nudCantidad.Value);

                dgvDetallesFac.Rows.Add(new object[] {p.Descripcion, cant}); // COMPLETAR
            }

        }
    }
}
