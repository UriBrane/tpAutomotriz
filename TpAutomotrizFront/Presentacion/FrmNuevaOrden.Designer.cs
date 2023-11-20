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
            txtVendedor = new TextBox();
            txtCliente = new TextBox();
            lblTotal = new Label();
            dgvDetallesFac = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colTipoVenta = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(56, 143);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 35;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(41, 111);
            lblVendedor.Margin = new Padding(2, 0, 2, 0);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 34;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblNOrden
            // 
            lblNOrden.AutoSize = true;
            lblNOrden.Location = new Point(23, 83);
            lblNOrden.Margin = new Padding(2, 0, 2, 0);
            lblNOrden.Name = "lblNOrden";
            lblNOrden.Size = new Size(77, 15);
            lblNOrden.TabIndex = 30;
            lblNOrden.Text = "ORDEN NRO:";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(33, 170);
            dtpFecha.Margin = new Padding(2, 3, 2, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(156, 23);
            dtpFecha.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(410, 529);
            btnCancelar.Margin = new Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 35);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(281, 529);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 35);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(118, 108);
            txtVendedor.Margin = new Padding(2);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(98, 23);
            txtVendedor.TabIndex = 36;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(118, 140);
            txtCliente.Margin = new Padding(2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(98, 23);
            txtCliente.TabIndex = 37;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(23, 510);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 39;
            lblTotal.Text = "TOTAL";
            // 
            // dgvDetallesFac
            // 
            dgvDetallesFac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFac.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, colSubtotal, colDescuento, colTipoVenta, dataGridViewButtonColumn1 });
            dgvDetallesFac.Location = new Point(23, 209);
            dgvDetallesFac.Name = "dgvDetallesFac";
            dgvDetallesFac.ReadOnly = true;
            dgvDetallesFac.RowHeadersWidth = 51;
            dgvDetallesFac.RowTemplate.Height = 25;
            dgvDetallesFac.Size = new Size(742, 298);
            dgvDetallesFac.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 120F;
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 80;
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
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewButtonColumn1.HeaderText = "Eliminar";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Width = 56;
            // 
            // FrmNuevaOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 576);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetallesFac);
            Controls.Add(txtCliente);
            Controls.Add(txtVendedor);
            Controls.Add(lblCliente);
            Controls.Add(lblVendedor);
            Controls.Add(lblNOrden);
            Controls.Add(dtpFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            DoubleBuffered = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmNuevaOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNuevaOrden";
            Load += FrmNuevaOrden_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFac).EndInit();
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
        private NumericUpDown nudCantidad;
        private ComboBox cboProducto;
        private ComboBox cboCliente;
        private ComboBox cboVendedor;
        private TextBox txtVendedor;
        private TextBox txtCliente;
        private Label lblTotal;
        private DataGridView dgvDetallesFac;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colDescuento;
        private DataGridViewTextBoxColumn colTipoVenta;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn ColEliminar;
        private DataGridViewTextBoxColumn ColSMinimo;
        private DataGridViewTextBoxColumn ColSActual;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColId;
        private DataGridView dgvDetallesPed;
        private Label label1;
    }
}