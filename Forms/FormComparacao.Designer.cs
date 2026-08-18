namespace ScoutSport.Forms
{
    partial class FormComparacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComparacao));
            cmbJogador1 = new ComboBox();
            cmbJogador2 = new ComboBox();
            dgvComparacao = new DataGridView();
            btnComparar = new Button();
            btnFechar = new Button();
            lblComparar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComparacao).BeginInit();
            SuspendLayout();
            // 
            // cmbJogador1
            // 
            cmbJogador1.FormattingEnabled = true;
            cmbJogador1.Location = new Point(131, 67);
            cmbJogador1.Name = "cmbJogador1";
            cmbJogador1.Size = new Size(151, 28);
            cmbJogador1.TabIndex = 0;
            // 
            // cmbJogador2
            // 
            cmbJogador2.FormattingEnabled = true;
            cmbJogador2.Location = new Point(515, 67);
            cmbJogador2.Name = "cmbJogador2";
            cmbJogador2.Size = new Size(151, 28);
            cmbJogador2.TabIndex = 1;
            // 
            // dgvComparacao
            // 
            dgvComparacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComparacao.Location = new Point(12, 158);
            dgvComparacao.Name = "dgvComparacao";
            dgvComparacao.RowHeadersWidth = 51;
            dgvComparacao.Size = new Size(875, 260);
            dgvComparacao.TabIndex = 2;
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(349, 67);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(94, 29);
            btnComparar.TabIndex = 3;
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(628, 442);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblComparar
            // 
            lblComparar.AutoSize = true;
            lblComparar.Font = new Font("Segoe UI", 14F);
            lblComparar.ForeColor = Color.Turquoise;
            lblComparar.Location = new Point(349, 9);
            lblComparar.Name = "lblComparar";
            lblComparar.Size = new Size(78, 32);
            lblComparar.TabIndex = 5;
            lblComparar.Text = "label1";
            // 
            // FormComparacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(899, 483);
            Controls.Add(lblComparar);
            Controls.Add(btnFechar);
            Controls.Add(btnComparar);
            Controls.Add(dgvComparacao);
            Controls.Add(cmbJogador2);
            Controls.Add(cmbJogador1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormComparacao";
            Text = "ScoutSport";
            ((System.ComponentModel.ISupportInitialize)dgvComparacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbJogador1;
        private ComboBox cmbJogador2;
        private DataGridView dgvComparacao;
        private Button btnComparar;
        private Button btnFechar;
        private Label lblComparar;
    }
}