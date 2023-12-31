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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            mStpPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            transacciónToolStripMenuItem = new ToolStripMenuItem();
            nuevaFacturaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            ordenDePedidoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            nuevoClienteVendedorToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            clienteVendedorToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem1 = new ToolStripMenuItem();
            clienteVendedorToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            descuentosPromedioToolStripMenuItem = new ToolStripMenuItem();
            estadisticasDeVendedoresToolStripMenuItem = new ToolStripMenuItem();
            estadoDeProductosToolStripMenuItem = new ToolStripMenuItem();
            ventasTotalesToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
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
            mStpPrincipal.Padding = new Padding(5, 1, 0, 1);
            mStpPrincipal.Size = new Size(839, 24);
            mStpPrincipal.TabIndex = 0;
            mStpPrincipal.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 22);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // transacciónToolStripMenuItem
            // 
            transacciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaFacturaToolStripMenuItem, ordenDePedidoToolStripMenuItem });
            transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            transacciónToolStripMenuItem.Size = new Size(81, 22);
            transacciónToolStripMenuItem.Text = "Transacción";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            nuevaFacturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, consultarToolStripMenuItem1 });
            nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            nuevaFacturaToolStripMenuItem.Size = new Size(163, 22);
            nuevaFacturaToolStripMenuItem.Text = "Factura";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(125, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += nuevaToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(125, 22);
            consultarToolStripMenuItem1.Text = "Consultar";
            consultarToolStripMenuItem1.Click += consultarToolStripMenuItem1_Click;
            // 
            // ordenDePedidoToolStripMenuItem
            // 
            ordenDePedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem2 });
            ordenDePedidoToolStripMenuItem.Name = "ordenDePedidoToolStripMenuItem";
            ordenDePedidoToolStripMenuItem.Size = new Size(163, 22);
            ordenDePedidoToolStripMenuItem.Text = "Orden de Pedido";
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(125, 22);
            consultarToolStripMenuItem2.Text = "Consultar";
            consultarToolStripMenuItem2.Click += consultarToolStripMenuItem2_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoClienteVendedorToolStripMenuItem, consultarToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 22);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // nuevoClienteVendedorToolStripMenuItem
            // 
            nuevoClienteVendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem, clienteVendedorToolStripMenuItem1 });
            nuevoClienteVendedorToolStripMenuItem.Name = "nuevoClienteVendedorToolStripMenuItem";
            nuevoClienteVendedorToolStripMenuItem.Size = new Size(125, 22);
            nuevoClienteVendedorToolStripMenuItem.Text = "Nuevo";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(166, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // clienteVendedorToolStripMenuItem1
            // 
            clienteVendedorToolStripMenuItem1.Name = "clienteVendedorToolStripMenuItem1";
            clienteVendedorToolStripMenuItem1.Size = new Size(166, 22);
            clienteVendedorToolStripMenuItem1.Text = "Cliente/Vendedor";
            clienteVendedorToolStripMenuItem1.Click += clienteVendedorToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem1, clienteVendedorToolStripMenuItem });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // productoToolStripMenuItem1
            // 
            productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            productoToolStripMenuItem1.Size = new Size(166, 22);
            productoToolStripMenuItem1.Text = "Producto";
            productoToolStripMenuItem1.Click += productoToolStripMenuItem1_Click;
            // 
            // clienteVendedorToolStripMenuItem
            // 
            clienteVendedorToolStripMenuItem.Name = "clienteVendedorToolStripMenuItem";
            clienteVendedorToolStripMenuItem.Size = new Size(166, 22);
            clienteVendedorToolStripMenuItem.Text = "Cliente/Vendedor";
            clienteVendedorToolStripMenuItem.Click += clienteVendedorToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { descuentosPromedioToolStripMenuItem, estadisticasDeVendedoresToolStripMenuItem, estadoDeProductosToolStripMenuItem, ventasTotalesToolStripMenuItem });
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(65, 22);
            reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // descuentosPromedioToolStripMenuItem
            // 
            descuentosPromedioToolStripMenuItem.Name = "descuentosPromedioToolStripMenuItem";
            descuentosPromedioToolStripMenuItem.Size = new Size(214, 22);
            descuentosPromedioToolStripMenuItem.Text = "Descuentos Promedio";
            descuentosPromedioToolStripMenuItem.Click += descuentosPromedioToolStripMenuItem_Click;
            // 
            // estadisticasDeVendedoresToolStripMenuItem
            // 
            estadisticasDeVendedoresToolStripMenuItem.Name = "estadisticasDeVendedoresToolStripMenuItem";
            estadisticasDeVendedoresToolStripMenuItem.Size = new Size(214, 22);
            estadisticasDeVendedoresToolStripMenuItem.Text = "Estadisticas de Vendedores";
            estadisticasDeVendedoresToolStripMenuItem.Click += estadisticasDeVendedoresToolStripMenuItem_Click;
            // 
            // estadoDeProductosToolStripMenuItem
            // 
            estadoDeProductosToolStripMenuItem.Name = "estadoDeProductosToolStripMenuItem";
            estadoDeProductosToolStripMenuItem.Size = new Size(214, 22);
            estadoDeProductosToolStripMenuItem.Text = "Estado de Productos";
            estadoDeProductosToolStripMenuItem.Click += estadoDeProductosToolStripMenuItem_Click;
            // 
            // ventasTotalesToolStripMenuItem
            // 
            ventasTotalesToolStripMenuItem.Name = "ventasTotalesToolStripMenuItem";
            ventasTotalesToolStripMenuItem.Size = new Size(214, 22);
            ventasTotalesToolStripMenuItem.Text = "Ventas Totales";
            ventasTotalesToolStripMenuItem.Click += ventasTotalesToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // lblAcceder
            // 
            lblAcceder.AutoSize = true;
            lblAcceder.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcceder.Location = new Point(381, 161);
            lblAcceder.Margin = new Padding(2, 0, 2, 0);
            lblAcceder.Name = "lblAcceder";
            lblAcceder.Size = new Size(82, 28);
            lblAcceder.TabIndex = 9;
            lblAcceder.Text = "Acceder";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(307, 212);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(21, 15);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "ID:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(258, 256);
            lblContrasenia.Margin = new Padding(2, 0, 2, 0);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(70, 15);
            lblContrasenia.TabIndex = 6;
            lblContrasenia.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(381, 301);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(333, 209);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(178, 23);
            txtUsuario.TabIndex = 11;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(333, 253);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(178, 23);
            txtContrasenia.TabIndex = 12;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(839, 479);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblAcceder);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasenia);
            Controls.Add(mStpPrincipal);
            MainMenuStrip = mStpPrincipal;
            Margin = new Padding(2, 2, 2, 2);
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
        private ToolStripMenuItem clienteVendedorToolStripMenuItem1;
        private ToolStripMenuItem productoToolStripMenuItem;
        private Label lblAcceder;
        private Label lblUsuario;
        private Label lblContrasenia;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem clienteVendedorToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem1;
        private ToolStripMenuItem ordenDePedidoToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem2;
        private ToolStripMenuItem descuentosPromedioToolStripMenuItem;
        private ToolStripMenuItem estadisticasDeVendedoresToolStripMenuItem;
        private ToolStripMenuItem estadoDeProductosToolStripMenuItem;
        private ToolStripMenuItem ventasTotalesToolStripMenuItem;
    }
}