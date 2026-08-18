namespace ScoutSport.Forms
{
    partial class FormObservacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObservacao));
            lblJogador = new Label();
            lblPosicao = new Label();
            lblAdversario = new Label();
            lblCompeticao = new Label();
            lblComentario = new Label();
            btnNovo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            txtPosicao = new TextBox();
            txtAdversario = new TextBox();
            txtCompeticao = new TextBox();
            txtComentario = new TextBox();
            dgvObservacao = new DataGridView();
            cmbJogador = new ComboBox();
            dtpObservacao = new DateTimePicker();
            lblDataObservacao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvObservacao).BeginInit();
            SuspendLayout();
            // 
            // lblJogador
            // 
            lblJogador.AutoSize = true;
            lblJogador.ForeColor = Color.Yellow;
            lblJogador.Location = new Point(21, 73);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(63, 20);
            lblJogador.TabIndex = 0;
            lblJogador.Text = "Jogador";
            // 
            // lblPosicao
            // 
            lblPosicao.AutoSize = true;
            lblPosicao.ForeColor = Color.Yellow;
            lblPosicao.Location = new Point(21, 110);
            lblPosicao.Name = "lblPosicao";
            lblPosicao.Size = new Size(59, 20);
            lblPosicao.TabIndex = 1;
            lblPosicao.Text = "Posição";
            // 
            // lblAdversario
            // 
            lblAdversario.AutoSize = true;
            lblAdversario.ForeColor = Color.Yellow;
            lblAdversario.Location = new Point(12, 143);
            lblAdversario.Name = "lblAdversario";
            lblAdversario.Size = new Size(80, 20);
            lblAdversario.TabIndex = 2;
            lblAdversario.Text = "Adversario";
            // 
            // lblCompeticao
            // 
            lblCompeticao.AutoSize = true;
            lblCompeticao.ForeColor = Color.Yellow;
            lblCompeticao.Location = new Point(12, 176);
            lblCompeticao.Name = "lblCompeticao";
            lblCompeticao.Size = new Size(90, 20);
            lblCompeticao.TabIndex = 3;
            lblCompeticao.Text = "Competição";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.ForeColor = Color.Yellow;
            lblComentario.Location = new Point(17, 216);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(87, 20);
            lblComentario.TabIndex = 4;
            lblComentario.Text = "Comentario";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(17, 339);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(146, 339);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(17, 423);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(147, 423);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(746, 451);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtPosicao
            // 
            txtPosicao.Location = new Point(110, 103);
            txtPosicao.Name = "txtPosicao";
            txtPosicao.Size = new Size(125, 27);
            txtPosicao.TabIndex = 11;
            // 
            // txtAdversario
            // 
            txtAdversario.Location = new Point(110, 136);
            txtAdversario.Name = "txtAdversario";
            txtAdversario.Size = new Size(125, 27);
            txtAdversario.TabIndex = 12;
            // 
            // txtCompeticao
            // 
            txtCompeticao.Location = new Point(108, 169);
            txtCompeticao.Name = "txtCompeticao";
            txtCompeticao.Size = new Size(125, 27);
            txtCompeticao.TabIndex = 13;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(110, 209);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(125, 27);
            txtComentario.TabIndex = 14;
            // 
            // dgvObservacao
            // 
            dgvObservacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObservacao.Location = new Point(275, 61);
            dgvObservacao.Name = "dgvObservacao";
            dgvObservacao.RowHeadersWidth = 51;
            dgvObservacao.Size = new Size(817, 384);
            dgvObservacao.TabIndex = 15;
            // 
            // cmbJogador
            // 
            cmbJogador.FormattingEnabled = true;
            cmbJogador.Location = new Point(90, 69);
            cmbJogador.Name = "cmbJogador";
            cmbJogador.Size = new Size(151, 28);
            cmbJogador.TabIndex = 16;
            // 
            // dtpObservacao
            // 
            dtpObservacao.Format = DateTimePickerFormat.Short;
            dtpObservacao.Location = new Point(123, 251);
            dtpObservacao.Name = "dtpObservacao";
            dtpObservacao.Size = new Size(110, 27);
            dtpObservacao.TabIndex = 17;
            // 
            // lblDataObservacao
            // 
            lblDataObservacao.AutoSize = true;
            lblDataObservacao.ForeColor = Color.Yellow;
            lblDataObservacao.Location = new Point(21, 251);
            lblDataObservacao.Name = "lblDataObservacao";
            lblDataObservacao.Size = new Size(41, 20);
            lblDataObservacao.TabIndex = 18;
            lblDataObservacao.Text = "Data";
            // 
            // FormObservacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1104, 492);
            Controls.Add(lblDataObservacao);
            Controls.Add(dtpObservacao);
            Controls.Add(cmbJogador);
            Controls.Add(dgvObservacao);
            Controls.Add(txtComentario);
            Controls.Add(txtCompeticao);
            Controls.Add(txtAdversario);
            Controls.Add(txtPosicao);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNovo);
            Controls.Add(lblComentario);
            Controls.Add(lblCompeticao);
            Controls.Add(lblAdversario);
            Controls.Add(lblPosicao);
            Controls.Add(lblJogador);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormObservacao";
            Text = "ScoutSport";
            ((System.ComponentModel.ISupportInitialize)dgvObservacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJogador;
        private Label lblPosicao;
        private Label lblAdversario;
        private Label lblCompeticao;
        private Label lblComentario;
        private Button btnNovo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnFechar;
        private TextBox txtPosicao;
        private TextBox txtAdversario;
        private TextBox txtCompeticao;
        private TextBox txtComentario;
        private DataGridView dgvObservacao;
        private ComboBox cmbJogador;
        private DateTimePicker dtpObservacao;
        private Label lblDataObservacao;
    }
}