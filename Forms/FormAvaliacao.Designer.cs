namespace ScoutSport.Forms
{
    partial class FormAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvaliacao));
            lblTecnica = new Label();
            lblVelocidade = new Label();
            lblInteligencia = new Label();
            lblFisico = new Label();
            lblAtitude = new Label();
            lblNotaFinal = new Label();
            cmbObservacao = new ComboBox();
            lblPotencial = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            btnCalcular = new Button();
            dgvAvaliacao = new DataGridView();
            txtTecnica = new TextBox();
            txtVelocidade = new TextBox();
            txtFisico = new TextBox();
            txtInteligencia = new TextBox();
            txtAtitude = new TextBox();
            txtPotencial = new TextBox();
            txtNotaFinal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAvaliacao).BeginInit();
            SuspendLayout();
            // 
            // lblTecnica
            // 
            lblTecnica.AutoSize = true;
            lblTecnica.ForeColor = Color.Yellow;
            lblTecnica.Location = new Point(12, 85);
            lblTecnica.Name = "lblTecnica";
            lblTecnica.Size = new Size(58, 20);
            lblTecnica.TabIndex = 0;
            lblTecnica.Text = "Tecnica";
            // 
            // lblVelocidade
            // 
            lblVelocidade.AutoSize = true;
            lblVelocidade.ForeColor = Color.Yellow;
            lblVelocidade.Location = new Point(12, 114);
            lblVelocidade.Name = "lblVelocidade";
            lblVelocidade.Size = new Size(83, 20);
            lblVelocidade.TabIndex = 1;
            lblVelocidade.Text = "Velocidade";
            // 
            // lblInteligencia
            // 
            lblInteligencia.AutoSize = true;
            lblInteligencia.ForeColor = Color.Yellow;
            lblInteligencia.Location = new Point(12, 172);
            lblInteligencia.Name = "lblInteligencia";
            lblInteligencia.Size = new Size(128, 20);
            lblInteligencia.TabIndex = 2;
            lblInteligencia.Text = "Inteligencia Tatica";
            // 
            // lblFisico
            // 
            lblFisico.AutoSize = true;
            lblFisico.ForeColor = Color.Yellow;
            lblFisico.Location = new Point(12, 143);
            lblFisico.Name = "lblFisico";
            lblFisico.Size = new Size(46, 20);
            lblFisico.TabIndex = 3;
            lblFisico.Text = "Fisico";
            // 
            // lblAtitude
            // 
            lblAtitude.AutoSize = true;
            lblAtitude.ForeColor = Color.Yellow;
            lblAtitude.Location = new Point(12, 202);
            lblAtitude.Name = "lblAtitude";
            lblAtitude.Size = new Size(58, 20);
            lblAtitude.TabIndex = 4;
            lblAtitude.Text = "Atitude";
            // 
            // lblNotaFinal
            // 
            lblNotaFinal.AutoSize = true;
            lblNotaFinal.ForeColor = Color.Yellow;
            lblNotaFinal.Location = new Point(14, 273);
            lblNotaFinal.Name = "lblNotaFinal";
            lblNotaFinal.Size = new Size(77, 20);
            lblNotaFinal.TabIndex = 5;
            lblNotaFinal.Text = "Nota Final";
            // 
            // cmbObservacao
            // 
            cmbObservacao.FormattingEnabled = true;
            cmbObservacao.Location = new Point(12, 28);
            cmbObservacao.Name = "cmbObservacao";
            cmbObservacao.Size = new Size(151, 28);
            cmbObservacao.TabIndex = 6;
            cmbObservacao.Text = "Observações";
            // 
            // lblPotencial
            // 
            lblPotencial.AutoSize = true;
            lblPotencial.ForeColor = Color.Yellow;
            lblPotencial.Location = new Point(12, 235);
            lblPotencial.Name = "lblPotencial";
            lblPotencial.Size = new Size(69, 20);
            lblPotencial.TabIndex = 7;
            lblPotencial.Text = "Potencial";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(14, 312);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(14, 362);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(140, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(140, 362);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(694, 409);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(187, 27);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // dgvAvaliacao
            // 
            dgvAvaliacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvaliacao.Location = new Point(287, 52);
            dgvAvaliacao.Name = "dgvAvaliacao";
            dgvAvaliacao.RowHeadersWidth = 51;
            dgvAvaliacao.Size = new Size(765, 339);
            dgvAvaliacao.TabIndex = 14;
            // 
            // txtTecnica
            // 
            txtTecnica.Location = new Point(146, 78);
            txtTecnica.Name = "txtTecnica";
            txtTecnica.Size = new Size(76, 27);
            txtTecnica.TabIndex = 15;
            // 
            // txtVelocidade
            // 
            txtVelocidade.Location = new Point(146, 107);
            txtVelocidade.Name = "txtVelocidade";
            txtVelocidade.Size = new Size(73, 27);
            txtVelocidade.TabIndex = 16;
            // 
            // txtFisico
            // 
            txtFisico.Location = new Point(146, 136);
            txtFisico.Name = "txtFisico";
            txtFisico.Size = new Size(73, 27);
            txtFisico.TabIndex = 17;
            // 
            // txtInteligencia
            // 
            txtInteligencia.Location = new Point(146, 169);
            txtInteligencia.Name = "txtInteligencia";
            txtInteligencia.Size = new Size(73, 27);
            txtInteligencia.TabIndex = 18;
            // 
            // txtAtitude
            // 
            txtAtitude.Location = new Point(146, 199);
            txtAtitude.Name = "txtAtitude";
            txtAtitude.Size = new Size(73, 27);
            txtAtitude.TabIndex = 19;
            // 
            // txtPotencial
            // 
            txtPotencial.Location = new Point(146, 232);
            txtPotencial.Name = "txtPotencial";
            txtPotencial.Size = new Size(73, 27);
            txtPotencial.TabIndex = 20;
            // 
            // txtNotaFinal
            // 
            txtNotaFinal.Location = new Point(146, 266);
            txtNotaFinal.Name = "txtNotaFinal";
            txtNotaFinal.Size = new Size(73, 27);
            txtNotaFinal.TabIndex = 21;
            // 
            // FormAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1064, 450);
            Controls.Add(txtNotaFinal);
            Controls.Add(txtPotencial);
            Controls.Add(txtAtitude);
            Controls.Add(txtInteligencia);
            Controls.Add(txtFisico);
            Controls.Add(txtVelocidade);
            Controls.Add(txtTecnica);
            Controls.Add(dgvAvaliacao);
            Controls.Add(btnCalcular);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(lblPotencial);
            Controls.Add(cmbObservacao);
            Controls.Add(lblNotaFinal);
            Controls.Add(lblAtitude);
            Controls.Add(lblFisico);
            Controls.Add(lblInteligencia);
            Controls.Add(lblVelocidade);
            Controls.Add(lblTecnica);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAvaliacao";
            Text = "Volta Redonda Futebol Clube";
            ((System.ComponentModel.ISupportInitialize)dgvAvaliacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTecnica;
        private Label lblVelocidade;
        private Label lblInteligencia;
        private Label lblFisico;
        private Label lblAtitude;
        private Label lblNotaFinal;
        private ComboBox cmbObservacao;
        private Label lblPotencial;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnExcluir;
        private Button btnFechar;
        private Button btnCalcular;
        private DataGridView dgvAvaliacao;
        private TextBox txtTecnica;
        private TextBox txtVelocidade;
        private TextBox txtFisico;
        private TextBox txtInteligencia;
        private TextBox txtAtitude;
        private TextBox txtPotencial;
        private TextBox txtNotaFinal;
    }
}