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
    public partial class FrmReporteEstadisticasVendedores : Form
    {
        public FrmReporteEstadisticasVendedores()
        {
            InitializeComponent();
        }

        private void FrmReporteEstadisticasVendedores_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            List<Parametro> lst = new List<Parametro>
            {
                new Parametro("@total_facturado",txtTotal.Text)
            };

            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_ESTADISTICAS_VENDEDORES", lst);
            this.dTEstadisticasVendedoresBindingSource.DataSource = dt;
            this.rpvEstadisticasVendedores.RefreshReport();
        }
    }
}
