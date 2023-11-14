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
            btnCancelar = new Button();
            gbxFiltro = new GroupBox();
            txtId = new TextBox();
            lblId = new Label();
            btnBuscar = new Button();
            cbxFiltro = new CheckBox();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColCuit = new DataGridViewTextBoxColumn();
            ColVer = new DataGridViewButtonColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            gbxFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColCuit, ColVer, ColTipo });
            dgvPersonas.Location = new Point(12, 213);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.RowTemplate.Height = 31;
            dgvPersonas.Size = new Size(713, 406);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(12, 189);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(45, 21);
            lblLista.TabIndex = 1;
            lblLista.Text = "Lista:";
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Location = new Point(12, 16);
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
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(631, 625);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbxFiltro
            // 
            gbxFiltro.Controls.Add(txtId);
            gbxFiltro.Controls.Add(lblId);
            gbxFiltro.Location = new Point(12, 84);
            gbxFiltro.Name = "gbxFiltro";
            gbxFiltro.Size = new Size(312, 67);
            gbxFiltro.TabIndex = 5;
            gbxFiltro.TabStop = false;
            gbxFiltro.Text = "Filtro";
            // 
            // txtId
            // 
            txtId.Location = new Point(64, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(230, 29);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 21);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 157);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbxFiltro
            // 
            cbxFiltro.AutoSize = true;
            cbxFiltro.Location = new Point(18, 52);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(120, 25);
            cbxFiltro.TabIndex = 6;
            cbxFiltro.Text = "Filtrar por ID";
            cbxFiltro.UseVisualStyleBackColor = true;
            cbxFiltro.CheckedChanged += cbxFiltro_CheckedChanged;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 50;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 250;
            // 
            // ColCuit
            // 
            ColCuit.HeaderText = "CUIT";
            ColCuit.MinimumWidth = 6;
            ColCuit.Name = "ColCuit";
            ColCuit.ReadOnly = true;
            ColCuit.Width = 150;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver";
            ColVer.MinimumWidth = 6;
            ColVer.Name = "ColVer";
            ColVer.ReadOnly = true;
            ColVer.Text = "";
            ColVer.Width = 80;
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
            ClientSize = new Size(742, 666);
            Controls.Add(btnBuscar);
            Controls.Add(cbxFiltro);
            Controls.Add(gbxFiltro);
            Controls.Add(btnCancelar);
            Controls.Add(cboTipoPersona);
            Controls.Add(lblTipoPersona);
            Controls.Add(lblLista);
            Controls.Add(dgvPersonas);
            Name = "FrmConsultarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Persona";
            Load += FrmConsultarPersona_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            gbxFiltro.ResumeLayout(false);
            gbxFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private Label lblLista;
        private Label lblTipoPersona;
        private ComboBox cboTipoPersona;
        private Button btnCancelar;
        private GroupBox gbxFiltro;
        private TextBox txtId;
        private Label lblId;
        private CheckBox cbxFiltro;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColCuit;
        private DataGridViewButtonColumn ColVer;
        private DataGridViewTextBoxColumn ColTipo;
    }
}