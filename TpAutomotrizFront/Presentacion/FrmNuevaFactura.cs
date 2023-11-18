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

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaFactura : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private CargarCombo cargarCbo;
        private Validador val;
        public FrmNuevaFactura()
        {
            InitializeComponent();
            val = Validador.GetInstance();
        }

        private async void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            await cargarCbo.CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
            await cargarCbo.CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await cargarCbo.CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            cargarCbo.CargarCbo("SP_SELECT_FORMAS_PAGO", cboFormaPago);
            cargarCbo.CargarCbo("SP_SELECT_TARJETAS", cboTargeta);
            cargarCbo.CargarCbo("SP_SELECT_CUOTAS", cboCuotas);

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
