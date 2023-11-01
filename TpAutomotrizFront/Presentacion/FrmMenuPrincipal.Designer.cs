namespace TpAutomotrizFront
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mStpPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            clienteVendedorToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            totalesYPromediosDeFacturacionToolStripMenuItem = new ToolStripMenuItem();
            automobilesMásVendidosToolStripMenuItem = new ToolStripMenuItem();
            automóvilesQueNuncaSeVendieronToolStripMenuItem = new ToolStripMenuItem();
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem = new ToolStripMenuItem();
            vehículosEntregadosToolStripMenuItem = new ToolStripMenuItem();
            stockProducidoDeAutopartesToolStripMenuItem = new ToolStripMenuItem();
            lblContrasenia = new Label();
            lblUsuario = new Label();
            lblIngresar = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            mStpPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mStpPrincipal
            // 
            mStpPrincipal.ImageScalingSize = new Size(20, 20);
            mStpPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verToolStripMenuItem });
            mStpPrincipal.Location = new Point(0, 0);
            mStpPrincipal.Name = "mStpPrincipal";
            mStpPrincipal.Size = new Size(1079, 29);
            mStpPrincipal.TabIndex = 0;
            mStpPrincipal.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(77, 25);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem, clienteVendedorToolStripMenuItem });
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(140, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(215, 26);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // clienteVendedorToolStripMenuItem
            // 
            clienteVendedorToolStripMenuItem.Name = "clienteVendedorToolStripMenuItem";
            clienteVendedorToolStripMenuItem.Size = new Size(215, 26);
            clienteVendedorToolStripMenuItem.Text = "Cliente/Vendedor";
            clienteVendedorToolStripMenuItem.Click += clienteVendedorToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(140, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, reportesToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(47, 25);
            verToolStripMenuItem.Text = "Ver";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem1 });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(161, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // facturaToolStripMenuItem1
            // 
            facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            facturaToolStripMenuItem1.Size = new Size(144, 26);
            facturaToolStripMenuItem1.Text = "Factura";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { totalesYPromediosDeFacturacionToolStripMenuItem, automobilesMásVendidosToolStripMenuItem, automóvilesQueNuncaSeVendieronToolStripMenuItem, porcentajeDeComprasPorTipoDeClienteToolStripMenuItem, vehículosEntregadosToolStripMenuItem, stockProducidoDeAutopartesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(161, 26);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // totalesYPromediosDeFacturacionToolStripMenuItem
            // 
            totalesYPromediosDeFacturacionToolStripMenuItem.Name = "totalesYPromediosDeFacturacionToolStripMenuItem";
            totalesYPromediosDeFacturacionToolStripMenuItem.Size = new Size(380, 26);
            totalesYPromediosDeFacturacionToolStripMenuItem.Text = "Totales y Promedios de Facturacion";
            // 
            // automobilesMásVendidosToolStripMenuItem
            // 
            automobilesMásVendidosToolStripMenuItem.Name = "automobilesMásVendidosToolStripMenuItem";
            automobilesMásVendidosToolStripMenuItem.Size = new Size(380, 26);
            automobilesMásVendidosToolStripMenuItem.Text = "Automobiles más vendidos";
            // 
            // automóvilesQueNuncaSeVendieronToolStripMenuItem
            // 
            automóvilesQueNuncaSeVendieronToolStripMenuItem.Name = "automóvilesQueNuncaSeVendieronToolStripMenuItem";
            automóvilesQueNuncaSeVendieronToolStripMenuItem.Size = new Size(380, 26);
            automóvilesQueNuncaSeVendieronToolStripMenuItem.Text = "Automóviles que nunca se vendieron";
            // 
            // porcentajeDeComprasPorTipoDeClienteToolStripMenuItem
            // 
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem.Name = "porcentajeDeComprasPorTipoDeClienteToolStripMenuItem";
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem.Size = new Size(380, 26);
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem.Text = "Porcentaje de compras por tipo de cliente";
            // 
            // vehículosEntregadosToolStripMenuItem
            // 
            vehículosEntregadosToolStripMenuItem.Name = "vehículosEntregadosToolStripMenuItem";
            vehículosEntregadosToolStripMenuItem.Size = new Size(380, 26);
            vehículosEntregadosToolStripMenuItem.Text = "Vehículos entregados";
            // 
            // stockProducidoDeAutopartesToolStripMenuItem
            // 
            stockProducidoDeAutopartesToolStripMenuItem.Name = "stockProducidoDeAutopartesToolStripMenuItem";
            stockProducidoDeAutopartesToolStripMenuItem.Size = new Size(380, 26);
            stockProducidoDeAutopartesToolStripMenuItem.Text = "Stock producido de autopartes";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(344, 310);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(92, 21);
            lblContrasenia.TabIndex = 1;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(369, 239);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Location = new Point(526, 149);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(67, 21);
            lblIngresar.TabIndex = 3;
            lblIngresar.Text = "Ingresar";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(442, 236);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(263, 29);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(442, 307);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(263, 29);
            txtContrasenia.TabIndex = 5;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 671);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblIngresar);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasenia);
            Controls.Add(mStpPrincipal);
            MainMenuStrip = mStpPrincipal;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += FrmMenuPrincipal_Load;
            mStpPrincipal.ResumeLayout(false);
            mStpPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mStpPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem clienteVendedorToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem totalesYPromediosDeFacturacionToolStripMenuItem;
        private ToolStripMenuItem automobilesMásVendidosToolStripMenuItem;
        private ToolStripMenuItem porcentajeDeComprasPorTipoDeClienteToolStripMenuItem;
        private ToolStripMenuItem vehículosEntregadosToolStripMenuItem;
        private ToolStripMenuItem automóvilesQueNuncaSeVendieronToolStripMenuItem;
        private ToolStripMenuItem stockProducidoDeAutopartesToolStripMenuItem;
        private Label lblContrasenia;
        private Label lblUsuario;
        private Label lblIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
    }
}