﻿namespace TpAutomotrizFront.Presentacion
{
    partial class FrmNuevaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaFactura));
            cboVendedor = new ComboBox();
            cboCliente = new ComboBox();
            cboProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            dgvDetallesFac = new DataGridView();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmSubtotal = new DataGridViewTextBoxColumn();
            clmDescuento = new DataGridViewTextBoxColumn();
            clmEliminar = new DataGridViewButtonColumn();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dtpFecha = new DateTimePicker();
            lblNFactura = new Label();
            lblDetalleCliente = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            lblVendedor = new Label();
            lblCliente = new Label();
            lblFormaPago = new Label();
            cboFormaPago = new ComboBox();
            gbxAutoplan = new GroupBox();
            cboCuotas = new ComboBox();
            cboTargeta = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lblInteres = new Label();
            lblCuotas = new Label();
            cbxAutoplan = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).BeginInit();
            gbxAutoplan.SuspendLayout();
            SuspendLayout();
            // 
            // cboVendedor
            // 
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(110, 122);
            cboVendedor.Margin = new Padding(4);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(227, 29);
            cboVendedor.TabIndex = 4;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(110, 166);
            cboCliente.Margin = new Padding(4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(227, 29);
            cboCliente.TabIndex = 5;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(46, 256);
            cboProducto.Margin = new Padding(4);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(367, 29);
            cboProducto.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(421, 256);
            nudCantidad.Margin = new Padding(4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(95, 29);
            nudCantidad.TabIndex = 2;
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { clmDescripcion, clmCantidad, clmSubtotal, clmDescuento, clmEliminar });
            dgvDetallesFac.Location = new Point(46, 314);
            dgvDetallesFac.Margin = new Padding(4);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(703, 417);
            dgvDetallesFac.TabIndex = 5;
            // 
            // clmDescripcion
            // 
            clmDescripcion.HeaderText = "Descripción";
            clmDescripcion.MinimumWidth = 6;
            clmDescripcion.Name = "clmDescripcion";
            clmDescripcion.ReadOnly = true;
            clmDescripcion.Width = 200;
            // 
            // clmCantidad
            // 
            clmCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmCantidad.HeaderText = "Cantidad";
            clmCantidad.MinimumWidth = 6;
            clmCantidad.Name = "clmCantidad";
            clmCantidad.ReadOnly = true;
            clmCantidad.Width = 101;
            // 
            // clmSubtotal
            // 
            clmSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmSubtotal.HeaderText = "SubTotal";
            clmSubtotal.MinimumWidth = 6;
            clmSubtotal.Name = "clmSubtotal";
            clmSubtotal.ReadOnly = true;
            clmSubtotal.Width = 98;
            // 
            // clmDescuento
            // 
            clmDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmDescuento.HeaderText = "Descuento";
            clmDescuento.MinimumWidth = 6;
            clmDescuento.Name = "clmDescuento";
            clmDescuento.ReadOnly = true;
            clmDescuento.Width = 112;
            // 
            // clmEliminar
            // 
            clmEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmEliminar.HeaderText = "Eliminar";
            clmEliminar.MinimumWidth = 6;
            clmEliminar.Name = "clmEliminar";
            clmEliminar.ReadOnly = true;
            clmEliminar.Width = 73;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(861, 732);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 49);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(990, 732);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 49);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(46, 216);
            dtpFecha.Margin = new Padding(4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(199, 29);
            dtpFecha.TabIndex = 0;
            // 
            // lblNFactura
            // 
            lblNFactura.AutoSize = true;
            lblNFactura.Location = new Point(299, 29);
            lblNFactura.Margin = new Padding(4, 0, 4, 0);
            lblNFactura.Name = "lblNFactura";
            lblNFactura.Size = new Size(114, 21);
            lblNFactura.TabIndex = 10;
            lblNFactura.Text = "FACTURA NRO";
            // 
            // lblDetalleCliente
            // 
            lblDetalleCliente.AutoSize = true;
            lblDetalleCliente.BackColor = Color.Transparent;
            lblDetalleCliente.BorderStyle = BorderStyle.Fixed3D;
            lblDetalleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalleCliente.Location = new Point(393, 106);
            lblDetalleCliente.Margin = new Padding(4, 0, 4, 0);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(123, 114);
            lblDetalleCliente.TabIndex = 11;
            lblDetalleCliente.Text = "CUIT:\r\nDOMICILIO:\r\nTELEFONO:\r\nMAIL:\r\n";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(46, 735);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 21);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(523, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 32);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(23, 125);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(80, 21);
            lblVendedor.TabIndex = 14;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(42, 169);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 21);
            lblCliente.TabIndex = 15;
            lblCliente.Text = "Cliente:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(770, 244);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(117, 21);
            lblFormaPago.TabIndex = 16;
            lblFormaPago.Text = "Forma de Pago:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(893, 241);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(211, 29);
            cboFormaPago.TabIndex = 18;
            // 
            // gbxAutoplan
            // 
            gbxAutoplan.Controls.Add(cboCuotas);
            gbxAutoplan.Controls.Add(cboTargeta);
            gbxAutoplan.Controls.Add(label1);
            gbxAutoplan.Controls.Add(textBox1);
            gbxAutoplan.Controls.Add(lblInteres);
            gbxAutoplan.Controls.Add(lblCuotas);
            gbxAutoplan.Location = new Point(770, 335);
            gbxAutoplan.Name = "gbxAutoplan";
            gbxAutoplan.Size = new Size(334, 216);
            gbxAutoplan.TabIndex = 20;
            gbxAutoplan.TabStop = false;
            gbxAutoplan.Text = "Datos del AutoPlan";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(73, 90);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(151, 29);
            cboCuotas.TabIndex = 23;
            // 
            // cboTargeta
            // 
            cboTargeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTargeta.FormattingEnabled = true;
            cboTargeta.Location = new Point(73, 37);
            cboTargeta.Name = "cboTargeta";
            cboTargeta.Size = new Size(151, 29);
            cboTargeta.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 41);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 25;
            label1.Text = "Tarjeta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 29);
            textBox1.TabIndex = 22;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(7, 147);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(60, 21);
            lblInteres.TabIndex = 24;
            lblInteres.Text = "Interes:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(6, 94);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(61, 21);
            lblCuotas.TabIndex = 23;
            lblCuotas.Text = "Cuotas:";
            // 
            // cbxAutoplan
            // 
            cbxAutoplan.AutoSize = true;
            cbxAutoplan.Location = new Point(770, 304);
            cbxAutoplan.Name = "cbxAutoplan";
            cbxAutoplan.Size = new Size(95, 25);
            cbxAutoplan.TabIndex = 21;
            cbxAutoplan.Text = "AutoPlan";
            cbxAutoplan.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 794);
            Controls.Add(cbxAutoplan);
            Controls.Add(gbxAutoplan);
            Controls.Add(cboFormaPago);
            Controls.Add(lblFormaPago);
            Controls.Add(lblCliente);
            Controls.Add(lblVendedor);
            Controls.Add(lblTotal);
            Controls.Add(lblDetalleCliente);
            Controls.Add(lblNFactura);
            Controls.Add(dtpFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDetallesFac);
            Controls.Add(nudCantidad);
            Controls.Add(cboProducto);
            Controls.Add(cboCliente);
            Controls.Add(cboVendedor);
            DoubleBuffered = true;
            Name = "FrmNuevaFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Factura";
            Load += FrmNuevaFactura_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).EndInit();
            gbxAutoplan.ResumeLayout(false);
            gbxAutoplan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboVendedor;
        private ComboBox cboCliente;
        private ComboBox cboProducto;
        private NumericUpDown nudCantidad;
        private DataGridView dgvDetallesFac;
        private Button btnGuardar;
        private Button btnCancelar;
        private DateTimePicker dtpFecha;
        private Label lblNFactura;
        private Label lblDetalleCliente;
        private Label lblTotal;
        private DataGridViewTextBoxColumn clmDescripcion;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmSubtotal;
        private DataGridViewTextBoxColumn clmDescuento;
        private DataGridViewButtonColumn clmEliminar;
        private Button btnAgregar;
        private Label lblVendedor;
        private Label lblCliente;
        private Label lblFormaPago;
        private ComboBox cboFormaPago;
        private GroupBox gbxAutoplan;
        private Label lblInteres;
        private Label lblCuotas;
        private CheckBox cbxAutoplan;
        private TextBox textBox1;
        private ComboBox cboTargeta;
        private Label label1;
        private ComboBox cboCuotas;
    }
}