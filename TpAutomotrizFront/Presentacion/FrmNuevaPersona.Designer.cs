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
            txtNumero = new TextBox();
            txtDireccion = new TextBox();
            lblNumero = new Label();
            lblDireccion = new Label();
            gbxVendedor = new GroupBox();
            dtpFecIngreso = new DateTimePicker();
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
            gbxGeneral.Location = new Point(9, 9);
            gbxGeneral.Margin = new Padding(2, 2, 2, 2);
            gbxGeneral.Name = "gbxGeneral";
            gbxGeneral.Padding = new Padding(2, 2, 2, 2);
            gbxGeneral.Size = new Size(387, 230);
            gbxGeneral.TabIndex = 0;
            gbxGeneral.TabStop = false;
            gbxGeneral.Text = "Datos Generales";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 114);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(314, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 70);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(314, 23);
            txtNombre.TabIndex = 12;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(69, 157);
            txtCuit.Margin = new Padding(2, 2, 2, 2);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(314, 23);
            txtCuit.TabIndex = 11;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(10, 116);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 73);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(29, 160);
            lblCuit.Margin = new Padding(2, 0, 2, 0);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(35, 15);
            lblCuit.TabIndex = 5;
            lblCuit.Text = "CUIT:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(31, 29);
            lblTipo.Margin = new Padding(2, 0, 2, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // cboTipoPersona
            // 
            cboTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPersona.FormattingEnabled = true;
            cboTipoPersona.Location = new Point(69, 26);
            cboTipoPersona.Margin = new Padding(2, 2, 2, 2);
            cboTipoPersona.Name = "cboTipoPersona";
            cboTipoPersona.Size = new Size(314, 23);
            cboTipoPersona.TabIndex = 2;
            // 
            // gbxCliente
            // 
            gbxCliente.Controls.Add(txtNumero);
            gbxCliente.Controls.Add(txtDireccion);
            gbxCliente.Controls.Add(lblNumero);
            gbxCliente.Controls.Add(lblDireccion);
            gbxCliente.Location = new Point(401, 9);
            gbxCliente.Margin = new Padding(2, 2, 2, 2);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Padding = new Padding(2, 2, 2, 2);
            gbxCliente.Size = new Size(331, 115);
            gbxCliente.TabIndex = 0;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Datos de Cliente";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(70, 70);
            txtNumero.Margin = new Padding(2, 2, 2, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(258, 23);
            txtNumero.TabIndex = 14;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(70, 26);
            txtDireccion.Margin = new Padding(2, 2, 2, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(258, 23);
            txtDireccion.TabIndex = 15;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(10, 73);
            lblNumero.Margin = new Padding(2, 0, 2, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Número:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(5, 29);
            lblDireccion.Margin = new Padding(2, 0, 2, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // gbxVendedor
            // 
            gbxVendedor.Controls.Add(dtpFecIngreso);
            gbxVendedor.Controls.Add(lblFecIngreso);
            gbxVendedor.Location = new Point(401, 128);
            gbxVendedor.Margin = new Padding(2, 2, 2, 2);
            gbxVendedor.Name = "gbxVendedor";
            gbxVendedor.Padding = new Padding(2, 2, 2, 2);
            gbxVendedor.Size = new Size(331, 111);
            gbxVendedor.TabIndex = 0;
            gbxVendedor.TabStop = false;
            gbxVendedor.Text = "Datos de Vendedor";
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.Location = new Point(110, 38);
            dtpFecIngreso.Margin = new Padding(2, 2, 2, 2);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(217, 23);
            dtpFecIngreso.TabIndex = 10;
            // 
            // lblFecIngreso
            // 
            lblFecIngreso.AutoSize = true;
            lblFecIngreso.Location = new Point(5, 41);
            lblFecIngreso.Margin = new Padding(2, 0, 2, 0);
            lblFecIngreso.Name = "lblFecIngreso";
            lblFecIngreso.Size = new Size(99, 15);
            lblFecIngreso.TabIndex = 4;
            lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(165, 243);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 21);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(552, 243);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 21);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(294, 243);
            btnConsultar.Margin = new Padding(2, 2, 2, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(73, 21);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(423, 243);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(73, 21);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 271);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(gbxVendedor);
            Controls.Add(gbxCliente);
            Controls.Add(gbxGeneral);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}