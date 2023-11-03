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

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaPersona : Form
    {
        public FrmNuevaPersona()
        {
            InitializeComponent();
        }

        private void FrmNuevaPersona_Load(object sender, EventArgs e)
        {
            CargarComboTipo();
            gbxCliente.Enabled = false;
            gbxVendedor.Enabled = false;
        }

        private void CargarComboTipo()
        {
            string[] tipo = { "Cliente", "Vendedor" };
            cboTipoPersona.DataSource = tipo;
            cboTipoPersona.SelectedIndex = -1;
        }

        private void cboTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPersona.SelectedIndex == 0) // Si es 0 se carga un cliente
            {
                gbxVendedor.Enabled = false;
                gbxCliente.Enabled = true;
            }
            if (cboTipoPersona.SelectedIndex == 1) // Si es 1 se carga un vendedor
            {
                gbxCliente.Enabled = false;
                gbxVendedor.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboTipoPersona.SelectedIndex == -1) // Si no seleccionó un tipo            
                MessageBox.Show("Debe seleccionar un Tipo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Guardar Cliente

            if (cboTipoPersona.SelectedIndex == 0)
            {
                while (true)
                {
                    if (!ValidarString(txtNombre.Text, txtNombre)) break;
                    if (!ValidarString(txtApellido.Text, txtApellido)) break;
                    if (!ValidarString(txtCuit.Text, txtCuit)) break;
                    if (!ValidarString(txtDireccion.Text, txtDireccion)) break;
                    if (!ValidarInt(txtNumero.Text, txtNumero)) break;
                    // Si todas las validaciones pasan, rompe el ciclo
                    break;
                }


            }

            // Guardar Vendedor

            if (cboTipoPersona.SelectedIndex == 1)
            {

            }
        }

        private bool ValidarString(string s, Control c)
        { //Valida si el contenido de un control es STRING, y sino lo es larga un mensaje y hace focus en el control
            bool aux = true;
            if (string.IsNullOrWhiteSpace(s))
                aux = false;
            if (s.Length > 100)
                aux = false;
            if (!aux)
            {
                MessageBox.Show("El contenido a guardar no es valido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }
        private bool ValidarInt(string s, Control c)
        { //Valida si el contenido de un control es INT, y sino lo es larga un mensaje y hace focus en el control
            bool aux = true;
            if (!int.TryParse(s, out _))
                aux = false;
            if (!aux)
            {
                MessageBox.Show("El contenido a guardar no es valido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }
    }
}
