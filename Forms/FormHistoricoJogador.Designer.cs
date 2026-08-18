namespace ScoutSport.Forms
{
    partial class FormHistoricoJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoJogador));
            lblTitulo = new Label();
            cmbJogador = new ComboBox();
            btnPesquisar = new Button();
            btnFechar = new Button();
            dgvHistoricoObservacao = new DataGridView();
            dgvHistoricoAvaliacao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoObservacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAvaliacao).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.Turquoise;
            lblTitulo.Location = new Point(427, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(78, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // cmbJogador
            // 
            cmbJogador.FormattingEnabled = true;
            cmbJogador.Location = new Point(12, 14);
            cmbJogador.Name = "cmbJogador";
            cmbJogador.Size = new Size(151, 28);
            cmbJogador.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(12, 395);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(12, 440);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // dgvHistoricoObservacao
            // 
            dgvHistoricoObservacao.AllowUserToOrderColumns = true;
            dgvHistoricoObservacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoObservacao.Location = new Point(163, 56);
            dgvHistoricoObservacao.Name = "dgvHistoricoObservacao";
            dgvHistoricoObservacao.RowHeadersWidth = 51;
            dgvHistoricoObservacao.Size = new Size(806, 188);
            dgvHistoricoObservacao.TabIndex = 4;
            // 
            // dgvHistoricoAvaliacao
            // 
            dgvHistoricoAvaliacao.AllowUserToOrderColumns = true;
            dgvHistoricoAvaliacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoAvaliacao.Location = new Point(163, 271);
            dgvHistoricoAvaliacao.Name = "dgvHistoricoAvaliacao";
            dgvHistoricoAvaliacao.RowHeadersWidth = 51;
            dgvHistoricoAvaliacao.Size = new Size(806, 188);
            dgvHistoricoAvaliacao.TabIndex = 5;
            // 
            // FormHistoricoJogador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(981, 481);
            Controls.Add(dgvHistoricoAvaliacao);
            Controls.Add(dgvHistoricoObservacao);
            Controls.Add(btnFechar);
            Controls.Add(btnPesquisar);
            Controls.Add(cmbJogador);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHistoricoJogador";
            Text = "Volta Redonda Futebol Clube";
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoObservacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAvaliacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbJogador;
        private Button btnPesquisar;
        private Button btnFechar;
        private DataGridView dgvHistoricoObservacao;
        private DataGridView dgvHistoricoAvaliacao;
    }
}