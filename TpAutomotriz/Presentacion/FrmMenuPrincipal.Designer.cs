namespace TpAutomotriz
{
    partial class FrmMenuPrincipal
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
            this.mStpPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobilesMásVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automóvilesQueNuncaSeVendieronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentajeDeComprasPorTipoDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosEntregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockProducidoDeAutopartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStpPrincipal
            // 
            this.mStpPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.mStpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mStpPrincipal.Name = "mStpPrincipal";
            this.mStpPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mStpPrincipal.Size = new System.Drawing.Size(796, 24);
            this.mStpPrincipal.TabIndex = 0;
            this.mStpPrincipal.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.vendedorToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // facturaToolStripMenuItem1
            // 
            this.facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            this.facturaToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.facturaToolStripMenuItem1.Text = "Factura";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockProductosToolStripMenuItem,
            this.automobilesMásVendidosToolStripMenuItem,
            this.automóvilesQueNuncaSeVendieronToolStripMenuItem,
            this.porcentajeDeComprasPorTipoDeClienteToolStripMenuItem,
            this.vehículosEntregadosToolStripMenuItem,
            this.stockProducidoDeAutopartesToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // stockProductosToolStripMenuItem
            // 
            this.stockProductosToolStripMenuItem.Name = "stockProductosToolStripMenuItem";
            this.stockProductosToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.stockProductosToolStripMenuItem.Text = "Totales y Promedios de Facturacion";
            // 
            // automobilesMásVendidosToolStripMenuItem
            // 
            this.automobilesMásVendidosToolStripMenuItem.Name = "automobilesMásVendidosToolStripMenuItem";
            this.automobilesMásVendidosToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.automobilesMásVendidosToolStripMenuItem.Text = "Automobiles más vendidos";
            // 
            // automóvilesQueNuncaSeVendieronToolStripMenuItem
            // 
            this.automóvilesQueNuncaSeVendieronToolStripMenuItem.Name = "automóvilesQueNuncaSeVendieronToolStripMenuItem";
            this.automóvilesQueNuncaSeVendieronToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.automóvilesQueNuncaSeVendieronToolStripMenuItem.Text = "Automóviles que nunca se vendieron";
            // 
            // porcentajeDeComprasPorTipoDeClienteToolStripMenuItem
            // 
            this.porcentajeDeComprasPorTipoDeClienteToolStripMenuItem.Name = "porcentajeDeComprasPorTipoDeClienteToolStripMenuItem";
            this.porcentajeDeComprasPorTipoDeClienteToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.porcentajeDeComprasPorTipoDeClienteToolStripMenuItem.Text = "Porcentaje de compras por tipo de cliente";
            // 
            // vehículosEntregadosToolStripMenuItem
            // 
            this.vehículosEntregadosToolStripMenuItem.Name = "vehículosEntregadosToolStripMenuItem";
            this.vehículosEntregadosToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.vehículosEntregadosToolStripMenuItem.Text = "Vehículos entregados";
            // 
            // stockProducidoDeAutopartesToolStripMenuItem
            // 
            this.stockProducidoDeAutopartesToolStripMenuItem.Name = "stockProducidoDeAutopartesToolStripMenuItem";
            this.stockProducidoDeAutopartesToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.stockProducidoDeAutopartesToolStripMenuItem.Text = "Stock producido de autopartes";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.mStpPrincipal);
            this.MainMenuStrip = this.mStpPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.mStpPrincipal.ResumeLayout(false);
            this.mStpPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobilesMásVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem automóvilesQueNuncaSeVendieronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentajeDeComprasPorTipoDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículosEntregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockProducidoDeAutopartesToolStripMenuItem;
    }
}

