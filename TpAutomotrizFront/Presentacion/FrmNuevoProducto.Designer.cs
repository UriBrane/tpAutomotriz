namespace TpAutomotrizFront.Presentacion
{
    partial class FrmNuevoProducto
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
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblTipoProductos = new Label();
            lblCantidad = new Label();
            lblCantMinPorMayor = new Label();
            lblCantMin = new Label();
            cboTipoProductos = new ComboBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCantMin = new TextBox();
            txtCantidad = new TextBox();
            txtCantMinPorMayor = new TextBox();
            btnGuardar = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(56, 21);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(94, 82);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio:";
            // 
            // lblTipoProductos
            // 
            lblTipoProductos.AutoSize = true;
            lblTipoProductos.Location = new Point(12, 143);
            lblTipoProductos.Name = "lblTipoProductos";
            lblTipoProductos.Size = new Size(138, 21);
            lblTipoProductos.TabIndex = 2;
            lblTipoProductos.Text = "Tipo de Productos:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(581, 22);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 21);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblCantMinPorMayor
            // 
            lblCantMinPorMayor.AutoSize = true;
            lblCantMinPorMayor.Location = new Point(447, 83);
            lblCantMinPorMayor.Name = "lblCantMinPorMayor";
            lblCantMinPorMayor.Size = new Size(209, 21);
            lblCantMinPorMayor.TabIndex = 4;
            lblCantMinPorMayor.Text = "Cantidad minima por mayor:";
            // 
            // lblCantMin
            // 
            lblCantMin.AutoSize = true;
            lblCantMin.Location = new Point(524, 144);
            lblCantMin.Name = "lblCantMin";
            lblCantMin.Size = new Size(132, 21);
            lblCantMin.TabIndex = 5;
            lblCantMin.Text = "Cantidad Minima:";
            // 
            // cboTipoProductos
            // 
            cboTipoProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoProductos.FormattingEnabled = true;
            cboTipoProductos.Location = new Point(156, 139);
            cboTipoProductos.Name = "cboTipoProductos";
            cboTipoProductos.Size = new Size(285, 29);
            cboTipoProductos.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(156, 17);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(392, 29);
            txtDescripcion.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 78);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(285, 29);
            txtPrecio.TabIndex = 1;
            // 
            // txtCantMin
            // 
            txtCantMin.Location = new Point(662, 140);
            txtCantMin.Name = "txtCantMin";
            txtCantMin.Size = new Size(190, 29);
            txtCantMin.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(662, 18);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(190, 29);
            txtCantidad.TabIndex = 3;
            // 
            // txtCantMinPorMayor
            // 
            txtCantMinPorMayor.Location = new Point(662, 79);
            txtCantMinPorMayor.Name = "txtCantMinPorMayor";
            txtCantMinPorMayor.Size = new Size(190, 29);
            txtCantMinPorMayor.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(186, 211);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(320, 211);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(454, 211);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(588, 211);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 264);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCantMinPorMayor);
            Controls.Add(txtCantidad);
            Controls.Add(txtCantMin);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(cboTipoProductos);
            Controls.Add(lblCantMin);
            Controls.Add(lblCantMinPorMayor);
            Controls.Add(lblCantidad);
            Controls.Add(lblTipoProductos);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Name = "FrmNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto";
            Load += FrmNuevoProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblTipoProductos;
        private Label lblCantidad;
        private Label lblCantMinPorMayor;
        private Label lblCantMin;
        private ComboBox cboTipoProductos;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtCantMin;
        private TextBox txtCantidad;
        private TextBox txtCantMinPorMayor;
        private Button btnGuardar;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnCancelar;
    }
}