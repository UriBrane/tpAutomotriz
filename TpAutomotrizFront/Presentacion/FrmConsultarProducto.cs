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
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmConsultarProducto : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private CargarCombo cargarCbo;
        public FrmConsultarProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCbo = CargarCombo.GetInstance();
            cargarCbo.CargarCbo("SP_SELECT_TIPO_PRODUCTOS", cboTipoProducto);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            if (cboTipoProducto.SelectedIndex != -1)
            {
                int tipo = (int)cboTipoProducto.SelectedValue;
                List<Producto> lst = await TraerLista<Producto>("/productos/" + tipo);
                foreach (Producto p in lst)
                {
                    dgvProductos.Rows.Add(p.IdProducto, p.IdTipoProducto,
                                        p.Precio,
                                        p.Descripcion,
                                        p.CantidadMin,
                                        p.Cantidad,
                                        p.CantMinPorMayor,
                                        "Ver"
                                        );
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentCell.ColumnIndex == 7)
            {
                int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ColID"].Value);

                FrmNuevoProducto frm = new FrmNuevoProducto(id);
                frm.ShowDialog();
            }
        }

        private async Task<List<T>> TraerLista<T>(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(dataJson);
            return lst;
        }
    }
}
