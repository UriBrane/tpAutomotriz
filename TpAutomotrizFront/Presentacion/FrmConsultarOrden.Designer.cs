namespace TpAutomotrizFront.Presentacion
{
    partial class FrmConsultarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarOrden));
            dgvOrdenes = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFecEntrega = new DataGridViewTextBoxColumn();
            ColFecPedido = new DataGridViewTextBoxColumn();
            ColVer = new DataGridViewButtonColumn();
            rbtCliente = new RadioButton();
            rbtFec = new RadioButton();
            gbxCliente = new GroupBox();
            cboCliente = new ComboBox();
            gbxFec = new GroupBox();
            dtpFecha = new DateTimePicker();
            rbtFecPedido = new RadioButton();
            rbtFecEntrega = new RadioButton();
            lblFiltros = new Label();
            btnBuscar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            gbxCliente.SuspendLayout();
            gbxFec.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.AllowUserToAddRows = false;
            dgvOrdenes.AllowUserToDeleteRows = false;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Columns.AddRange(new DataGridViewColumn[] { ColId, ColCliente, ColFecEntrega, ColFecPedido, ColVer });
            dgvOrdenes.Location = new Point(9, 233);
            dgvOrdenes.Margin = new Padding(2, 2, 2, 2);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.RowTemplate.Height = 31;
            dgvOrdenes.Size = new Size(654, 255);
            dgvOrdenes.TabIndex = 0;
            dgvOrdenes.CellContentClick += dgvOrdenes_CellContentClick;
            // 
            // ColId
            // 
            ColId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColId.HeaderText = "Id Orden";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 72;
            // 
            // ColCliente
            // 
            ColCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColCliente.HeaderText = "Cliente";
            ColCliente.MinimumWidth = 6;
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 69;
            // 
            // ColFecEntrega
            // 
            ColFecEntrega.HeaderText = "Fecha de Entrega";
            ColFecEntrega.MinimumWidth = 6;
            ColFecEntrega.Name = "ColFecEntrega";
            ColFecEntrega.ReadOnly = true;
            ColFecEntrega.Width = 125;
            // 
            // ColFecPedido
            // 
            ColFecPedido.HeaderText = "Fecha del Pedido";
            ColFecPedido.MinimumWidth = 6;
            ColFecPedido.Name = "ColFecPedido";
            ColFecPedido.ReadOnly = true;
            ColFecPedido.Width = 125;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver";
            ColVer.MinimumWidth = 6;
            ColVer.Name = "ColVer";
            ColVer.ReadOnly = true;
            ColVer.Width = 70;
            // 
            // rbtCliente
            // 
            rbtCliente.AutoSize = true;
            rbtCliente.Location = new Point(9, 144);
            rbtCliente.Margin = new Padding(2, 2, 2, 2);
            rbtCliente.Name = "rbtCliente";
            rbtCliente.Size = new Size(116, 19);
            rbtCliente.TabIndex = 1;
            rbtCliente.TabStop = true;
            rbtCliente.Text = "Filtrar por Cliente";
            rbtCliente.UseVisualStyleBackColor = true;
            rbtCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // rbtFec
            // 
            rbtFec.AutoSize = true;
            rbtFec.Location = new Point(9, 31);
            rbtFec.Margin = new Padding(2, 2, 2, 2);
            rbtFec.Name = "rbtFec";
            rbtFec.Size = new Size(113, 19);
            rbtFec.TabIndex = 2;
            rbtFec.TabStop = true;
            rbtFec.Text = "Filtrar por Fecha:";
            rbtFec.UseVisualStyleBackColor = true;
            rbtFec.CheckedChanged += rbtFec_CheckedChanged;
            // 
            // gbxCliente
            // 
            gbxCliente.Controls.Add(cboCliente);
            gbxCliente.Enabled = false;
            gbxCliente.Location = new Point(9, 166);
            gbxCliente.Margin = new Padding(2, 2, 2, 2);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Padding = new Padding(2, 2, 2, 2);
            gbxCliente.Size = new Size(225, 52);
            gbxCliente.TabIndex = 3;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Cliente del Pedido:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(5, 20);
            cboCliente.Margin = new Padding(2, 2, 2, 2);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(205, 23);
            cboCliente.TabIndex = 8;
            // 
            // gbxFec
            // 
            gbxFec.Controls.Add(dtpFecha);
            gbxFec.Controls.Add(rbtFecPedido);
            gbxFec.Controls.Add(rbtFecEntrega);
            gbxFec.Enabled = false;
            gbxFec.Location = new Point(9, 54);
            gbxFec.Margin = new Padding(2, 2, 2, 2);
            gbxFec.Name = "gbxFec";
            gbxFec.Padding = new Padding(2, 2, 2, 2);
            gbxFec.Size = new Size(349, 79);
            gbxFec.TabIndex = 0;
            gbxFec.TabStop = false;
            gbxFec.Text = "Fecha a Filtrar:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(136, 35);
            dtpFecha.Margin = new Padding(2, 2, 2, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(195, 23);
            dtpFecha.TabIndex = 2;
            // 
            // rbtFecPedido
            // 
            rbtFecPedido.AutoSize = true;
            rbtFecPedido.Location = new Point(5, 46);
            rbtFecPedido.Margin = new Padding(2, 2, 2, 2);
            rbtFecPedido.Name = "rbtFecPedido";
            rbtFecPedido.Size = new Size(115, 19);
            rbtFecPedido.TabIndex = 1;
            rbtFecPedido.TabStop = true;
            rbtFecPedido.Text = "Fecha de Pedido:";
            rbtFecPedido.UseVisualStyleBackColor = true;
            // 
            // rbtFecEntrega
            // 
            rbtFecEntrega.AutoSize = true;
            rbtFecEntrega.Location = new Point(185, 35);
            rbtFecEntrega.Margin = new Padding(2, 2, 2, 2);
            rbtFecEntrega.Name = "rbtFecEntrega";
            rbtFecEntrega.Size = new Size(118, 19);
            rbtFecEntrega.TabIndex = 0;
            rbtFecEntrega.TabStop = true;
            rbtFecEntrega.Text = "Fecha de Entrega:";
            rbtFecEntrega.UseVisualStyleBackColor = true;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Location = new Point(9, 6);
            lblFiltros.Margin = new Padding(2, 0, 2, 0);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(42, 15);
            lblFiltros.TabIndex = 4;
            lblFiltros.Text = "Filtros:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(239, 185);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 21);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(513, 492);
            btnAceptar.Margin = new Padding(2, 2, 2, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(73, 21);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(590, 492);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 21);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(673, 521);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltros);
            Controls.Add(gbxFec);
            Controls.Add(gbxCliente);
            Controls.Add(rbtFec);
            Controls.Add(rbtCliente);
            Controls.Add(dgvOrdenes);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmConsultarOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Orden";
            Load += FrmConsultarOrden_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            gbxCliente.ResumeLayout(false);
            gbxFec.ResumeLayout(false);
            gbxFec.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrdenes;
        private RadioButton rbtCliente;
        private RadioButton rbtFec;
        private GroupBox gbxCliente;
        private GroupBox gbxFec;
        private Label lblFiltros;
        private Button btnBuscar;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cboCliente;
        private RadioButton rbtFecPedido;
        private RadioButton rbtFecEntrega;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFecEntrega;
        private DataGridViewTextBoxColumn ColFecPedido;
        private DataGridViewButtonColumn ColVer;
        private DateTimePicker dtpFecha;
    }
}