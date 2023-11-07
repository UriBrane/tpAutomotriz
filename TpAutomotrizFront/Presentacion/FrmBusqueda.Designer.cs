namespace TpAutomotrizFront.Presentacion
{
    partial class FrmBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusqueda));
            lblCliente = new Label();
            lblVendedor = new Label();
            cboCliente = new ComboBox();
            cboVendedor = new ComboBox();
            dataGridView1 = new DataGridView();
            clm = new DataGridViewTextBoxColumn();
            clmCliente = new DataGridViewTextBoxColumn();
            clmFecha = new DataGridViewTextBoxColumn();
            clmMonto = new DataGridViewTextBoxColumn();
            clmEstado = new DataGridViewTextBoxColumn();
            clmConsultar = new DataGridViewButtonColumn();
            clmAnular = new DataGridViewButtonColumn();
            dateTimePicker1 = new DateTimePicker();
            lblFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(56, 105);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(41, 73);
            lblVendedor.Margin = new Padding(2, 0, 2, 0);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 18;
            lblVendedor.Text = "Vendedor:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(109, 103);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(177, 23);
            cboCliente.TabIndex = 17;
            // 
            // cboVendedor
            // 
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(109, 71);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(177, 23);
            cboVendedor.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm, clmCliente, clmFecha, clmMonto, clmEstado, clmConsultar, clmAnular });
            dataGridView1.Location = new Point(17, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(741, 280);
            dataGridView1.TabIndex = 20;
            // 
            // clm
            // 
            clm.HeaderText = "FACTURA N°";
            clm.Name = "clm";
            // 
            // clmCliente
            // 
            clmCliente.HeaderText = "CLIENTE";
            clmCliente.Name = "clmCliente";
            // 
            // clmFecha
            // 
            clmFecha.HeaderText = "FECHA";
            clmFecha.Name = "clmFecha";
            // 
            // clmMonto
            // 
            clmMonto.HeaderText = "TOTAL";
            clmMonto.Name = "clmMonto";
            // 
            // clmEstado
            // 
            clmEstado.HeaderText = "ESTADO";
            clmEstado.Name = "clmEstado";
            clmEstado.ReadOnly = true;
            clmEstado.Resizable = DataGridViewTriState.True;
            clmEstado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // clmConsultar
            // 
            clmConsultar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmConsultar.HeaderText = "CONSULTAR";
            clmConsultar.Name = "clmConsultar";
            clmConsultar.SortMode = DataGridViewColumnSortMode.Automatic;
            clmConsultar.Text = "Consular";
            clmConsultar.Width = 97;
            // 
            // clmAnular
            // 
            clmAnular.HeaderText = "ANULAR";
            clmAnular.Name = "clmAnular";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(372, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(329, 76);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "Fecha";
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 463);
            Controls.Add(lblFecha);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(lblCliente);
            Controls.Add(lblVendedor);
            Controls.Add(cboCliente);
            Controls.Add(cboVendedor);
            DoubleBuffered = true;
            Name = "FrmBusqueda";
            Text = "FrmBusqueda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblVendedor;
        private ComboBox cboCliente;
        private ComboBox cboVendedor;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm;
        private DataGridViewTextBoxColumn clmCliente;
        private DataGridViewTextBoxColumn clmFecha;
        private DataGridViewTextBoxColumn clmMonto;
        private DataGridViewTextBoxColumn clmEstado;
        private DataGridViewButtonColumn clmConsultar;
        private DataGridViewButtonColumn clmAnular;
        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
    }
}