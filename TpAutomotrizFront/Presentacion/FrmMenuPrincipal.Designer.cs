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
            salirToolStripMenuItem = new ToolStripMenuItem();
            transacciónToolStripMenuItem = new ToolStripMenuItem();
            nuevaFacturaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            nuevoClienteVendedorToolStripMenuItem = new ToolStripMenuItem();
            clienteVendedorToolStripMenuItem1 = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            totalesYPromediosDeFacturacionToolStripMenuItem1 = new ToolStripMenuItem();
            automobilesMásVendidosToolStripMenuItem1 = new ToolStripMenuItem();
            automóvilesQueNuncaSeVendieronToolStripMenuItem1 = new ToolStripMenuItem();
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1 = new ToolStripMenuItem();
            vehículosEntregadosToolStripMenuItem1 = new ToolStripMenuItem();
            stockProducidoDeAutopartesToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informaciónToolStripMenuItem = new ToolStripMenuItem();
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
            mStpPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, transacciónToolStripMenuItem, soporteToolStripMenuItem, reportesToolStripMenuItem1, acercaDeToolStripMenuItem });
            mStpPrincipal.Location = new Point(0, 0);
            mStpPrincipal.Name = "mStpPrincipal";
            mStpPrincipal.Size = new Size(1079, 29);
            mStpPrincipal.TabIndex = 0;
            mStpPrincipal.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(77, 25);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // transacciónToolStripMenuItem
            // 
            transacciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaFacturaToolStripMenuItem });
            transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            transacciónToolStripMenuItem.Size = new Size(105, 25);
            transacciónToolStripMenuItem.Text = "Transacción";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            nuevaFacturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, consultarToolStripMenuItem1, modificarToolStripMenuItem });
            nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            nuevaFacturaToolStripMenuItem.Size = new Size(224, 26);
            nuevaFacturaToolStripMenuItem.Text = "Factura";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(224, 26);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += nuevaToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(224, 26);
            consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(224, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoClienteVendedorToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(79, 25);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // nuevoClienteVendedorToolStripMenuItem
            // 
            nuevoClienteVendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteVendedorToolStripMenuItem1, productoToolStripMenuItem });
            nuevoClienteVendedorToolStripMenuItem.Name = "nuevoClienteVendedorToolStripMenuItem";
            nuevoClienteVendedorToolStripMenuItem.Size = new Size(224, 26);
            nuevoClienteVendedorToolStripMenuItem.Text = "Nuevo";
            // 
            // clienteVendedorToolStripMenuItem1
            // 
            clienteVendedorToolStripMenuItem1.Name = "clienteVendedorToolStripMenuItem1";
            clienteVendedorToolStripMenuItem1.Size = new Size(224, 26);
            clienteVendedorToolStripMenuItem1.Text = "Cliente/Vendedor";
            clienteVendedorToolStripMenuItem1.Click += clienteVendedorToolStripMenuItem1_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(224, 26);
            productoToolStripMenuItem.Text = "Producto";
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { totalesYPromediosDeFacturacionToolStripMenuItem1, automobilesMásVendidosToolStripMenuItem1, automóvilesQueNuncaSeVendieronToolStripMenuItem1, porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1, vehículosEntregadosToolStripMenuItem1, stockProducidoDeAutopartesToolStripMenuItem1 });
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(86, 25);
            reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // totalesYPromediosDeFacturacionToolStripMenuItem1
            // 
            totalesYPromediosDeFacturacionToolStripMenuItem1.Name = "totalesYPromediosDeFacturacionToolStripMenuItem1";
            totalesYPromediosDeFacturacionToolStripMenuItem1.Size = new Size(380, 26);
            totalesYPromediosDeFacturacionToolStripMenuItem1.Text = "Totales y Promedios de Facturacion";
            // 
            // automobilesMásVendidosToolStripMenuItem1
            // 
            automobilesMásVendidosToolStripMenuItem1.Name = "automobilesMásVendidosToolStripMenuItem1";
            automobilesMásVendidosToolStripMenuItem1.Size = new Size(380, 26);
            automobilesMásVendidosToolStripMenuItem1.Text = "Automobiles más vendidos";
            // 
            // automóvilesQueNuncaSeVendieronToolStripMenuItem1
            // 
            automóvilesQueNuncaSeVendieronToolStripMenuItem1.Name = "automóvilesQueNuncaSeVendieronToolStripMenuItem1";
            automóvilesQueNuncaSeVendieronToolStripMenuItem1.Size = new Size(380, 26);
            automóvilesQueNuncaSeVendieronToolStripMenuItem1.Text = "Automóviles que nunca se vendieron";
            // 
            // porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1
            // 
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1.Name = "porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1";
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1.Size = new Size(380, 26);
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1.Text = "Porcentaje de compras por tipo de cliente";
            // 
            // vehículosEntregadosToolStripMenuItem1
            // 
            vehículosEntregadosToolStripMenuItem1.Name = "vehículosEntregadosToolStripMenuItem1";
            vehículosEntregadosToolStripMenuItem1.Size = new Size(380, 26);
            vehículosEntregadosToolStripMenuItem1.Text = "Vehículos entregados";
            // 
            // stockProducidoDeAutopartesToolStripMenuItem1
            // 
            stockProducidoDeAutopartesToolStripMenuItem1.Name = "stockProducidoDeAutopartesToolStripMenuItem1";
            stockProducidoDeAutopartesToolStripMenuItem1.Size = new Size(380, 26);
            stockProducidoDeAutopartesToolStripMenuItem1.Text = "Stock producido de autopartes";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaciónToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(91, 25);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informaciónToolStripMenuItem
            // 
            informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            informaciónToolStripMenuItem.Size = new Size(204, 26);
            informaciónToolStripMenuItem.Text = "Desarrolladores";
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
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            mStpPrincipal.ResumeLayout(false);
            mStpPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mStpPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lblContrasenia;
        private Label lblUsuario;
        private Label lblIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem transacciónToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripMenuItem nuevoClienteVendedorToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem clienteVendedorToolStripMenuItem1;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem totalesYPromediosDeFacturacionToolStripMenuItem1;
        private ToolStripMenuItem automobilesMásVendidosToolStripMenuItem1;
        private ToolStripMenuItem automóvilesQueNuncaSeVendieronToolStripMenuItem1;
        private ToolStripMenuItem porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1;
        private ToolStripMenuItem vehículosEntregadosToolStripMenuItem1;
        private ToolStripMenuItem stockProducidoDeAutopartesToolStripMenuItem1;
        private ToolStripMenuItem informaciónToolStripMenuItem;
    }
}