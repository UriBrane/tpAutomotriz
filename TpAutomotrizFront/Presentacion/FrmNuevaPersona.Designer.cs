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
            gbxGeneral.Location = new Point(12, 12);
            gbxGeneral.Name = "gbxGeneral";
            gbxGeneral.Size = new Size(497, 322);
            gbxGeneral.TabIndex = 0;
            gbxGeneral.TabStop = false;
            gbxGeneral.Text = "Datos Generales";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(89, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(402, 29);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(402, 29);
            txtNombre.TabIndex = 12;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(89, 220);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(402, 29);
            txtCuit.TabIndex = 11;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(13, 163);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 21);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(37, 224);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(46, 21);
            lblCuit.TabIndex = 5;
            lblCuit.Text = "CUIT:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 41);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // cboTipoPersona
            // 
            cboTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPersona.FormattingEnabled = true;
            cboTipoPersona.Location = new Point(89, 37);
            cboTipoPersona.Name = "cboTipoPersona";
            cboTipoPersona.Size = new Size(402, 29);
            cboTipoPersona.TabIndex = 2;
            // 
            // gbxCliente
            // 
            gbxCliente.Controls.Add(txtNumero);
            gbxCliente.Controls.Add(txtDireccion);
            gbxCliente.Controls.Add(lblNumero);
            gbxCliente.Controls.Add(lblDireccion);
            gbxCliente.Location = new Point(515, 12);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Size = new Size(426, 161);
            gbxCliente.TabIndex = 0;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Datos de Cliente";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(90, 98);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(330, 29);
            txtNumero.TabIndex = 14;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 37);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(330, 29);
            txtDireccion.TabIndex = 15;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(13, 102);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(71, 21);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Número:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 41);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 21);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // gbxVendedor
            // 
            gbxVendedor.Controls.Add(dtpFecIngreso);
            gbxVendedor.Controls.Add(lblFecIngreso);
            gbxVendedor.Location = new Point(515, 179);
            gbxVendedor.Name = "gbxVendedor";
            gbxVendedor.Size = new Size(426, 155);
            gbxVendedor.TabIndex = 0;
            gbxVendedor.TabStop = false;
            gbxVendedor.Text = "Datos de Vendedor";
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.Location = new Point(142, 53);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(278, 29);
            dtpFecIngreso.TabIndex = 10;
            // 
            // lblFecIngreso
            // 
            lblFecIngreso.AutoSize = true;
            lblFecIngreso.Location = new Point(6, 57);
            lblFecIngreso.Name = "lblFecIngreso";
            lblFecIngreso.Size = new Size(130, 21);
            lblFecIngreso.TabIndex = 4;
            lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(710, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(378, 340);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(544, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaPersona
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 380);
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
    }
}