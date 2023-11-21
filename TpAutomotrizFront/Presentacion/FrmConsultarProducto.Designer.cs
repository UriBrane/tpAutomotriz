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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProducto));
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
            btnBuscar.Location = new Point(275, 16);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
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
            cboTipoProducto.Location = new Point(114, 15);
            cboTipoProducto.Margin = new Padding(2, 2, 2, 2);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(118, 23);
            cboTipoProducto.TabIndex = 10;
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Location = new Point(9, 19);
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
            dgvProductos.Location = new Point(9, 42);
            dgvProductos.Margin = new Padding(2, 2, 2, 2);
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
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Width = 50;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.MinimumWidth = 6;
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            ColTipo.Width = 125;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 125;
            // 
            // ColCantMin
            // 
            ColCantMin.HeaderText = "Cantidad Minima";
            ColCantMin.MinimumWidth = 6;
            ColCantMin.Name = "ColCantMin";
            ColCantMin.ReadOnly = true;
            ColCantMin.Width = 125;
            // 
            // ColCant
            // 
            ColCant.HeaderText = "Cantidad";
            ColCant.MinimumWidth = 6;
            ColCant.Name = "ColCant";
            ColCant.ReadOnly = true;
            ColCant.Width = 125;
            // 
            // ColCantMinMayor
            // 
            ColCantMinMayor.HeaderText = "Cantidad Minima x Mayor";
            ColCantMinMayor.MinimumWidth = 6;
            ColCantMinMayor.Name = "ColCantMinMayor";
            ColCantMinMayor.ReadOnly = true;
            ColCantMinMayor.Width = 125;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver";
            ColVer.MinimumWidth = 6;
            ColVer.Name = "ColVer";
            ColVer.ReadOnly = true;
            ColVer.Width = 40;
            // 
            // FrmConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(793, 351);
            Controls.Add(btnBuscar);
            Controls.Add(cboTipoProducto);
            Controls.Add(lblTipoPersona);
            Controls.Add(dgvProductos);
            Name = "FrmConsultarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Producto";
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