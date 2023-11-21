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
            cboVendedor.Location = new Point(111, 122);
            cboVendedor.Margin = new Padding(4);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(226, 29);
            cboVendedor.TabIndex = 4;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(111, 167);
            cboCliente.Margin = new Padding(4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(226, 29);
            cboCliente.TabIndex = 5;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(46, 263);
            cboProducto.Margin = new Padding(4);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(266, 29);
            cboProducto.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(321, 263);
            nudCantidad.Margin = new Padding(4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(95, 29);
            nudCantidad.TabIndex = 2;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { ColID, colDescripcion, colCantidad, colSubtotal, colDescuento, colTipoVenta, colEliminar });
            dgvDetallesFac.Location = new Point(46, 314);
            dgvDetallesFac.Margin = new Padding(4);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(954, 417);
            dgvDetallesFac.TabIndex = 5;
            dgvDetallesFac.CellContentClick += dgvDetallesFac_CellContentClick;
            // 
            // ColID
            // 
            ColID.FillWeight = 120F;
            ColID.HeaderText = "id";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            ColID.Width = 125;
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
            colCantidad.Width = 101;
            // 
            // colSubtotal
            // 
            colSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSubtotal.HeaderText = "SubTotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.Width = 98;
            // 
            // colDescuento
            // 
            colDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDescuento.HeaderText = "Descuento";
            colDescuento.MinimumWidth = 6;
            colDescuento.Name = "colDescuento";
            colDescuento.ReadOnly = true;
            colDescuento.Width = 112;
            // 
            // colTipoVenta
            // 
            colTipoVenta.FillWeight = 150F;
            colTipoVenta.HeaderText = "Tipo de Venta";
            colTipoVenta.MinimumWidth = 6;
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
            colEliminar.Width = 73;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1070, 759);
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
            btnCancelar.Location = new Point(1218, 759);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 49);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            lblNFactura.Location = new Point(300, 29);
            lblNFactura.Margin = new Padding(4, 0, 4, 0);
            lblNFactura.Name = "lblNFactura";
            lblNFactura.Size = new Size(114, 21);
            lblNFactura.TabIndex = 10;
            lblNFactura.Text = "FACTURA NRO";
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
            btnAgregar.Location = new Point(891, 263);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 32);
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
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(527, 263);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(158, 29);
            cboDescuento.TabIndex = 18;
            // 
            // gbxAutoplan
            // 
            gbxAutoplan.Controls.Add(cboCuotas);
            gbxAutoplan.Controls.Add(txtInteres);
            gbxAutoplan.Controls.Add(lblInteres);
            gbxAutoplan.Controls.Add(lblCuotas);
            gbxAutoplan.Location = new Point(1047, 405);
            gbxAutoplan.Name = "gbxAutoplan";
            gbxAutoplan.Size = new Size(334, 158);
            gbxAutoplan.TabIndex = 20;
            gbxAutoplan.TabStop = false;
            gbxAutoplan.Text = "Datos del AutoPlan";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(85, 45);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(151, 29);
            cboCuotas.TabIndex = 23;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(85, 98);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(125, 29);
            txtInteres.TabIndex = 22;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(18, 102);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(60, 21);
            lblInteres.TabIndex = 24;
            lblInteres.Text = "Interes:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(18, 49);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(61, 21);
            lblCuotas.TabIndex = 23;
            lblCuotas.Text = "Cuotas:";
            // 
            // cbxAutoplan
            // 
            cbxAutoplan.AutoSize = true;
            cbxAutoplan.Location = new Point(1047, 374);
            cbxAutoplan.Name = "cbxAutoplan";
            cbxAutoplan.Size = new Size(95, 25);
            cbxAutoplan.TabIndex = 21;
            cbxAutoplan.Text = "AutoPlan";
            cbxAutoplan.UseVisualStyleBackColor = true;
            cbxAutoplan.CheckedChanged += cbxAutoplan_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 269);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 22;
            label2.Text = "Descuento:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(1170, 273);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(211, 29);
            cboFormaPago.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1047, 279);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 28;
            label3.Text = "Forma de Pago:";
            // 
            // cboTipoVenta
            // 
            cboTipoVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoVenta.FormattingEnabled = true;
            cboTipoVenta.Location = new Point(726, 263);
            cboTipoVenta.Name = "cboTipoVenta";
            cboTipoVenta.Size = new Size(158, 29);
            cboTipoVenta.TabIndex = 30;
            // 
            // FrmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1383, 846);
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