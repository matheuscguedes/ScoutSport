namespace ScoutSport.Forms
{
    partial class FormJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogador));
            lblTitulo = new Label();
            lblClube = new Label();
            lblNome = new Label();
            lblDataNasc = new Label();
            lblNacionalidade = new Label();
            lblPosicao = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            txtNome = new TextBox();
            cmbClube = new ComboBox();
            dtpNascimento = new DateTimePicker();
            txtNacionalidade = new TextBox();
            txtPosicao = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            dgvJogador = new DataGridView();
            btnNovo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJogador).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(318, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 20);
            lblTitulo.TabIndex = 0;
            // 
            // lblClube
            // 
            lblClube.AutoSize = true;
            lblClube.ForeColor = Color.Yellow;
            lblClube.Location = new Point(26, 80);
            lblClube.Name = "lblClube";
            lblClube.Size = new Size(47, 20);
            lblClube.TabIndex = 1;
            lblClube.Text = "Clube";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.Yellow;
            lblNome.Location = new Point(26, 113);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.ForeColor = Color.Yellow;
            lblDataNasc.Location = new Point(3, 156);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(124, 20);
            lblDataNasc.TabIndex = 3;
            lblDataNasc.Text = "Data Nascimento";
            // 
            // lblNacionalidade
            // 
            lblNacionalidade.AutoSize = true;
            lblNacionalidade.ForeColor = Color.Yellow;
            lblNacionalidade.Location = new Point(12, 191);
            lblNacionalidade.Name = "lblNacionalidade";
            lblNacionalidade.Size = new Size(106, 20);
            lblNacionalidade.TabIndex = 4;
            lblNacionalidade.Text = "Nacionalidade";
            // 
            // lblPosicao
            // 
            lblPosicao.AutoSize = true;
            lblPosicao.ForeColor = Color.Yellow;
            lblPosicao.Location = new Point(17, 225);
            lblPosicao.Name = "lblPosicao";
            lblPosicao.Size = new Size(59, 20);
            lblPosicao.TabIndex = 5;
            lblPosicao.Text = "Posição";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.ForeColor = Color.Yellow;
            lblAltura.Location = new Point(24, 256);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(49, 20);
            lblAltura.TabIndex = 6;
            lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.ForeColor = Color.Yellow;
            lblPeso.Location = new Point(26, 292);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(39, 20);
            lblPeso.TabIndex = 7;
            lblPeso.Text = "Peso";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(151, 27);
            txtNome.TabIndex = 8;
            // 
            // cmbClube
            // 
            cmbClube.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClube.FormattingEnabled = true;
            cmbClube.Location = new Point(97, 77);
            cmbClube.Name = "cmbClube";
            cmbClube.Size = new Size(151, 28);
            cmbClube.TabIndex = 9;
            cmbClube.SelectedIndexChanged += cmbClube_SelectedIndexChanged;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(133, 151);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(115, 27);
            dtpNascimento.TabIndex = 10;
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(124, 191);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(125, 27);
            txtNacionalidade.TabIndex = 11;
            // 
            // txtPosicao
            // 
            txtPosicao.Location = new Point(123, 222);
            txtPosicao.Name = "txtPosicao";
            txtPosicao.Size = new Size(125, 27);
            txtPosicao.TabIndex = 12;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(123, 256);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 13;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(123, 289);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 14;
            // 
            // dgvJogador
            // 
            dgvJogador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogador.Location = new Point(269, 59);
            dgvJogador.Name = "dgvJogador";
            dgvJogador.RowHeadersWidth = 51;
            dgvJogador.Size = new Size(810, 348);
            dgvJogador.TabIndex = 15;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 324);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 16;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(138, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 409);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(132, 409);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(684, 413);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 20;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormJogador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1091, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNovo);
            Controls.Add(dgvJogador);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtPosicao);
            Controls.Add(txtNacionalidade);
            Controls.Add(dtpNascimento);
            Controls.Add(cmbClube);
            Controls.Add(txtNome);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblPosicao);
            Controls.Add(lblNacionalidade);
            Controls.Add(lblDataNasc);
            Controls.Add(lblNome);
            Controls.Add(lblClube);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormJogador";
            Text = "ScoutSport";
            ((System.ComponentModel.ISupportInitialize)dgvJogador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblClube;
        private Label lblNome;
        private Label lblDataNasc;
        private Label lblNacionalidade;
        private Label lblPosicao;
        private Label lblAltura;
        private Label lblPeso;
        private TextBox txtNome;
        private ComboBox cmbClube;
        private DateTimePicker dtpNascimento;
        private TextBox txtNacionalidade;
        private TextBox txtPosicao;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private DataGridView dgvJogador;
        private Button btnNovo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnFechar;
    }
}