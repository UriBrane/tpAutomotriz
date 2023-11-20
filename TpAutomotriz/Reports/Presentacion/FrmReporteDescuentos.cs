using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class FrmReporteDescuentos : Form
    {
        public FrmReporteDescuentos()
        {
            InitializeComponent();
        }

        private void FrmReporteDescuentos_Load(object sender, EventArgs e)
        {
            DataTable dt = HelperDAO.GetInstance().ConsultarSp("SP_CONSULTA_DESCUENTOS_PROMEDIO");

            this.dTDescuentosBindingSource.DataSource = dt;

            this.rpvDescuentos.RefreshReport();
        }
    }
}
