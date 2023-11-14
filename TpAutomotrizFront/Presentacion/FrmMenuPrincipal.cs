using System.Text;
using System.Security.Cryptography;
using TpAutomotrizFront.Presentacion;
using TpAutomotrizFront.Servicios;
using TpAutomotrizBack.Entidades;
using Newtonsoft.Json;
using System.Security.Policy;
using TpAutomotrizFront.Servicios.Client;
using System;
using System.Windows.Forms;

namespace TpAutomotrizFront
{
    public partial class FrmMenuPrincipal : Form
    {
        string url = TpAutomotrizAPI.Properties.Resources.UrlAndres;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            EnableMenu(false);
        }
        private void EnableMenu(bool estado) //Habilita ó deshabilita el menu principal, según si se logeo con exito o no
        {
            mStpPrincipal.Enabled = estado;
            mStpPrincipal.Visible = estado;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaFactura frmNuevaFactura = new FrmNuevaFactura();
            frmNuevaFactura.ShowDialog();
        }

        private void clienteVendedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNuevaPersona frmNuevaPersona = new FrmNuevaPersona();
            frmNuevaPersona.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(txtUsuario.Text, out _))
            {
                MessageBox.Show("El ID debe ser un numero!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(txtUsuario.Text);
            string contrasenia = txtContrasenia.Text;

            bool validado = await ValidarUsuario(id, contrasenia);

            if (validado)
            {
                EnableMenu(true);
                txtContrasenia.Visible = false;
                txtUsuario.Visible = false;
                lblAcceder.Visible = false;
                btnIngresar.Visible = false;
                lblUsuario.Visible = false;
                lblContrasenia.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos incorrectos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<bool> ValidarUsuario(int id, string contrasenia)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url + "/vendedor/" + id);
            Vendedor v = JsonConvert.DeserializeObject<Vendedor>(dataJson);

            string contraseniaHash = HashPassword(contrasenia);

            bool validacionExitosa = contraseniaHash == v.Contrasenia;

            return validacionExitosa;
        }


        static string HashPassword(string password)
        {
            string FixedSalt = "saltFijaParaTodasLasContraseñas";
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

        private void clienteVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPersona frmConsultarPersona = new FrmConsultarPersona();
            frmConsultarPersona.ShowDialog();
        }
    }
}