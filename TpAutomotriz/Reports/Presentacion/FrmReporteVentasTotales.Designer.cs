namespace Reports.Presentacion
{
    partial class FrmReporteVentasTotales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvVentasTotales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTVentasTotalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReportes = new Reports.DataSets.DSReportes();
            ((System.ComponentModel.ISupportInitialize)(this.dTVentasTotalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvVentasTotales
            // 
            this.rpvVentasTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVentasTotales";
            reportDataSource1.Value = this.dTVentasTotalesBindingSource;
            this.rpvVentasTotales.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVentasTotales.LocalReport.ReportEmbeddedResource = "Reports.Reportes.RptVentasTotales.rdlc";
            this.rpvVentasTotales.Location = new System.Drawing.Point(0, 0);
            this.rpvVentasTotales.Name = "rpvVentasTotales";
            this.rpvVentasTotales.ServerReport.BearerToken = null;
            this.rpvVentasTotales.Size = new System.Drawing.Size(1538, 953);
            this.rpvVentasTotales.TabIndex = 0;
            // 
            // dTVentasTotalesBindingSource
            // 
            this.dTVentasTotalesBindingSource.DataMember = "DTVentasTotales";
            this.dTVentasTotalesBindingSource.DataSource = this.dSReportes;
            // 
            // dSReportes
            // 
            this.dSReportes.DataSetName = "DSReportes";
            this.dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReporteVentasTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 953);
            this.Controls.Add(this.rpvVentasTotales);
            this.Name = "FrmReporteVentasTotales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteVentasTotales";
            this.Load += new System.EventHandler(this.FrmReporteVentasTotales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTVentasTotalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVentasTotales;
        private System.Windows.Forms.BindingSource dTVentasTotalesBindingSource;
        private DataSets.DSReportes dSReportes;
    }
}