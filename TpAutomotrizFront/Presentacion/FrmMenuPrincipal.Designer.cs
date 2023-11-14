﻿namespace TpAutomotrizFront
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
            productoToolStripMenuItem = new ToolStripMenuItem();
            clienteVendedorToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            clienteVendedorToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            totalesYPromediosDeFacturacionToolStripMenuItem1 = new ToolStripMenuItem();
            automobilesMásVendidosToolStripMenuItem1 = new ToolStripMenuItem();
            automóvilesQueNuncaSeVendieronToolStripMenuItem1 = new ToolStripMenuItem();
            porcentajeDeComprasPorTipoDeClienteToolStripMenuItem1 = new ToolStripMenuItem();
            vehículosEntregadosToolStripMenuItem1 = new ToolStripMenuItem();
            stockProducidoDeAutopartesToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informaciónToolStripMenuItem = new ToolStripMenuItem();
            lblAcceder = new Label();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            btnIngresar = new Button();
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
            mStpPrincipal.Padding = new Padding(6, 1, 0, 1);
            mStpPrincipal.Size = new Size(1079, 27);
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
            salirToolStripMenuItem.Size = new Size(125, 26);
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
            nuevaFacturaToolStripMenuItem.Size = new Size(144, 26);
            nuevaFacturaToolStripMenuItem.Text = "Factura";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(161, 26);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += nuevaToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(161, 26);
            consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(161, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoClienteVendedorToolStripMenuItem, consultarToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(79, 25);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // nuevoClienteVendedorToolStripMenuItem
            // 
            nuevoClienteVendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem, clienteVendedorToolStripMenuItem1 });
            nuevoClienteVendedorToolStripMenuItem.Name = "nuevoClienteVendedorToolStripMenuItem";
            nuevoClienteVendedorToolStripMenuItem.Size = new Size(224, 26);
            nuevoClienteVendedorToolStripMenuItem.Text = "Nuevo";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(224, 26);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // clienteVendedorToolStripMenuItem1
            // 
            clienteVendedorToolStripMenuItem1.Name = "clienteVendedorToolStripMenuItem1";
            clienteVendedorToolStripMenuItem1.Size = new Size(224, 26);
            clienteVendedorToolStripMenuItem1.Text = "Cliente/Vendedor";
            clienteVendedorToolStripMenuItem1.Click += clienteVendedorToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteVendedorToolStripMenuItem, productoToolStripMenuItem1 });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(224, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clienteVendedorToolStripMenuItem
            // 
            clienteVendedorToolStripMenuItem.Name = "clienteVendedorToolStripMenuItem";
            clienteVendedorToolStripMenuItem.Size = new Size(224, 26);
            clienteVendedorToolStripMenuItem.Text = "Cliente/Vendedor";
            clienteVendedorToolStripMenuItem.Click += clienteVendedorToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem1
            // 
            productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            productoToolStripMenuItem1.Size = new Size(224, 26);
            productoToolStripMenuItem1.Text = "Producto";
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
            // lblAcceder
            // 
            lblAcceder.AutoSize = true;
            lblAcceder.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcceder.Location = new Point(490, 225);
            lblAcceder.Name = "lblAcceder";
            lblAcceder.Size = new Size(105, 35);
            lblAcceder.TabIndex = 9;
            lblAcceder.Text = "Acceder";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(395, 297);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(28, 21);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "ID:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(332, 358);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(92, 21);
            lblContrasenia.TabIndex = 6;
            lblContrasenia.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(490, 421);
            btnIngresar.Margin = new Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 32);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(428, 293);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(228, 29);
            txtUsuario.TabIndex = 11;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(428, 354);
            txtContrasenia.Margin = new Padding(4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(228, 29);
            txtContrasenia.TabIndex = 12;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 671);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblAcceder);
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
        private ToolStripMenuItem salirToolStripMenuItem;
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
        private Label lblAcceder;
        private Label lblUsuario;
        private Label lblContrasenia;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem clienteVendedorToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem1;
    }
}