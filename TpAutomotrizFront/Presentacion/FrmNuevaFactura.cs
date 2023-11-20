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
        private Factura fac;
        public FrmNuevaFactura()
        {
            InitializeComponent();
            val = Validador.GetInstance();
            fac = new Factura();
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
            CargarNroOrden();

        }

        private async void CargarNroOrden()
        {
            fac.IdFactura = await SiguienteNroOrden("/factura/consultarid");
            lblNFactura.Text = lblNFactura.Text + " " + fac.IdFactura;
        }

        private async Task<int> SiguienteNroOrden(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            int id = JsonConvert.DeserializeObject<int>(dataJson);
            return id;
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
                if (!val.ValidarCombo(cboCliente)) break;
                if (!val.ValidarCombo(cboProducto)) break;
                if (!val.ValidarInt(nudCantidad.Value.ToString(), nudCantidad)) break;

                validado = true;
                break;
            }

            foreach (DataGridViewRow r in dgvDetallesFac.Rows)
            {
                // Verifica si la celda no es nula y si el valor no es nulo
                if (r.Cells["colDescripcion"].Value != null && r.Cells["colDescripcion"].Value.ToString() == cboProducto.Text)
                {
                    MessageBox.Show("Este Producto ya está en la lista...", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (validado)
            {
                Producto p = (Producto)cboProducto.SelectedItem;
                int cant = Convert.ToInt32(nudCantidad.Value);

                DetalleFactura df = new DetalleFactura(2, fac.IdFactura, p, cant, p.Precio, 1, "");
                fac.DetallesFactura.Add(df);

                CargarDgvDetalles();
            }

        }

        private void dgvDetallesFac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesFac.CurrentCell.ColumnIndex == 4)
            {
                int id = (int)dgvDetallesFac.CurrentRow.Cells["ColID"].Value;
                var item = fac.DetallesFactura.FirstOrDefault(x => x.Producto.IdProducto == id);
                if (item != null)
                {
                    fac.DetallesFactura.Remove(item);
                    CargarDgvDetalles();
                }

            }
        }

        private void CargarDgvDetalles()
        {
            dgvDetallesFac.Rows.Clear();
            foreach (DetalleFactura df in fac.DetallesFactura)
            {

                dgvDetallesFac.Rows.Add(new object[] { df.Producto.IdProducto,
                                                        df.Producto.Descripcion,
                                                       df.Cantidad,
                                                       df.Producto.Precio });
            }
        }
    }
}
