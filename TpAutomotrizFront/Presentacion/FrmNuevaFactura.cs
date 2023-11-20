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
        private TipoVenta tipoVenta;
        public FrmNuevaFactura()
        {
            InitializeComponent();
        }

        private async void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            val = Validador.GetInstance();
            fac = new Factura();
            await cargarCbo.CargarComboAsync<Producto>(cboProducto, url + "/producto", "IdProducto", "Descripcion");
            await cargarCbo.CargarComboAsync<Vendedor>(cboVendedor, url + "/vendedor", "IdVendedor", "NombreCompleto");
            await cargarCbo.CargarComboAsync<Cliente>(cboCliente, url + "/cliente", "IdCliente", "NombreCompleto");
            cargarCbo.CargarCbo("SP_SELECT_FORMAS_PAGO", cboFormaPago);
            cargarCbo.CargarCbo("SP_SELECT_CUOTAS", cboCuotas);
            cargarCbo.CargarCbo("SP_SELECT_DESCUENTOS", cboDescuento);
            cargarCbo.CargarCbo("SP_SELECT_TIPO_VENTA", cboTipoVenta);
            cboTipoVenta.Enabled = false;
            CargarNroFactura();

        }

        private async void CargarNroFactura()
        {
            fac.IdFactura = await SiguienteNroFactura("/factura/consultarid");
            lblNFactura.Text = lblNFactura.Text + " " + fac.IdFactura;
        }

        private async Task<int> SiguienteNroFactura(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            int id = JsonConvert.DeserializeObject<int>(dataJson);
            return id;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (fac.DetallesFactura.Count <= 0)
            {
                MessageBox.Show("Debe agregar al menos un Producto a la Factura...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbxAutoplan.Checked)
            {
                fac.AutoPlan.ID = HelperDAO.GetInstance().ConsultarEscalar("SP_GET_NEXT_AUTOPLAN", "@nro");
                fac.AutoPlan.Cliente = fac.Cliente;
                fac.AutoPlan.Interes = Convert.ToInt32(txtInteres.Text) / 100;
                fac.AutoPlan.Cuotas = (int)cboCuotas.SelectedValue;
            }
            await MapearFactura();
        }

        private async Task MapearFactura()
        {
            fac.Cliente = (Cliente)cboCliente.SelectedItem;
            fac.Fecha = dtpFecha.Value;
            fac.Vendedor = (Vendedor)cboVendedor.SelectedItem;
            fac.IdFormaPago = (int)cboFormaPago.SelectedValue;
            List<DetalleFactura> lstDetalle = new List<DetalleFactura>();
            foreach (DetalleFactura df in fac.DetallesFactura)
            {
                if (df.Producto.Cantidad < df.Cantidad)
                {
                    lstDetalle.Add(df);
                }
                if (df.Producto.IdTipoProducto == 6)
                {
                    lstDetalle.Add(df);
                }
            }
            if (lstDetalle.Count > 0)
            {
                if (MessageBox.Show("No se puede generar factura por falta de stock o por ser un automovil: \n" + mostrarSinStock(lstDetalle)
                                + "\n DESEA GENERAR UNA ORDEN DE PEDIDO?"

                                    , "Informe", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    new FrmNuevaOrden(fac, lstDetalle).ShowDialog();
                }
            }
            else
            {
                if (await GrabarFactura(fac))
                {
                    MessageBox.Show("Se registró con éxito la Factura"
                                    , "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fac = new Factura();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("NO se pudo registrar la Factura...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private string mostrarSinStock(List<DetalleFactura> lista)
        {
            string var = "";
            foreach (DetalleFactura df in lista)
            {
                var = var + "- " + df.Producto.Descripcion + "\n";
            }

            return var;
        }

        private async Task<bool> GrabarFactura(Factura factura)
        {
            string facturaJson = JsonConvert.SerializeObject(factura);
            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + "/factura", facturaJson);
            return dataJson.Equals("true");
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

                Descuento des = new Descuento();
                des.ID = (int)cboDescuento.SelectedValue;
                switch (des.ID)
                {
                    case 1:
                        des.CantDescuento = 0;
                        break;

                    case 2:
                        des.CantDescuento = 5;
                        break;

                    case 3:
                        des.CantDescuento = 10;
                        break;
                    case 4:
                        des.CantDescuento = 15;
                        break;
                    case 5:
                        des.CantDescuento = 20;
                        break;
                    case 6:
                        des.CantDescuento = 25;
                        break;
                }



                DetalleFactura df = new DetalleFactura(tipoVenta, fac.IdFactura, p, cant, p.Precio, des, "");
                fac.DetallesFactura.Add(df);

                CargarDgvDetalles();
                RevisarAutoPlan();
            }

        }

        private void RevisarAutoPlan()
        {
            bool posible = true;
            foreach (DetalleFactura df in fac.DetallesFactura)
            {
                if (df.Producto.IdTipoProducto != 6)
                {
                    posible = false;
                }
            }

            cbxAutoplan.Enabled = posible;
            cboCuotas.Enabled = posible;
            txtInteres.Enabled = posible;
            if (!posible)
            {
                cbxAutoplan.Checked = false;
                cboCuotas.SelectedIndex = -1;
                txtInteres.Text = "";
            }
        }

        private void dgvDetallesFac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesFac.CurrentCell.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dgvDetallesFac.CurrentRow.Cells["ColID"].Value);
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
            double total = 0;
            foreach (DetalleFactura df in fac.DetallesFactura)
            {

                dgvDetallesFac.Rows.Add(new object[] { df.Producto.IdProducto,
                                                        df.Producto.Descripcion,
                                                       df.Cantidad,
                                                       df.CalcularSubtotal(),
                                                       df.Descuento.CantDescuento,
                                                       df.TipoVenta.Tipo});
                total = total + df.CalcularSubtotal();
            }

            lblTotal.Text = "TOTAL: " + total;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != -1)
            {
                int cant = Convert.ToInt32(nudCantidad.Value);
                Producto p = (Producto)cboProducto.SelectedItem;
                if (p.CantMinPorMayor < cant)
                {
                    tipoVenta = new TipoVenta(1, "Venta al por mayor");
                    cboTipoVenta.SelectedValue = 1;
                }
                else { tipoVenta = new TipoVenta(2, "Venta al por menor"); ; cboTipoVenta.SelectedValue = 2; }
            }
        }

        private void cbxAutoplan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoplan.Checked)
            {
                cboFormaPago.SelectedIndex = 1;
                cboFormaPago.Enabled = false;
            }
            else
            {
                cboFormaPago.SelectedIndex = -1;
                cboFormaPago.Enabled = true;
            }
            
        }
    }
}
