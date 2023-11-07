namespace TpAutomotrizFront.Presentacion
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
            cboVendedor.Location = new Point(86, 87);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(177, 23);
            cboVendedor.TabIndex = 4;
            
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(86, 119);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(177, 23);
            cboCliente.TabIndex = 5;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(36, 183);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(286, 23);
            cboProducto.TabIndex = 1;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(327, 183);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(74, 23);
            nudCantidad.TabIndex = 2;
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { clmDescripcion, clmCantidad, clmSubtotal, clmDescuento, clmEliminar });
            dgvDetallesFac.Location = new Point(36, 224);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(547, 298);
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
            clmCantidad.Width = 80;
            // 
            // clmSubtotal
            // 
            clmSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmSubtotal.HeaderText = "SubTotal";
            clmSubtotal.MinimumWidth = 6;
            clmSubtotal.Name = "clmSubtotal";
            clmSubtotal.ReadOnly = true;
            clmSubtotal.Width = 77;
            // 
            // clmDescuento
            // 
            clmDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmDescuento.HeaderText = "Descuento";
            clmDescuento.MinimumWidth = 6;
            clmDescuento.Name = "clmDescuento";
            clmDescuento.ReadOnly = true;
            clmDescuento.Width = 88;
            // 
            // clmEliminar
            // 
            clmEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmEliminar.HeaderText = "Eliminar";
            clmEliminar.MinimumWidth = 6;
            clmEliminar.Name = "clmEliminar";
            clmEliminar.ReadOnly = true;
            clmEliminar.Width = 56;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(670, 523);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(770, 523);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(36, 154);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(156, 23);
            dtpFecha.TabIndex = 0;
            // 
            // lblNFactura
            // 
            lblNFactura.AutoSize = true;
            lblNFactura.Location = new Point(233, 21);
            lblNFactura.Name = "lblNFactura";
            lblNFactura.Size = new Size(85, 15);
            lblNFactura.TabIndex = 10;
            lblNFactura.Text = "FACTURA NRO";
            // 
            // lblDetalleCliente
            // 
            lblDetalleCliente.AutoSize = true;
            lblDetalleCliente.BackColor = Color.Transparent;
            lblDetalleCliente.BorderStyle = BorderStyle.Fixed3D;
            lblDetalleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalleCliente.Location = new Point(306, 76);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(100, 86);
            lblDetalleCliente.TabIndex = 11;
            lblDetalleCliente.Text = "CUIT:\r\nDOMICILIO:\r\nTELEFONO:\r\nMAIL:\r\n";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(36, 525);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(407, 181);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(58, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(18, 89);
            lblVendedor.Margin = new Padding(2, 0, 2, 0);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 14;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(33, 121);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 15;
            lblCliente.Text = "Cliente:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(599, 174);
            lblFormaPago.Margin = new Padding(2, 0, 2, 0);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(90, 15);
            lblFormaPago.TabIndex = 16;
            lblFormaPago.Text = "Forma de Pago:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(695, 172);
            cboFormaPago.Margin = new Padding(2);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(165, 23);
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
            gbxAutoplan.Location = new Point(599, 239);
            gbxAutoplan.Margin = new Padding(2);
            gbxAutoplan.Name = "gbxAutoplan";
            gbxAutoplan.Padding = new Padding(2);
            gbxAutoplan.Size = new Size(260, 154);
            gbxAutoplan.TabIndex = 20;
            gbxAutoplan.TabStop = false;
            gbxAutoplan.Text = "Datos del AutoPlan";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(57, 64);
            cboCuotas.Margin = new Padding(2);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(118, 23);
            cboCuotas.TabIndex = 23;
            // 
            // cboTargeta
            // 
            cboTargeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTargeta.FormattingEnabled = true;
            cboTargeta.Location = new Point(57, 26);
            cboTargeta.Margin = new Padding(2);
            cboTargeta.Name = "cboTargeta";
            cboTargeta.Size = new Size(118, 23);
            cboTargeta.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 25;
            label1.Text = "Tarjeta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 102);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 23);
            textBox1.TabIndex = 22;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(5, 105);
            lblInteres.Margin = new Padding(2, 0, 2, 0);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(45, 15);
            lblInteres.TabIndex = 24;
            lblInteres.Text = "Interes:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(5, 67);
            lblCuotas.Margin = new Padding(2, 0, 2, 0);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(47, 15);
            lblCuotas.TabIndex = 23;
            lblCuotas.Text = "Cuotas:";
            // 
            // cbxAutoplan
            // 
            cbxAutoplan.AutoSize = true;
            cbxAutoplan.Location = new Point(599, 217);
            cbxAutoplan.Margin = new Padding(2);
            cbxAutoplan.Name = "cbxAutoplan";
            cbxAutoplan.Size = new Size(75, 19);
            cbxAutoplan.TabIndex = 21;
            cbxAutoplan.Text = "AutoPlan";
            cbxAutoplan.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 535);
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
            Margin = new Padding(2);
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