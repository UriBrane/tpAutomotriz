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
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFecEntrega = new DataGridViewTextBoxColumn();
            ColFecPedido = new DataGridViewTextBoxColumn();
            ColVer = new DataGridViewButtonColumn();
            rbtCliente = new RadioButton();
            rbtFecPedido = new RadioButton();
            gbxCliente = new GroupBox();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            gbxFecPedido = new GroupBox();
            lblFiltros = new Label();
            btnBuscar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColCliente, ColFecEntrega, ColFecPedido, ColVer });
            dataGridView1.Location = new Point(12, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(841, 357);
            dataGridView1.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 125;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.MinimumWidth = 6;
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 125;
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
            ColVer.Width = 125;
            // 
            // rbtCliente
            // 
            rbtCliente.AutoSize = true;
            rbtCliente.Location = new Point(12, 48);
            rbtCliente.Name = "rbtCliente";
            rbtCliente.Size = new Size(152, 25);
            rbtCliente.TabIndex = 1;
            rbtCliente.TabStop = true;
            rbtCliente.Text = "Filtrar por Cliente";
            rbtCliente.UseVisualStyleBackColor = true;
            rbtCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // rbtFecPedido
            // 
            rbtFecPedido.AutoSize = true;
            rbtFecPedido.Location = new Point(12, 176);
            rbtFecPedido.Name = "rbtFecPedido";
            rbtFecPedido.Size = new Size(223, 25);
            rbtFecPedido.TabIndex = 2;
            rbtFecPedido.TabStop = true;
            rbtFecPedido.Text = "Filtrar por Fecha del Pedido:";
            rbtFecPedido.UseVisualStyleBackColor = true;
            // 
            // gbxCliente
            // 
            gbxCliente.Controls.Add(lblCliente);
            gbxCliente.Controls.Add(cboCliente);
            gbxCliente.Location = new Point(12, 79);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Size = new Size(841, 91);
            gbxCliente.TabIndex = 3;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Filtros por Cliente:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 31);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 21);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(72, 28);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(178, 29);
            cboCliente.TabIndex = 8;
            // 
            // gbxFecPedido
            // 
            gbxFecPedido.Location = new Point(12, 207);
            gbxFecPedido.Name = "gbxFecPedido";
            gbxFecPedido.Size = new Size(841, 78);
            gbxFecPedido.TabIndex = 0;
            gbxFecPedido.TabStop = false;
            gbxFecPedido.Text = "Filtros por Fecha del Pedido:";
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Location = new Point(12, 9);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(56, 21);
            lblFiltros.TabIndex = 4;
            lblFiltros.Text = "Filtros:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 291);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(659, 689);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(759, 689);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarOrden
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 730);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltros);
            Controls.Add(gbxFecPedido);
            Controls.Add(gbxCliente);
            Controls.Add(rbtFecPedido);
            Controls.Add(rbtCliente);
            Controls.Add(dataGridView1);
            Name = "FrmConsultarOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Orden";
            Load += FrmConsultarOrden_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbxCliente.ResumeLayout(false);
            gbxCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFecEntrega;
        private DataGridViewTextBoxColumn ColFecPedido;
        private DataGridViewButtonColumn ColVer;
        private RadioButton rbtCliente;
        private RadioButton rbtFecPedido;
        private GroupBox gbxCliente;
        private GroupBox gbxFecPedido;
        private Label lblFiltros;
        private Button btnBuscar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblCliente;
        private ComboBox cboCliente;
    }
}