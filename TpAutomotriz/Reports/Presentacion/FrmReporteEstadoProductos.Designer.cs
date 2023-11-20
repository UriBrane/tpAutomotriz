namespace Reports.Presentacion
{
    partial class FrmReporteEstadoProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvEstadoProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSReportes = new Reports.DataSets.DSReportes();
            this.dTEstadoProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTEstadoProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvEstadoProductos
            // 
            reportDataSource2.Name = "dsEstadoProducto";
            reportDataSource2.Value = this.dTEstadoProductosBindingSource;
            this.rpvEstadoProductos.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvEstadoProductos.LocalReport.ReportEmbeddedResource = "Reports.Reportes.RptEstadoProductos.rdlc";
            this.rpvEstadoProductos.Location = new System.Drawing.Point(12, 79);
            this.rpvEstadoProductos.Name = "rpvEstadoProductos";
            this.rpvEstadoProductos.ServerReport.BearerToken = null;
            this.rpvEstadoProductos.Size = new System.Drawing.Size(1514, 862);
            this.rpvEstadoProductos.TabIndex = 0;
            // 
            // dSReportes
            // 
            this.dSReportes.DataSetName = "DSReportes";
            this.dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTEstadoProductosBindingSource
            // 
            this.dTEstadoProductosBindingSource.DataMember = "DTEstadoProductos";
            this.dTEstadoProductosBindingSource.DataSource = this.dSReportes;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(198, 33);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 22);
            this.txtMes.TabIndex = 1;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(351, 33);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 22);
            this.txtAnio.TabIndex = 2;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(311, 36);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(34, 16);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(156, 36);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(36, 16);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(539, 31);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 27);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmReporteEstadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 953);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.rpvEstadoProductos);
            this.Name = "FrmReporteEstadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado Productos";
            this.Load += new System.EventHandler(this.FrmEstadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTEstadoProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEstadoProductos;
        private System.Windows.Forms.BindingSource dTEstadoProductosBindingSource;
        private DataSets.DSReportes dSReportes;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnCargar;
    }
}