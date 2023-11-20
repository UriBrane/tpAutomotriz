namespace Reports.Presentacion
{
    partial class FrmReporteEstadisticasVendedores
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
            this.rpvEstadisticasVendedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dTEstadisticasVendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReportes = new Reports.DataSets.DSReportes();
            ((System.ComponentModel.ISupportInitialize)(this.dTEstadisticasVendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvEstadisticasVendedores
            // 
            reportDataSource1.Name = "dsEstVendedores";
            reportDataSource1.Value = this.dTEstadisticasVendedoresBindingSource;
            this.rpvEstadisticasVendedores.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvEstadisticasVendedores.LocalReport.ReportEmbeddedResource = "Reports.Reportes.RptEstVendedores.rdlc";
            this.rpvEstadisticasVendedores.Location = new System.Drawing.Point(12, 72);
            this.rpvEstadisticasVendedores.Name = "rpvEstadisticasVendedores";
            this.rpvEstadisticasVendedores.ServerReport.BearerToken = null;
            this.rpvEstadisticasVendedores.Size = new System.Drawing.Size(1514, 869);
            this.rpvEstadisticasVendedores.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(142, 25);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 22);
            this.txtTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(31, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total Facturado:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(353, 23);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 27);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dTEstadisticasVendedoresBindingSource
            // 
            this.dTEstadisticasVendedoresBindingSource.DataMember = "DTEstadisticasVendedores";
            this.dTEstadisticasVendedoresBindingSource.DataSource = this.dSReportes;
            // 
            // dSReportes
            // 
            this.dSReportes.DataSetName = "DSReportes";
            this.dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReporteEstadisticasVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 953);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.rpvEstadisticasVendedores);
            this.Name = "FrmReporteEstadisticasVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteEstadisticasVendedores";
            this.Load += new System.EventHandler(this.FrmReporteEstadisticasVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTEstadisticasVendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEstadisticasVendedores;
        private System.Windows.Forms.BindingSource dTEstadisticasVendedoresBindingSource;
        private DataSets.DSReportes dSReportes;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCargar;
    }
}