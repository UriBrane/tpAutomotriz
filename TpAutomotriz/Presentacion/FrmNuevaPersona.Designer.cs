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
            this.btnGuardar.Location = new System.Drawing.Point(354, 338);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(32, 33);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(38, 16);
            this.lblTipoPersona.TabIndex = 1;
            this.lblTipoPersona.Text = "Tipo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(10, 129);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(29, 177);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(41, 16);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "CUIT:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 33);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 81);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número:";
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Location = new System.Drawing.Point(76, 29);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(253, 24);
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
            this.gbxGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.Size = new System.Drawing.Size(510, 300);
            this.gbxGeneral.TabIndex = 9;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "Datos Generales";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(76, 174);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(253, 22);
            this.txtCuit.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(76, 126);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(412, 22);
            this.txtApellido.TabIndex = 9;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtNumero);
            this.gbxCliente.Controls.Add(this.txtDireccion);
            this.gbxCliente.Controls.Add(this.lblDireccion);
            this.gbxCliente.Controls.Add(this.lblNumero);
            this.gbxCliente.Location = new System.Drawing.Point(528, 12);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(391, 172);
            this.gbxCliente.TabIndex = 10;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos de Cliente";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(79, 78);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(301, 22);
            this.txtDireccion.TabIndex = 13;
            // 
            // gbxVendedor
            // 
            this.gbxVendedor.Controls.Add(this.dtpFecIngreso);
            this.gbxVendedor.Controls.Add(this.lblFecIngreso);
            this.gbxVendedor.Location = new System.Drawing.Point(528, 190);
            this.gbxVendedor.Name = "gbxVendedor";
            this.gbxVendedor.Size = new System.Drawing.Size(391, 122);
            this.gbxVendedor.TabIndex = 11;
            this.gbxVendedor.TabStop = false;
            this.gbxVendedor.Text = "Datos de Vendedor";
            // 
            // dtpFecIngreso
            // 
            this.dtpFecIngreso.Location = new System.Drawing.Point(127, 30);
            this.dtpFecIngreso.Name = "dtpFecIngreso";
            this.dtpFecIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFecIngreso.TabIndex = 15;
            // 
            // lblFecIngreso
            // 
            this.lblFecIngreso.AutoSize = true;
            this.lblFecIngreso.Location = new System.Drawing.Point(6, 33);
            this.lblFecIngreso.Name = "lblFecIngreso";
            this.lblFecIngreso.Size = new System.Drawing.Size(115, 16);
            this.lblFecIngreso.TabIndex = 12;
            this.lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(537, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 393);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxVendedor);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxGeneral);
            this.Controls.Add(this.btnGuardar);
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