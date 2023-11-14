namespace TpAutomotrizFront.Presentacion
{
    partial class FrmConsultarPersona
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
            dgvPersonas = new DataGridView();
            lblLista = new Label();
            lblTipoPersona = new Label();
            cboTipoPersona = new ComboBox();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColCuit = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewButtonColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColCuit, ColEditar, ColTipo });
            dgvPersonas.Location = new Point(12, 221);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.RowTemplate.Height = 31;
            dgvPersonas.Size = new Size(713, 385);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(12, 152);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(45, 21);
            lblLista.TabIndex = 1;
            lblLista.Text = "Lista:";
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Location = new Point(12, 9);
            lblTipoPersona.Name = "lblTipoPersona";
            lblTipoPersona.Size = new Size(123, 21);
            lblTipoPersona.TabIndex = 2;
            lblTipoPersona.Text = "Tipo de Persona:";
            // 
            // cboTipoPersona
            // 
            cboTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPersona.FormattingEnabled = true;
            cboTipoPersona.Location = new Point(141, 12);
            cboTipoPersona.Name = "cboTipoPersona";
            cboTipoPersona.Size = new Size(151, 29);
            cboTipoPersona.TabIndex = 3;
            cboTipoPersona.SelectedIndexChanged += cboTipoPersona_SelectedIndexChanged;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 350;
            // 
            // ColCuit
            // 
            ColCuit.HeaderText = "CUIT";
            ColCuit.MinimumWidth = 6;
            ColCuit.Name = "ColCuit";
            ColCuit.ReadOnly = true;
            ColCuit.Width = 150;
            // 
            // ColEditar
            // 
            ColEditar.HeaderText = "Editar";
            ColEditar.MinimumWidth = 6;
            ColEditar.Name = "ColEditar";
            ColEditar.ReadOnly = true;
            ColEditar.Width = 125;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.MinimumWidth = 6;
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            ColTipo.Visible = false;
            ColTipo.Width = 125;
            // 
            // FrmConsultarPersona
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 618);
            Controls.Add(cboTipoPersona);
            Controls.Add(lblTipoPersona);
            Controls.Add(lblLista);
            Controls.Add(dgvPersonas);
            Name = "FrmConsultarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Persona";
            Load += FrmConsultarPersona_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private Label lblLista;
        private Label lblTipoPersona;
        private ComboBox cboTipoPersona;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColCuit;
        private DataGridViewButtonColumn ColEditar;
        private DataGridViewTextBoxColumn ColTipo;
    }
}