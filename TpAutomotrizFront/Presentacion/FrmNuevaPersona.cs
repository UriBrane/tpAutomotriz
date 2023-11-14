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
using System.ComponentModel.DataAnnotations;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmNuevaPersona : Form
    {
        private string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        private Validador val;
        private bool nuevo;
        private string tipoPersona;
        private int idPersona = 0;
        public FrmNuevaPersona() // Constructor default
        {
            InitializeComponent();
            val = Validador.GetInstance();
            nuevo = true;
            btnEditar.Enabled = false;
        }
        public FrmNuevaPersona(int id, string tipo) // Constructor para editar una persona
        {
            InitializeComponent();
            val = Validador.GetInstance();
            idPersona = id;
            tipoPersona = tipo;
            btnGuardar.Enabled = false;
            txtContra.Enabled = false;
            cboTipoPersona.Enabled = false;
            nuevo = false;
            CargarControles(idPersona);
        }
        private async Task<T> TraerPersona<T>(string decorador)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + decorador);
            T p = JsonConvert.DeserializeObject<T>(dataJson);
            return p;
        }

        private async void CargarControles(int id)
        {
            if (tipoPersona == "v")
            {
                Vendedor v = await TraerPersona<Vendedor>("/vendedor/" + id);

                cboTipoPersona.SelectedIndex = 1;
                txtCuit.Text = v.Cuit.ToString();
                txtNombre.Text = v.Nombre.ToString();
                txtApellido.Text = v.Apellido.ToString();
                dtpFecIngreso.Value = v.FechaIngreso;
                cboCategoria.SelectedValue = v.IdCategoria;
                txtContra.Text = "No se puede editar.";
                HabilitarControlesVendedor(false);
            }
            if (tipoPersona == "c")
            {
                Cliente c = await TraerPersona<Cliente>("/cliente/" + id);

                cboTipoPersona.SelectedIndex = 0;
                txtCuit.Text = c.Cuit.ToString();
                txtNombre.Text = c.Nombre.ToString();
                txtApellido.Text = c.Apellido.ToString();
                txtDireccion.Text = c.Calle.ToString();
                txtNumero.Text = c.CalleNro.ToString();
                cboTipoCliente.SelectedValue = c.TipoCliente;
                cboBarrio.SelectedValue = c.IdBarrio;
                HabilitarControlesCliente(false);
            }

        }
        public void HabilitarControlesCliente(bool e)
        {
            txtCuit.Enabled = e;
            txtNombre.Enabled = e;
            txtApellido.Enabled = e;
            txtDireccion.Enabled = e;
            txtNumero.Enabled = e;
            cboTipoCliente.Enabled = e;
            cboBarrio.Enabled = e;
        }

        public void HabilitarControlesVendedor(bool e)
        {
            txtCuit.Enabled = e;
            txtNombre.Enabled = e;
            txtApellido.Enabled = e;
            dtpFecIngreso.Enabled = e;
            cboCategoria.Enabled = e;
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
            if (nuevo)
            {
                if (cboTipoPersona.SelectedIndex == -1) // Si no seleccionó un tipo            
                    MessageBox.Show("Debe seleccionar un Tipo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Guardar Cliente

                if (cboTipoPersona.SelectedIndex == 0)
                {
                    GuardarClienteNuevo();
                }

                // Guardar Vendedor

                if (cboTipoPersona.SelectedIndex == 1)
                {
                    GuardarVendedorNuevo();
                }
            }
            else
            {
                if (tipoPersona == "v")
                {
                    GuardarVendedorEditado();
                }
                else
                {
                    GuardarClienteEditado();
                }
            }
        }

        private async void GuardarVendedorEditado()
        {
            Vendedor v;

            // VALIDACION
            if (ValidarVendedor())
            {
                // MAPEO
                v = MapearVendedor();

                // GRABAR
                if (await GrabarPersonaEditada(v, "/vendedor"))
                {
                    MessageBox.Show("Se guardó con éxito el Vendedor...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("NO se pudo guardar el Vendedor...", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> GrabarPersonaEditada<T>(T t, string decorador)
        {
            string personaJson = JsonConvert.SerializeObject(t);
            var dataJson = await ClientSingleton.GetInstance().PutAsync(url + decorador, personaJson);
            return dataJson.Equals("true");
        }

        private async Task<bool> GrabarPersonaNueva<T>(T t, string decorador)
        {// Usar el decorador del controlador de la API correspondiente

            string personaJson = JsonConvert.SerializeObject(t);
            var dataJson = await ClientSingleton.GetInstance().PostAsync(url + decorador, personaJson);
            return dataJson.Equals("true");
        }

        private void GuardarClienteEditado()
        {
            throw new NotImplementedException();
        }

        private async void GuardarVendedorNuevo()
        {
            Vendedor v;

            // VALIDACION                       
            if (ValidarVendedor())
            {
                // MAPEO
                v = MapearVendedor();
                v.Contrasenia = HashPassword(txtContra.Text);

                // GRABAR
                if (await GrabarPersonaNueva(v, "/vendedor"))
                {
                    MessageBox.Show("Se guardó con éxito el Vendedor...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("NO se pudo guardar el Vendedor...", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Vendedor MapearVendedor()
        {
            int id = idPersona;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            long cuit = Convert.ToInt64(txtCuit.Text);
            DateTime fecIngreso = dtpFecIngreso.Value;
            int idCat = Convert.ToInt32(cboCategoria.SelectedValue);
            Vendedor v = new Vendedor(id, nombre, apellido, cuit, fecIngreso, idCat);
            return v;
        }

        private bool ValidarVendedor()
        {
            bool validado = false;
            while (true)
            {
                if (!val.ValidarString(txtNombre.Text, txtNombre)) break;
                if (!val.ValidarString(txtApellido.Text, txtApellido)) break;
                if (!val.ValidarLong(txtCuit.Text, txtCuit)) break;
                if (!val.ValidarCombo(cboCategoria)) break;
                // Si todas las validaciones pasan, rompe el ciclo
                validado = true;
                break;
            }
            return validado;
        }

        private async void GuardarClienteNuevo()
        {
            Cliente c;
            bool validado = false;

            // VALIDACION
            while (true)
            {
                if (!val.ValidarString(txtNombre.Text, txtNombre)) break;
                if (!val.ValidarString(txtApellido.Text, txtApellido)) break;
                if (!val.ValidarLong(txtCuit.Text, txtCuit)) break;
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
                long cuit = Convert.ToInt64(txtCuit.Text);
                string direccion = txtDireccion.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                int idTipoCli = Convert.ToInt32(cboTipoCliente.SelectedValue);
                int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);

                c = new Cliente(nombre, apellido, cuit, direccion, numero, idTipoCli, idBarrio);

                if (await GrabarPersonaNueva(c, "/cliente"))
                {
                    MessageBox.Show("Se guardó con éxito el Cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("NO se pudo guardar el Cliente...", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!nuevo)
            {
                if (tipoPersona == "v")
                {
                    HabilitarControlesVendedor(true);
                    btnGuardar.Enabled = true;
                }
                else
                {
                    HabilitarControlesCliente(true);
                    btnGuardar.Enabled = true;
                }
                btnEditar.Enabled = false;
            }
        }
    }
}
