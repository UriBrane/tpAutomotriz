namespace TpAutomotrizFront.Presentacion
{
    partial class FrmNuevaOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaOrden));
            lblCliente = new Label();
            lblVendedor = new Label();
            lblDetalleCliente = new Label();
            lblNOrden = new Label();
            dtpFecha = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnAgregar = new Button();
            dgvDetallesFac = new DataGridView();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            cboCliente = new ComboBox();
            cboVendedor = new ComboBox();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmSActual = new DataGridViewTextBoxColumn();
            clmSMinimo = new DataGridViewTextBoxColumn();
            clmEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(56, 132);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 35;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(41, 100);
            lblVendedor.Margin = new Padding(2, 0, 2, 0);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 34;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblDetalleCliente
            // 
            lblDetalleCliente.AutoSize = true;
            lblDetalleCliente.BackColor = Color.Transparent;
            lblDetalleCliente.BorderStyle = BorderStyle.Fixed3D;
            lblDetalleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalleCliente.Location = new Point(323, 67);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(100, 86);
            lblDetalleCliente.TabIndex = 31;
            lblDetalleCliente.Text = "CUIT:\r\nDOMICILIO:\r\nTELEFONO:\r\nMAIL:\r\n";
            // 
            // lblNOrden
            // 
            lblNOrden.AutoSize = true;
            lblNOrden.Location = new Point(212, 26);
            lblNOrden.Name = "lblNOrden";
            lblNOrden.Size = new Size(74, 15);
            lblNOrden.TabIndex = 30;
            lblNOrden.Text = "ORDEN NRO";
            lblNOrden.Click += lblNFactura_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(32, 159);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(156, 23);
            dtpFecha.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(530, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(426, 530);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 35);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(403, 186);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(58, 23);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { clmDescripcion, clmCantidad, clmSActual, clmSMinimo, clmEliminar });
            dgvDetallesFac.Location = new Point(32, 226);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(592, 298);
            dgvDetallesFac.TabIndex = 26;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(323, 188);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(74, 23);
            nudCantidad.TabIndex = 24;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(32, 188);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(286, 23);
            cboProducto.TabIndex = 23;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(109, 130);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(177, 23);
            cboCliente.TabIndex = 27;
            // 
            // cboVendedor
            // 
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(109, 98);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(177, 23);
            cboVendedor.TabIndex = 25;
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
            // clmSActual
            // 
            clmSActual.HeaderText = "Stock Actual";
            clmSActual.Name = "clmSActual";
            clmSActual.ReadOnly = true;
            // 
            // clmSMinimo
            // 
            clmSMinimo.HeaderText = "Stock Minimo";
            clmSMinimo.Name = "clmSMinimo";
            clmSMinimo.ReadOnly = true;
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
            // FrmNuevaOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(644, 577);
            Controls.Add(lblCliente);
            Controls.Add(lblVendedor);
            Controls.Add(lblDetalleCliente);
            Controls.Add(lblNOrden);
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
            Name = "FrmNuevaOrden";
            Text = "FrmNuevaOrden";
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblVendedor;
        private Label lblDetalleCliente;
        private Label lblNOrden;
        private DateTimePicker dtpFecha;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnAgregar;
        private DataGridView dgvDetallesFac;
        private NumericUpDown nudCantidad;
        private ComboBox cboProducto;
        private ComboBox cboCliente;
        private ComboBox cboVendedor;
        private DataGridViewTextBoxColumn clmDescripcion;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmSActual;
        private DataGridViewTextBoxColumn clmSMinimo;
        private DataGridViewButtonColumn clmEliminar;
    }
}