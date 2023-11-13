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
            label1 = new Label();
            txtContra = new TextBox();
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
            gbxGeneral.Location = new Point(9, 9);
            gbxGeneral.Margin = new Padding(2);
            gbxGeneral.Name = "gbxGeneral";
            gbxGeneral.Padding = new Padding(2);
            gbxGeneral.Size = new Size(723, 111);
            gbxGeneral.TabIndex = 0;
            gbxGeneral.TabStop = false;
            gbxGeneral.Text = "Datos Generales";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(397, 70);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(295, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(397, 26);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(68, 73);
            txtCuit.Margin = new Padding(2);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(231, 23);
            txtCuit.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(338, 73);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(338, 29);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(27, 76);
            lblCuit.Margin = new Padding(2, 0, 2, 0);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(35, 15);
            lblCuit.TabIndex = 5;
            lblCuit.Text = "CUIT:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(32, 32);
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
            cboTipoPersona.Location = new Point(70, 29);
            cboTipoPersona.Margin = new Padding(2);
            cboTipoPersona.Name = "cboTipoPersona";
            cboTipoPersona.Size = new Size(229, 23);
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
            gbxCliente.Location = new Point(9, 125);
            gbxCliente.Margin = new Padding(2);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Padding = new Padding(2);
            gbxCliente.Size = new Size(723, 113);
            gbxCliente.TabIndex = 1;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Datos de Cliente";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(397, 23);
            cboTipoCliente.Margin = new Padding(2);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(295, 23);
            cboTipoCliente.TabIndex = 2;
            // 
            // cboBarrio
            // 
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(397, 66);
            cboBarrio.Margin = new Padding(2);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(295, 23);
            cboBarrio.TabIndex = 3;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(303, 26);
            lblTipoCliente.Margin = new Padding(2, 0, 2, 0);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(89, 15);
            lblTipoCliente.TabIndex = 4;
            lblTipoCliente.Text = "Tipo de Cliente:";
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(350, 69);
            lblBarrio.Margin = new Padding(2, 0, 2, 0);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(41, 15);
            lblBarrio.TabIndex = 5;
            lblBarrio.Text = "Barrio:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(70, 66);
            txtNumero.Margin = new Padding(2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(229, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(70, 23);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(229, 23);
            txtDireccion.TabIndex = 0;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(10, 69);
            lblNumero.Margin = new Padding(2, 0, 2, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Número:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(5, 26);
            lblDireccion.Margin = new Padding(2, 0, 2, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // gbxVendedor
            // 
            gbxVendedor.Controls.Add(label1);
            gbxVendedor.Controls.Add(txtContra);
            gbxVendedor.Controls.Add(lblCategoria);
            gbxVendedor.Controls.Add(dtpFecIngreso);
            gbxVendedor.Controls.Add(cboCategoria);
            gbxVendedor.Controls.Add(lblFecIngreso);
            gbxVendedor.Enabled = false;
            gbxVendedor.Location = new Point(9, 242);
            gbxVendedor.Margin = new Padding(2);
            gbxVendedor.Name = "gbxVendedor";
            gbxVendedor.Padding = new Padding(2);
            gbxVendedor.Size = new Size(723, 102);
            gbxVendedor.TabIndex = 2;
            gbxVendedor.TabStop = false;
            gbxVendedor.Text = "Datos de Vendedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Contraseña:";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(110, 62);
            txtContra.Margin = new Padding(2);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(189, 23);
            txtContra.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(331, 32);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría:";
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.Format = DateTimePickerFormat.Short;
            dtpFecIngreso.Location = new Point(110, 29);
            dtpFecIngreso.Margin = new Padding(2);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(189, 23);
            dtpFecIngreso.TabIndex = 0;
            dtpFecIngreso.Value = new DateTime(2023, 11, 3, 0, 0, 0, 0);
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(397, 29);
            cboCategoria.Margin = new Padding(2);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(295, 23);
            cboCategoria.TabIndex = 1;
            // 
            // lblFecIngreso
            // 
            lblFecIngreso.AutoSize = true;
            lblFecIngreso.Location = new Point(5, 32);
            lblFecIngreso.Margin = new Padding(2, 0, 2, 0);
            lblFecIngreso.Name = "lblFecIngreso";
            lblFecIngreso.Size = new Size(99, 15);
            lblFecIngreso.TabIndex = 4;
            lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(135, 359);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 21);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(522, 359);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 21);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(264, 359);
            btnConsultar.Margin = new Padding(2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(73, 21);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(393, 359);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(73, 21);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmNuevaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 391);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(gbxVendedor);
            Controls.Add(gbxCliente);
            Controls.Add(gbxGeneral);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Margin = new Padding(2);
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
        private Label label1;
        private TextBox txtContra;
    }
}