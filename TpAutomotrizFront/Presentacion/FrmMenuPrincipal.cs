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
            this.Close();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaFactura frmNuevaFactura = new FrmNuevaFactura();
            frmNuevaFactura.ShowDialog();
        }

        private void clienteVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaPersona frmNuevaPersona = new FrmNuevaPersona();
            frmNuevaPersona.ShowDialog();
        }
    }
}