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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            cboProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            dataGridView1 = new DataGridView();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmSubtotal = new DataGridViewTextBoxColumn();
            clmDescuento = new DataGridViewTextBoxColumn();
            clmEliminar = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtpFecha = new DateTimePicker();
            lblNFactura = new Label();
            lblDetalleCliente = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(770, 21);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(334, 29);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(770, 62);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(334, 29);
            comboBox2.TabIndex = 1;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(46, 141);
            cboProducto.Margin = new Padding(4);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(367, 29);
            cboProducto.TabIndex = 3;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(454, 141);
            nudCantidad.Margin = new Padding(4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(95, 29);
            nudCantidad.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmDescripcion, clmCantidad, clmSubtotal, clmDescuento, clmEliminar });
            dataGridView1.Location = new Point(46, 199);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(703, 318);
            dataGridView1.TabIndex = 5;
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(588, 131);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 49);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(854, 562);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 49);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(983, 562);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 49);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(46, 101);
            dtpFecha.Margin = new Padding(4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(367, 29);
            dtpFecha.TabIndex = 9;
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
            lblDetalleCliente.Location = new Point(770, 160);
            lblDetalleCliente.Margin = new Padding(4, 0, 4, 0);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(123, 114);
            lblDetalleCliente.TabIndex = 11;
            lblDetalleCliente.Text = "CUIT:\r\nDOMICILIO:\r\nTELEFONO:\r\nMAIL:\r\n";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(770, 478);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 21);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL";
            // 
            // FrmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 624);
            Controls.Add(lblTotal);
            Controls.Add(lblDetalleCliente);
            Controls.Add(lblNFactura);
            Controls.Add(dtpFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(nudCantidad);
            Controls.Add(cboProducto);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Name = "FrmNuevaFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Factura";
            Load += FrmNuevaFactura_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox cboProducto;
        private NumericUpDown nudCantidad;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnAceptar;
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
    }
}