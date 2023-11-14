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
            lblNOrden = new Label();
            dtpFecha = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnAgregar = new Button();
            dgvDetallesFac = new DataGridView();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmSActual = new DataGridViewTextBoxColumn();
            clmSMinimo = new DataGridViewTextBoxColumn();
            clmEliminar = new DataGridViewButtonColumn();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            cboCliente = new ComboBox();
            cboVendedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(72, 185);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 21);
            lblCliente.TabIndex = 35;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(53, 140);
            lblVendedor.Margin = new Padding(2, 0, 2, 0);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(80, 21);
            lblVendedor.TabIndex = 34;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblNOrden
            // 
            lblNOrden.AutoSize = true;
            lblNOrden.Location = new Point(548, 56);
            lblNOrden.Name = "lblNOrden";
            lblNOrden.Size = new Size(101, 21);
            lblNOrden.TabIndex = 30;
            lblNOrden.Text = "ORDEN NRO";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(42, 223);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(682, 742);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 49);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(548, 742);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 49);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(519, 262);
            btnAgregar.Margin = new Padding(2, 3, 2, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(74, 33);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { clmDescripcion, clmCantidad, clmSActual, clmSMinimo, clmEliminar });
            dgvDetallesFac.Location = new Point(42, 316);
            dgvDetallesFac.Margin = new Padding(3, 4, 3, 4);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(762, 417);
            dgvDetallesFac.TabIndex = 26;
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
            // clmSActual
            // 
            clmSActual.HeaderText = "Stock Actual";
            clmSActual.MinimumWidth = 6;
            clmSActual.Name = "clmSActual";
            clmSActual.ReadOnly = true;
            clmSActual.Width = 125;
            // 
            // clmSMinimo
            // 
            clmSMinimo.HeaderText = "Stock Minimo";
            clmSMinimo.MinimumWidth = 6;
            clmSMinimo.Name = "clmSMinimo";
            clmSMinimo.ReadOnly = true;
            clmSMinimo.Width = 125;
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
            // nudCantidad
            // 
            nudCantidad.Location = new Point(415, 264);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(96, 29);
            nudCantidad.TabIndex = 24;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(42, 264);
            cboProducto.Margin = new Padding(3, 4, 3, 4);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(366, 29);
            cboProducto.TabIndex = 23;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(141, 182);
            cboCliente.Margin = new Padding(3, 4, 3, 4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(227, 29);
            cboCliente.TabIndex = 27;
            // 
            // cboVendedor
            // 
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(141, 138);
            cboVendedor.Margin = new Padding(3, 4, 3, 4);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(227, 29);
            cboVendedor.TabIndex = 25;
            // 
            // FrmNuevaOrden
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 807);
            Controls.Add(lblCliente);
            Controls.Add(lblVendedor);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmNuevaOrden";
            Text = "FrmNuevaOrden";
            Load += FrmNuevaOrden_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblVendedor;
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