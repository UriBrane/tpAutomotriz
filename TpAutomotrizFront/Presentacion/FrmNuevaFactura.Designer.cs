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
            cmbProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtpFecha = new DateTimePicker();
            lblNFactura = new Label();
            lblDetalleCliente = new Label();
            lblTotal = new Label();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmSubtotal = new DataGridViewTextBoxColumn();
            clmDescuento = new DataGridViewTextBoxColumn();
            clmEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(599, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(599, 44);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(261, 23);
            comboBox2.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(36, 101);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(286, 23);
            cmbProducto.TabIndex = 3;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(353, 101);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(74, 23);
            nudCantidad.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmDescripcion, clmCantidad, clmSubtotal, clmDescuento, clmEliminar });
            dataGridView1.Location = new Point(36, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(547, 227);
            dataGridView1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(457, 101);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 35);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(666, 379);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 35);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(766, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(36, 72);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(286, 23);
            dtpFecha.TabIndex = 9;
            // 
            // lblNFactura
            // 
            lblNFactura.AutoSize = true;
            lblNFactura.Location = new Point(36, 15);
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
            lblDetalleCliente.Location = new Point(599, 86);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(100, 86);
            lblDetalleCliente.TabIndex = 11;
            lblDetalleCliente.Text = "CUIT:\r\nDOMICILIO:\r\nTELEFONO:\r\nMAIL:\r\n";
            lblDetalleCliente.Click += label2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(513, 389);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL";
            // 
            // clmDescripcion
            // 
            clmDescripcion.HeaderText = "Descripción";
            clmDescripcion.Name = "clmDescripcion";
            clmDescripcion.ReadOnly = true;
            clmDescripcion.Width = 200;
            // 
            // clmCantidad
            // 
            clmCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmCantidad.HeaderText = "Cantidad";
            clmCantidad.Name = "clmCantidad";
            clmCantidad.ReadOnly = true;
            clmCantidad.Width = 80;
            // 
            // clmSubtotal
            // 
            clmSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmSubtotal.HeaderText = "SubTotal";
            clmSubtotal.Name = "clmSubtotal";
            clmSubtotal.ReadOnly = true;
            clmSubtotal.Width = 77;
            // 
            // clmDescuento
            // 
            clmDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmDescuento.HeaderText = "Descuento";
            clmDescuento.Name = "clmDescuento";
            clmDescuento.ReadOnly = true;
            clmDescuento.Width = 88;
            // 
            // clmEliminar
            // 
            clmEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmEliminar.HeaderText = "Eliminar";
            clmEliminar.Name = "clmEliminar";
            clmEliminar.ReadOnly = true;
            clmEliminar.Width = 56;
            // 
            // FrmNuevaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 426);
            Controls.Add(lblTotal);
            Controls.Add(lblDetalleCliente);
            Controls.Add(lblNFactura);
            Controls.Add(dtpFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
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
        private ComboBox cmbProducto;
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