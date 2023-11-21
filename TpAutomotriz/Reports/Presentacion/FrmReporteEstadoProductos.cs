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

namespace Reports.Presentacion
{
    public partial class FrmReporteEstadoProductos : Form
    {
        public FrmReporteEstadoProductos()
        {
            InitializeComponent();
        }

        private void FrmEstadoProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool a = false;
            while (true)
            {
                if (!ValidarNumeros(txtMes)) break;
                if (!ValidarNumeros(txtAnio)) break;
                a = true;
                break;
            }

            if (a)
            {
                List<Parametro> lst = new List<Parametro>
                {
                    new Parametro("@año",txtAnio.Text),
                    new Parametro("@mes", txtMes.Text)
                };

                DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_ESTADO_PRODUCTOS", lst);
                this.dTEstadoProductosBindingSource.DataSource = dt;
                this.rpvEstadoProductos.RefreshReport();
            }
        }

        public bool ValidarNumeros(TextBox textBox)
        {
            string texto = textBox.Text;

            bool esNumero = int.TryParse(texto, out _);

            if (!esNumero)
            {
                MessageBox.Show("Error: El texto ingresado no es un número.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox.Focus();
            }

            return esNumero;
        }


    }
}
