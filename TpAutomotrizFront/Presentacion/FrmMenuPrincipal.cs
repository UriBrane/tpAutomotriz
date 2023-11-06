using TpAutomotrizFront.Presentacion;

namespace TpAutomotrizFront
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //EnableMenu(false);
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
    }
}