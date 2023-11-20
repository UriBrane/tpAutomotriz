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
            ColID = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colTipoVenta = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dtpFecha = new DateTimePicker();
            lblNFactura = new Label();
            lblDetalleCliente = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            lblVendedor = new Label();
            lblCliente = new Label();
            cboDescuento = new ComboBox();
            gbxAutoplan = new GroupBox();
            cboCuotas = new ComboBox();
            txtInteres = new TextBox();
            lblInteres = new Label();
            lblCuotas = new Label();
            cbxAutoplan = new CheckBox();
            label2 = new Label();
            cboFormaPago = new ComboBox();
            label3 = new Label();
            cboTipoVenta = new ComboBox();
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
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(36, 188);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(208, 23);
            cboProducto.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(250, 188);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(74, 23);
            nudCantidad.TabIndex = 2;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { ColID, colDescripcion, colCantidad, colSubtotal, colDescuento, colTipoVenta, colEliminar });
            dgvDetallesFac.Location = new Point(36, 224);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(742, 298);
            dgvDetallesFac.TabIndex = 5;
            dgvDetallesFac.CellContentClick += dgvDetallesFac_CellContentClick;
            // 
            // ColID
            // 
            ColID.FillWeight = 120F;
            ColID.HeaderText = "id";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            colDescripcion.Width = 200;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 80;
            // 
            // colSubtotal
            // 
            colSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSubtotal.HeaderText = "SubTotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.Width = 77;
            // 
            // colDescuento
            // 
            colDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDescuento.HeaderText = "Descuento";
            colDescuento.MinimumWidth = 6;
            colDescuento.Name = "colDescuento";
            colDescuento.ReadOnly = true;
            colDescuento.Width = 88;
            // 
            // colTipoVenta
            // 
            colTipoVenta.FillWeight = 150F;
            colTipoVenta.HeaderText = "Tipo de Venta";
            colTipoVenta.Name = "colTipoVenta";
            colTipoVenta.ReadOnly = true;
            colTipoVenta.Width = 150;
            // 
            // colEliminar
            // 
            colEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colEliminar.HeaderText = "Eliminar";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Width = 56;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(832, 542);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(947, 542);
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
            btnAgregar.Location = new Point(693, 188);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(74, 23);
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
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(410, 188);
            cboDescuento.Margin = new Padding(2);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(124, 23);
            cboDescuento.TabIndex = 18;
            // 
            // gbxAutoplan
            // 
            gbxAutoplan.Controls.Add(cboCuotas);
            gbxAutoplan.Controls.Add(txtInteres);
            gbxAutoplan.Controls.Add(lblInteres);
            gbxAutoplan.Controls.Add(lblCuotas);
            gbxAutoplan.Location = new Point(814, 289);
            gbxAutoplan.Margin = new Padding(2);
            gbxAutoplan.Name = "gbxAutoplan";
            gbxAutoplan.Padding = new Padding(2);
            gbxAutoplan.Size = new Size(260, 113);
            gbxAutoplan.TabIndex = 20;
            gbxAutoplan.TabStop = false;
            gbxAutoplan.Text = "Datos del AutoPlan";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(66, 32);
            cboCuotas.Margin = new Padding(2);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(118, 23);
            cboCuotas.TabIndex = 23;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(66, 70);
            txtInteres.Margin = new Padding(2);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(98, 23);
            txtInteres.TabIndex = 22;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(14, 73);
            lblInteres.Margin = new Padding(2, 0, 2, 0);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(45, 15);
            lblInteres.TabIndex = 24;
            lblInteres.Text = "Interes:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(14, 35);
            lblCuotas.Margin = new Padding(2, 0, 2, 0);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(47, 15);
            lblCuotas.TabIndex = 23;
            lblCuotas.Text = "Cuotas:";
            // 
            // cbxAutoplan
            // 
            cbxAutoplan.AutoSize = true;
            cbxAutoplan.Location = new Point(814, 267);
            cbxAutoplan.Margin = new Padding(2);
            cbxAutoplan.Name = "cbxAutoplan";
            cbxAutoplan.Size = new Size(75, 19);
            cbxAutoplan.TabIndex = 21;
            cbxAutoplan.Text = "AutoPlan";
            cbxAutoplan.UseVisualStyleBackColor = true;
            cbxAutoplan.CheckedChanged += cbxAutoplan_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 192);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 22;
            label2.Text = "Descuento:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(910, 195);
            cboFormaPago.Margin = new Padding(2);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(165, 23);
            cboFormaPago.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(814, 199);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 28;
            label3.Text = "Forma de Pago:";
            // 
            // cboTipoVenta
            // 
            cboTipoVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoVenta.FormattingEnabled = true;
            cboTipoVenta.Location = new Point(565, 188);
            cboTipoVenta.Margin = new Padding(2);
            cboTipoVenta.Name = "cboTipoVenta";
            cboTipoVenta.Size = new Size(124, 23);
            cboTipoVenta.TabIndex = 30;
            // 
            // FrmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1076, 604);
            Controls.Add(cboTipoVenta);
            Controls.Add(cboFormaPago);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxAutoplan);
            Controls.Add(gbxAutoplan);
            Controls.Add(cboDescuento);
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
        private ComboBox cboDescuento;
        private GroupBox gbxAutoplan;
        private Label lblInteres;
        private Label lblCuotas;
        private CheckBox cbxAutoplan;
        private TextBox txtInteres;
        private ComboBox cboCuotas;
        private Label label2;
        private ComboBox cboFormaPago;
        private Label label3;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colDescuento;
        private DataGridViewTextBoxColumn colTipoVenta;
        private DataGridViewButtonColumn colEliminar;
        private ComboBox cboTipoVenta;
    }
}