namespace TpAutomotrizFront.Presentacion
{
    partial class FrmConsultaProductos
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
            cboDescripcion = new ComboBox();
            lblDescripcion = new Label();
            txtCantMinPorMayor = new TextBox();
            txtCantidad = new TextBox();
            txtCantMin = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            cboTipoProductos = new ComboBox();
            lblCantMin = new Label();
            lblCantMinPorMayor = new Label();
            lblCantidad = new Label();
            lblTipoProductos = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // cboDescripcion
            // 
            cboDescripcion.FormattingEnabled = true;
            cboDescripcion.Location = new Point(129, 41);
            cboDescripcion.Name = "cboDescripcion";
            cboDescripcion.Size = new Size(358, 23);
            cboDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 44);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtCantMinPorMayor
            // 
            txtCantMinPorMayor.Location = new Point(523, 138);
            txtCantMinPorMayor.Margin = new Padding(2);
            txtCantMinPorMayor.Name = "txtCantMinPorMayor";
            txtCantMinPorMayor.Size = new Size(149, 23);
            txtCantMinPorMayor.TabIndex = 14;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(523, 95);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(149, 23);
            txtCantidad.TabIndex = 12;
            // 
            // txtCantMin
            // 
            txtCantMin.Location = new Point(523, 182);
            txtCantMin.Margin = new Padding(2);
            txtCantMin.Name = "txtCantMin";
            txtCantMin.Size = new Size(149, 23);
            txtCantMin.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(129, 138);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(223, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(129, 94);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(306, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // cboTipoProductos
            // 
            cboTipoProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoProductos.FormattingEnabled = true;
            cboTipoProductos.Location = new Point(129, 181);
            cboTipoProductos.Margin = new Padding(2);
            cboTipoProductos.Name = "cboTipoProductos";
            cboTipoProductos.Size = new Size(223, 23);
            cboTipoProductos.TabIndex = 10;
            // 
            // lblCantMin
            // 
            lblCantMin.AutoSize = true;
            lblCantMin.Location = new Point(416, 185);
            lblCantMin.Margin = new Padding(2, 0, 2, 0);
            lblCantMin.Name = "lblCantMin";
            lblCantMin.Size = new Size(102, 15);
            lblCantMin.TabIndex = 17;
            lblCantMin.Text = "Cantidad Minima:";
            // 
            // lblCantMinPorMayor
            // 
            lblCantMinPorMayor.AutoSize = true;
            lblCantMinPorMayor.Location = new Point(356, 141);
            lblCantMinPorMayor.Margin = new Padding(2, 0, 2, 0);
            lblCantMinPorMayor.Name = "lblCantMinPorMayor";
            lblCantMinPorMayor.Size = new Size(160, 15);
            lblCantMinPorMayor.TabIndex = 15;
            lblCantMinPorMayor.Text = "Cantidad minima por mayor:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(460, 98);
            lblCantidad.Margin = new Padding(2, 0, 2, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblTipoProductos
            // 
            lblTipoProductos.AutoSize = true;
            lblTipoProductos.Location = new Point(17, 184);
            lblTipoProductos.Margin = new Padding(2, 0, 2, 0);
            lblTipoProductos.Name = "lblTipoProductos";
            lblTipoProductos.Size = new Size(106, 15);
            lblTipoProductos.TabIndex = 11;
            lblTipoProductos.Text = "Tipo de Productos:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(81, 141);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 7;
            label1.Text = "Nueva Descripción:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(696, 244);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 21);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(599, 244);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(73, 21);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(510, 244);
            btnConsultar.Margin = new Padding(2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(73, 21);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
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
            Controls.Add(label1);
            Controls.Add(lblDescripcion);
            Controls.Add(cboDescripcion);
            Name = "FrmConsultaProductos";
            Text = "FrmConsultaProductos";
            Load += FrmConsultaProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboDescripcion;
        private Label lblDescripcion;
        private TextBox txtCantMinPorMayor;
        private TextBox txtCantidad;
        private TextBox txtCantMin;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private ComboBox cboTipoProductos;
        private Label lblCantMin;
        private Label lblCantMinPorMayor;
        private Label lblCantidad;
        private Label lblTipoProductos;
        private Label lblPrecio;
        private Label label1;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnConsultar;
    }
}