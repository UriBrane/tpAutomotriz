namespace TpAutomotrizFront.Presentacion
{
    partial class FrmNuevaPersona
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
            gbxGeneral = new GroupBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtCuit = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblCuit = new Label();
            lblTipo = new Label();
            cboTipoPersona = new ComboBox();
            gbxCliente = new GroupBox();
            cboTipoCliente = new ComboBox();
            cboBarrio = new ComboBox();
            lblTipoCliente = new Label();
            lblBarrio = new Label();
            txtNumero = new TextBox();
            txtDireccion = new TextBox();
            lblNumero = new Label();
            lblDireccion = new Label();
            gbxVendedor = new GroupBox();
            lblCategoria = new Label();
            dtpFecIngreso = new DateTimePicker();
            cboCategoria = new ComboBox();
            lblFecIngreso = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            gbxGeneral.SuspendLayout();
            gbxCliente.SuspendLayout();
            gbxVendedor.SuspendLayout();
            SuspendLayout();
            // 
            // gbxGeneral
            // 
            gbxGeneral.Controls.Add(txtApellido);
            gbxGeneral.Controls.Add(txtNombre);
            gbxGeneral.Controls.Add(txtCuit);
            gbxGeneral.Controls.Add(lblApellido);
            gbxGeneral.Controls.Add(lblNombre);
            gbxGeneral.Controls.Add(lblCuit);
            gbxGeneral.Controls.Add(lblTipo);
            gbxGeneral.Controls.Add(cboTipoPersona);
            gbxGeneral.Location = new Point(12, 13);
            gbxGeneral.Name = "gbxGeneral";
            gbxGeneral.Size = new Size(929, 156);
            gbxGeneral.TabIndex = 0;
            gbxGeneral.TabStop = false;
            gbxGeneral.Text = "Datos Generales";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(511, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(378, 29);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(511, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(378, 29);
            txtNombre.TabIndex = 2;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(87, 102);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(296, 29);
            txtCuit.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(435, 102);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 21);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(434, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(35, 106);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(46, 21);
            lblCuit.TabIndex = 5;
            lblCuit.Text = "CUIT:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(41, 45);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // cboTipoPersona
            // 
            cboTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPersona.FormattingEnabled = true;
            cboTipoPersona.Location = new Point(90, 41);
            cboTipoPersona.Name = "cboTipoPersona";
            cboTipoPersona.Size = new Size(293, 29);
            cboTipoPersona.TabIndex = 0;
            cboTipoPersona.SelectedIndexChanged += cboTipoPersona_SelectedIndexChanged;
            // 
            // gbxCliente
            // 
            gbxCliente.Controls.Add(cboTipoCliente);
            gbxCliente.Controls.Add(cboBarrio);
            gbxCliente.Controls.Add(lblTipoCliente);
            gbxCliente.Controls.Add(lblBarrio);
            gbxCliente.Controls.Add(txtNumero);
            gbxCliente.Controls.Add(txtDireccion);
            gbxCliente.Controls.Add(lblNumero);
            gbxCliente.Controls.Add(lblDireccion);
            gbxCliente.Enabled = false;
            gbxCliente.Location = new Point(12, 175);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Size = new Size(929, 158);
            gbxCliente.TabIndex = 1;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Datos de Cliente";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(511, 32);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(378, 29);
            cboTipoCliente.TabIndex = 2;
            // 
            // cboBarrio
            // 
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(511, 93);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(378, 29);
            cboBarrio.TabIndex = 3;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(389, 36);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(116, 21);
            lblTipoCliente.TabIndex = 4;
            lblTipoCliente.Text = "Tipo de Cliente:";
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(450, 97);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(55, 21);
            lblBarrio.TabIndex = 5;
            lblBarrio.Text = "Barrio:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(90, 93);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(293, 29);
            txtNumero.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 32);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(293, 29);
            txtDireccion.TabIndex = 0;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(13, 97);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(71, 21);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Número:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 36);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // gbxVendedor
            // 
            gbxVendedor.Controls.Add(lblCategoria);
            gbxVendedor.Controls.Add(dtpFecIngreso);
            gbxVendedor.Controls.Add(cboCategoria);
            gbxVendedor.Controls.Add(lblFecIngreso);
            gbxVendedor.Enabled = false;
            gbxVendedor.Location = new Point(12, 339);
            gbxVendedor.Name = "gbxVendedor";
            gbxVendedor.Size = new Size(929, 97);
            gbxVendedor.TabIndex = 2;
            gbxVendedor.TabStop = false;
            gbxVendedor.Text = "Datos de Vendedor";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(425, 45);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 21);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría:";
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.Format = DateTimePickerFormat.Short;
            dtpFecIngreso.Location = new Point(141, 41);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(242, 29);
            dtpFecIngreso.TabIndex = 0;
            dtpFecIngreso.Value = new DateTime(2023, 11, 3, 0, 0, 0, 0);
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(511, 41);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(378, 29);
            cboCategoria.TabIndex = 1;
            // 
            // lblFecIngreso
            // 
            lblFecIngreso.AutoSize = true;
            lblFecIngreso.Location = new Point(6, 45);
            lblFecIngreso.Name = "lblFecIngreso";
            lblFecIngreso.Size = new Size(130, 21);
            lblFecIngreso.TabIndex = 4;
            lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(181, 451);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(679, 451);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(347, 451);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(513, 451);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaPersona
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 502);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(gbxVendedor);
            Controls.Add(gbxCliente);
            Controls.Add(gbxGeneral);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "FrmNuevaPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente/Vendedor";
            Load += FrmNuevaPersona_Load;
            gbxGeneral.ResumeLayout(false);
            gbxGeneral.PerformLayout();
            gbxCliente.ResumeLayout(false);
            gbxCliente.PerformLayout();
            gbxVendedor.ResumeLayout(false);
            gbxVendedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxGeneral;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCuit;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblCuit;
        private Label lblTipo;
        private ComboBox cboTipoPersona;
        private GroupBox gbxCliente;
        private TextBox txtNumero;
        private TextBox txtDireccion;
        private Label lblNumero;
        private Label lblDireccion;
        private GroupBox gbxVendedor;
        private DateTimePicker dtpFecIngreso;
        private Label lblFecIngreso;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnConsultar;
        private Button btnEditar;
        private Label lblTipoCliente;
        private Label lblBarrio;
        private ComboBox cboBarrio;
        private ComboBox cboTipoCliente;
        private Label lblCategoria;
        private ComboBox cboCategoria;
    }
}