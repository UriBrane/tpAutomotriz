namespace TpAutomotriz.Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaPersona));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cboTipoPersona = new System.Windows.Forms.ComboBox();
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.gbxVendedor = new System.Windows.Forms.GroupBox();
            this.dtpFecIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFecIngreso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxGeneral.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(266, 275);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(24, 27);
            this.lblTipoPersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(31, 13);
            this.lblTipoPersona.TabIndex = 1;
            this.lblTipoPersona.Text = "Tipo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 66);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(8, 105);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(22, 144);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "CUIT:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(4, 27);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(11, 66);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número:";
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Location = new System.Drawing.Point(57, 24);
            this.cboTipoPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(191, 21);
            this.cboTipoPersona.TabIndex = 8;
            // 
            // gbxGeneral
            // 
            this.gbxGeneral.Controls.Add(this.txtCuit);
            this.gbxGeneral.Controls.Add(this.txtApellido);
            this.gbxGeneral.Controls.Add(this.cboTipoPersona);
            this.gbxGeneral.Controls.Add(this.lblTipoPersona);
            this.gbxGeneral.Controls.Add(this.txtNombre);
            this.gbxGeneral.Controls.Add(this.lblNombre);
            this.gbxGeneral.Controls.Add(this.lblCuit);
            this.gbxGeneral.Controls.Add(this.lblApellido);
            this.gbxGeneral.Location = new System.Drawing.Point(9, 10);
            this.gbxGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxGeneral.Size = new System.Drawing.Size(382, 244);
            this.gbxGeneral.TabIndex = 9;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "Datos Generales";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(57, 141);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(191, 20);
            this.txtCuit.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(57, 102);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(310, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtNumero);
            this.gbxCliente.Controls.Add(this.txtDireccion);
            this.gbxCliente.Controls.Add(this.lblDireccion);
            this.gbxCliente.Controls.Add(this.lblNumero);
            this.gbxCliente.Location = new System.Drawing.Point(396, 10);
            this.gbxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCliente.Size = new System.Drawing.Size(293, 140);
            this.gbxCliente.TabIndex = 10;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos de Cliente";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(59, 63);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(59, 24);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(227, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // gbxVendedor
            // 
            this.gbxVendedor.Controls.Add(this.dtpFecIngreso);
            this.gbxVendedor.Controls.Add(this.lblFecIngreso);
            this.gbxVendedor.Location = new System.Drawing.Point(396, 154);
            this.gbxVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxVendedor.Name = "gbxVendedor";
            this.gbxVendedor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxVendedor.Size = new System.Drawing.Size(293, 99);
            this.gbxVendedor.TabIndex = 11;
            this.gbxVendedor.TabStop = false;
            this.gbxVendedor.Text = "Datos de Vendedor";
            // 
            // dtpFecIngreso
            // 
            this.dtpFecIngreso.Location = new System.Drawing.Point(95, 24);
            this.dtpFecIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecIngreso.Name = "dtpFecIngreso";
            this.dtpFecIngreso.Size = new System.Drawing.Size(151, 20);
            this.dtpFecIngreso.TabIndex = 15;
            // 
            // lblFecIngreso
            // 
            this.lblFecIngreso.AutoSize = true;
            this.lblFecIngreso.Location = new System.Drawing.Point(4, 27);
            this.lblFecIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecIngreso.Name = "lblFecIngreso";
            this.lblFecIngreso.Size = new System.Drawing.Size(93, 13);
            this.lblFecIngreso.TabIndex = 12;
            this.lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 275);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 19);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 319);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxVendedor);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxGeneral);
            this.Controls.Add(this.btnGuardar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNuevaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente/Vendedor";
            this.gbxGeneral.ResumeLayout(false);
            this.gbxGeneral.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxVendedor.ResumeLayout(false);
            this.gbxVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboTipoPersona;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.GroupBox gbxVendedor;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFecIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFecIngreso;
    }
}