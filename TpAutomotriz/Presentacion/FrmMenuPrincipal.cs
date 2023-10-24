using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpAutomotriz.Presentacion;

namespace TpAutomotriz
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleFactura frmDetalleFactura= new FrmDetalleFactura();
            frmDetalleFactura.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaPersona frm = new FrmNuevaPersona();
            frm.ShowDialog();
        }
    }
}

