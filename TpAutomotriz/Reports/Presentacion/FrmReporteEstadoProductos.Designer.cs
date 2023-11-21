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
            components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            dTEstadoProductosBindingSource = new System.Windows.Forms.BindingSource(components);
            dSReportes = new DataSets.DSReportes();
            rpvEstadoProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            txtMes = new System.Windows.Forms.TextBox();
            txtAnio = new System.Windows.Forms.TextBox();
            lblAnio = new System.Windows.Forms.Label();
            lblMes = new System.Windows.Forms.Label();
            btnCargar = new System.Windows.Forms.Button();
            lblFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dTEstadoProductosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dSReportes).BeginInit();
            SuspendLayout();
            // 
            // dTEstadoProductosBindingSource
            // 
            dTEstadoProductosBindingSource.DataMember = "DTEstadoProductos";
            dTEstadoProductosBindingSource.DataSource = dSReportes;
            // 
            // dSReportes
            // 
            dSReportes.DataSetName = "DSReportes";
            dSReportes.Namespace = "http://tempuri.org/DSReportes.xsd";
            dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvEstadoProductos
            // 
            reportDataSource2.Name = "dsEstadoProducto";
            reportDataSource2.Value = dTEstadoProductosBindingSource;
            rpvEstadoProductos.LocalReport.DataSources.Add(reportDataSource2);
            rpvEstadoProductos.LocalReport.ReportEmbeddedResource = "Reports.Reportes.RptEstadoProductos.rdlc";
            rpvEstadoProductos.Location = new System.Drawing.Point(14, 104);
            rpvEstadoProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rpvEstadoProductos.Name = "rpvEstadoProductos";
            rpvEstadoProductos.ServerReport.BearerToken = null;
            rpvEstadoProductos.Size = new System.Drawing.Size(1703, 1131);
            rpvEstadoProductos.TabIndex = 0;
            // 
            // txtMes
            // 
            txtMes.Location = new System.Drawing.Point(223, 56);
            txtMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMes.Name = "txtMes";
            txtMes.Size = new System.Drawing.Size(112, 29);
            txtMes.TabIndex = 1;
            // 
            // txtAnio
            // 
            txtAnio.Location = new System.Drawing.Point(395, 56);
            txtAnio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new System.Drawing.Size(112, 29);
            txtAnio.TabIndex = 2;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new System.Drawing.Point(350, 60);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new System.Drawing.Size(41, 21);
            lblAnio.TabIndex = 3;
            lblAnio.Text = "Año:";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new System.Drawing.Point(176, 60);
            lblMes.Name = "lblMes";
            lblMes.Size = new System.Drawing.Size(42, 21);
            lblMes.TabIndex = 4;
            lblMes.Text = "Mes:";
            // 
            // btnCargar
            // 
            btnCargar.Location = new System.Drawing.Point(552, 53);
            btnCargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new System.Drawing.Size(84, 35);
            btnCargar.TabIndex = 5;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new System.Drawing.Point(59, 19);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new System.Drawing.Size(159, 21);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtrar por Mes y Año:";
            // 
            // FrmReporteEstadoProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1730, 1251);
            Controls.Add(lblFiltro);
            Controls.Add(btnCargar);
            Controls.Add(lblMes);
            Controls.Add(lblAnio);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(rpvEstadoProductos);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmReporteEstadoProductos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Estado Productos";
            Load += FrmEstadoProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dTEstadoProductosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dSReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label lblFiltro;
    }
}