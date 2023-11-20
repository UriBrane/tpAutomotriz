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
    public partial class FrmReporteVentasTotales : Form
    {
        public FrmReporteVentasTotales()
        {
            InitializeComponent();
        }

        private void FrmReporteVentasTotales_Load(object sender, EventArgs e)
        {
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_VENTAS_TOTALES");

            this.dTVentasTotalesBindingSource.DataSource = dt;

            this.rpvVentasTotales.RefreshReport();
        }
    }
}
