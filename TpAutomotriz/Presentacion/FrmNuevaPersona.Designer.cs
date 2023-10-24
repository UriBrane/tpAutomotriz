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
            this.button1 = new System.Windows.Forms.Button();
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
            this.gbxVendedor = new System.Windows.Forms.GroupBox();
            this.lblFecIngreso = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxGeneral.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(58, 24);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(35, 16);
            this.lblTipoPersona.TabIndex = 1;
            this.lblTipoPersona.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(36, 120);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(55, 168);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(38, 16);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "CUIT";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(35, 42);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(44, 100);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número:";
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Location = new System.Drawing.Point(137, 21);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(121, 24);
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
            this.gbxGeneral.Size = new System.Drawing.Size(555, 456);
            this.gbxGeneral.TabIndex = 9;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "General";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(137, 168);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 22);
            this.txtCuit.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 120);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 9;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.lblDireccion);
            this.gbxCliente.Controls.Add(this.lblNumero);
            this.gbxCliente.Location = new System.Drawing.Point(573, 12);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(554, 233);
            this.gbxCliente.TabIndex = 10;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // gbxVendedor
            // 
            this.gbxVendedor.Controls.Add(this.lblFecIngreso);
            this.gbxVendedor.Location = new System.Drawing.Point(573, 251);
            this.gbxVendedor.Name = "gbxVendedor";
            this.gbxVendedor.Size = new System.Drawing.Size(554, 217);
            this.gbxVendedor.TabIndex = 11;
            this.gbxVendedor.TabStop = false;
            this.gbxVendedor.Text = "Vendedor";
            // 
            // lblFecIngreso
            // 
            this.lblFecIngreso.AutoSize = true;
            this.lblFecIngreso.Location = new System.Drawing.Point(58, 61);
            this.lblFecIngreso.Name = "lblFecIngreso";
            this.lblFecIngreso.Size = new System.Drawing.Size(115, 16);
            this.lblFecIngreso.TabIndex = 12;
            this.lblFecIngreso.Text = "Fecha de Ingreso:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(714, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbxVendedor);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxGeneral);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button2;
    }
}