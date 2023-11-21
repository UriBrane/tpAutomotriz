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
            components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            dTEstadisticasVendedoresBindingSource = new System.Windows.Forms.BindingSource(components);
            dSReportes = new DataSets.DSReportes();
            rpvEstadisticasVendedores = new Microsoft.Reporting.WinForms.ReportViewer();
            txtTotal = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dTEstadisticasVendedoresBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSReportes).BeginInit();
            SuspendLayout();
            // 
            // dTEstadisticasVendedoresBindingSource
            // 
            dTEstadisticasVendedoresBindingSource.DataMember = "DTEstadisticasVendedores";
            dTEstadisticasVendedoresBindingSource.DataSource = dSReportes;
            // 
            // dSReportes
            // 
            dSReportes.DataSetName = "DSReportes";
            dSReportes.Namespace = "http://tempuri.org/DSReportes.xsd";
            dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvEstadisticasVendedores
            // 
            reportDataSource1.Name = "dsEstVendedores";
            reportDataSource1.Value = dTEstadisticasVendedoresBindingSource;
            rpvEstadisticasVendedores.LocalReport.DataSources.Add(reportDataSource1);
            rpvEstadisticasVendedores.LocalReport.ReportEmbeddedResource = "Reports.Reportes.RptEstVendedores.rdlc";
            rpvEstadisticasVendedores.Location = new System.Drawing.Point(14, 94);
            rpvEstadisticasVendedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rpvEstadisticasVendedores.Name = "rpvEstadisticasVendedores";
            rpvEstadisticasVendedores.ServerReport.BearerToken = null;
            rpvEstadisticasVendedores.Size = new System.Drawing.Size(1703, 1140);
            rpvEstadisticasVendedores.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(137, 40);
            txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(200, 29);
            txtTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(12, 44);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(117, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total Facturado:";
            // 
            // btnCargar
            // 
            btnCargar.Location = new System.Drawing.Point(374, 37);
            btnCargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new System.Drawing.Size(84, 35);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FrmReporteEstadisticasVendedores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1730, 1251);
            Controls.Add(btnCargar);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(rpvEstadisticasVendedores);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmReporteEstadisticasVendedores";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmReporteEstadisticasVendedores";
            Load += FrmReporteEstadisticasVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)dTEstadisticasVendedoresBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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