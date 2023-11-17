namespace TpAutomotrizFront.Presentacion
{
    partial class FrmConsulta
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
            label1 = new Label();
            cboConsulta = new ComboBox();
            txtSentencia = new TextBox();
            dgvConsulta = new DataGridView();
            txtSql = new TextBox();
            label2 = new Label();
            txtP1 = new TextBox();
            txtP2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(381, 37);
            label1.TabIndex = 0;
            label1.Text = "Laboratorio de Computación II";
            // 
            // cboConsulta
            // 
            cboConsulta.FormattingEnabled = true;
            cboConsulta.Location = new Point(677, 33);
            cboConsulta.Name = "cboConsulta";
            cboConsulta.Size = new Size(158, 23);
            cboConsulta.TabIndex = 1;
            cboConsulta.SelectedIndexChanged += cboConsulta_SelectedIndexChanged;
            // 
            // txtSentencia
            // 
            txtSentencia.Location = new Point(26, 97);
            txtSentencia.MinimumSize = new Size(0, 200);
            txtSentencia.Multiline = true;
            txtSentencia.Name = "txtSentencia";
            txtSentencia.Size = new Size(250, 200);
            txtSentencia.TabIndex = 2;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(26, 350);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(809, 203);
            dgvConsulta.TabIndex = 4;
            // 
            // txtSql
            // 
            txtSql.Location = new Point(282, 97);
            txtSql.MinimumSize = new Size(0, 200);
            txtSql.Multiline = true;
            txtSql.Name = "txtSql";
            txtSql.Size = new Size(553, 200);
            txtSql.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 320);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 6;
            label2.Text = "Nada:";
            // 
            // txtP1
            // 
            txtP1.Location = new Point(94, 315);
            txtP1.Multiline = true;
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(154, 29);
            txtP1.TabIndex = 7;
            // 
            // txtP2
            // 
            txtP2.Location = new Point(378, 315);
            txtP2.Multiline = true;
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(154, 29);
            txtP2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(310, 320);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 8;
            label3.Text = "Nada:";
            // 
            // button1
            // 
            button1.Location = new Point(663, 318);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 10;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 562);
            Controls.Add(button1);
            Controls.Add(txtP2);
            Controls.Add(label3);
            Controls.Add(txtP1);
            Controls.Add(label2);
            Controls.Add(txtSql);
            Controls.Add(dgvConsulta);
            Controls.Add(txtSentencia);
            Controls.Add(cboConsulta);
            Controls.Add(label1);
            Name = "FrmConsulta";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboConsulta;
        private TextBox txtSentencia;
        private DataGridView dgvConsulta;
        private TextBox txtSql;
        private Label label2;
        private TextBox txtP1;
        private TextBox txtP2;
        private Label label3;
        private Button button1;
    }
}