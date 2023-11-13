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
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;
using TpAutomotrizFront.Servicios;
using TpAutomotrizFront.Servicios.Client;
using System.Security.Cryptography;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaPersona : Form
    {
        string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        public FrmNuevaPersona()
        {
            InitializeComponent();
            val = Validador.GetInstance();
        }

        private void FrmNuevaPersona_Load(object sender, EventArgs e)
        {
            CargarCboTipo();
            CargarCbo("SP_SELECT_CATEGORIAS", cboCategoria);
            CargarCbo("SP_SELECT_TIPO_CLIENTES", cboTipoCliente);
            CargarCbo("SP_SELECT_BARRIOS", cboBarrio);
            gbxCliente.Enabled = false;
            gbxVendedor.Enabled = false;
            dtpFecIngreso.MaxDate = DateTime.Today;
        }

        private void CargarCbo(string nombreSP, ComboBox combo)
        {
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla(nombreSP);

            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.SelectedIndex = -1;
        }

        private void CargarCboTipo()
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
                GuardarCliente();
            }

            // Guardar Vendedor

            if (cboTipoPersona.SelectedIndex == 1)
            {
                GuardarVendedor();
            }
        }

        private async void GuardarVendedor()
        {
            Vendedor v;
            bool validado = false;

            // VALIDACION
            while (true)
            {
                if (!val.ValidarString(txtNombre.Text, txtNombre)) break;
                if (!val.ValidarString(txtApellido.Text, txtApellido)) break;
                if (!val.ValidarString(txtCuit.Text, txtCuit)) break;
                if (!val.ValidarCombo(cboCategoria)) break;
                // Si todas las validaciones pasan, rompe el ciclo
                validado = true;
                break;
            }

            // MAPEO
            if (validado)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string cuit = txtCuit.Text;
                DateTime fecIngreso = dtpFecIngreso.Value;
                int idCat = Convert.ToInt32(cboCategoria.SelectedValue);

                string contrasenia = HashPassword(txtContra.Text);

                v = new Vendedor(nombre, apellido, cuit, fecIngreso, idCat, contrasenia);

                if (await GrabarPersona(v, "/vendedor"))
                {
                    MessageBox.Show("Se guardó con éxito el Vendedor...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("NO se pudo guardar el Vendedor...", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string HashPassword(string password)
        {
            string FixedSalt = "saltFijaParaTodasLasContraseñas"; // Sal fija
            // Hashea la contraseña con SHA-256 y la sal fija
            byte[] hashedPasswordBytes = HashPasswordWithSalt(password, Encoding.UTF8.GetBytes(FixedSalt));

            // Convierte el resultado a una cadena hexadecimal
            string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "").ToLower();

            return hashedPassword;
        }

        static byte[] HashPasswordWithSalt(string password, byte[] salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] passwordWithSalt = new byte[passwordBytes.Length + salt.Length];

                // Concatena la contraseña con la sal
                for (int i = 0; i < passwordBytes.Length; i++)
                {
                    passwordWithSalt[i] = passwordBytes[i];
                }
                for (int i = 0; i < salt.Length; i++)
                {
                    passwordWithSalt[passwordBytes.Length + i] = salt[i];
                }

                return sha256.ComputeHash(passwordWithSalt);
            }
        }

        private async void GuardarCliente()
        {
            Cliente c;
            bool validado = false;

            // VALIDACION
            while (true)
            {
                if (!val.ValidarString(txtNombre.Text, txtNombre)) break;
                if (!val.ValidarString(txtApellido.Text, txtApellido)) break;
                if (!val.ValidarString(txtCuit.Text, txtCuit)) break;
                if (!val.ValidarString(txtDireccion.Text, txtDireccion)) break;
                if (!val.ValidarInt(txtNumero.Text, txtNumero)) break;
                if (!val.ValidarCombo(cboTipoCliente)) break;
                if (!val.ValidarCombo(cboBarrio)) break;
                // Si todas las validaciones pasan, rompe el ciclo
                validado = true;
                break;
            }

            //MAPEO
            if (validado)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string cuit = txtCuit.Text;
                string direccion = txtDireccion.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                int idTipoCli = Convert.ToInt32(cboTipoCliente.SelectedValue);
                int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);

                c = new Cliente(nombre, apellido, cuit, direccion, numero, idTipoCli, idBarrio);

                if (await GrabarPersona(c, "/cliente"))
                {
                    MessageBox.Show("Se guardó con éxito el Cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("NO se pudo guardar el Cliente...", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> GrabarPersona(Persona p, string decorador)
        {// Usar el decorador del controlador de la API correspondiente

            string personaJson = JsonConvert.SerializeObject(p);
            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + decorador, personaJson);
            return dataJson.Equals("true");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // COMPLETAR...
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // COMPLETAR...
        }
    }
}
