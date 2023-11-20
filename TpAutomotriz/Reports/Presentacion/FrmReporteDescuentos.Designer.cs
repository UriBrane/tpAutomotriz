namespace Reports
{
    partial class FrmReporteDescuentos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvDescuentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSDescuentos = new Reports.DataSets.DSDescuentos();
            this.dTDescuentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDescuentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvDescuentos
            // 
            this.rpvDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsDescuentos";
            reportDataSource2.Value = this.dTDescuentosBindingSource;
            this.rpvDescuentos.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvDescuentos.LocalReport.ReportEmbeddedResource = "Reports.Reportes.RptDescuentos.rdlc";
            this.rpvDescuentos.Location = new System.Drawing.Point(0, 0);
            this.rpvDescuentos.Name = "rpvDescuentos";
            this.rpvDescuentos.ServerReport.BearerToken = null;
            this.rpvDescuentos.Size = new System.Drawing.Size(1538, 953);
            this.rpvDescuentos.TabIndex = 0;
            // 
            // dSDescuentos
            // 
            this.dSDescuentos.DataSetName = "DSDescuentos";
            this.dSDescuentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTDescuentosBindingSource
            // 
            this.dTDescuentosBindingSource.DataMember = "DTDescuentos";
            this.dTDescuentosBindingSource.DataSource = this.dSDescuentos;
            // 
            // FrmReporteDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 953);
            this.Controls.Add(this.rpvDescuentos);
            this.Name = "FrmReporteDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuentos Promedio";
            this.Load += new System.EventHandler(this.FrmReporteDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDescuentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDescuentos;
        private System.Windows.Forms.BindingSource dTDescuentosBindingSource;
        private DataSets.DSDescuentos dSDescuentos;
    }
}

