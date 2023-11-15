namespace TpAutomotrizFront.Presentacion
{
    partial class FrmConsultarProducto
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
            btnBuscar = new Button();
            cboTipoProducto = new ComboBox();
            lblTipoPersona = new Label();
            dgvProductos = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColCantMin = new DataGridViewTextBoxColumn();
            ColCant = new DataGridViewTextBoxColumn();
            ColCantMinMayor = new DataGridViewTextBoxColumn();
            ColVer = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(304, 56);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 21);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(144, 55);
            cboTipoProducto.Margin = new Padding(2);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(118, 23);
            cboTipoProducto.TabIndex = 10;
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Location = new Point(39, 59);
            lblTipoPersona.Margin = new Padding(2, 0, 2, 0);
            lblTipoPersona.Name = "lblTipoPersona";
            lblTipoPersona.Size = new Size(101, 15);
            lblTipoPersona.TabIndex = 9;
            lblTipoPersona.Text = "Tipo de Producto:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ColID, ColTipo, ColPrecio, ColNombre, ColCantMin, ColCant, ColCantMinMayor, ColVer });
            dgvProductos.Location = new Point(39, 82);
            dgvProductos.Margin = new Padding(2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 31;
            dgvProductos.Size = new Size(771, 290);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Width = 50;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColCantMin
            // 
            ColCantMin.HeaderText = "Cantidad Minima";
            ColCantMin.Name = "ColCantMin";
            ColCantMin.ReadOnly = true;
            // 
            // ColCant
            // 
            ColCant.HeaderText = "Cantidad";
            ColCant.Name = "ColCant";
            ColCant.ReadOnly = true;
            // 
            // ColCantMinMayor
            // 
            ColCantMinMayor.HeaderText = "Cantidad Minima x Mayor";
            ColCantMinMayor.Name = "ColCantMinMayor";
            ColCantMinMayor.ReadOnly = true;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver";
            ColVer.Name = "ColVer";
            ColVer.ReadOnly = true;
            ColVer.Width = 40;
            // 
            // FrmConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 395);
            Controls.Add(btnBuscar);
            Controls.Add(cboTipoProducto);
            Controls.Add(lblTipoPersona);
            Controls.Add(dgvProductos);
            Name = "FrmConsultarProducto";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private ComboBox cboTipoProducto;
        private Label lblTipoPersona;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColCantMin;
        private DataGridViewTextBoxColumn ColCant;
        private DataGridViewTextBoxColumn ColCantMinMayor;
        private DataGridViewButtonColumn ColVer;
    }
}