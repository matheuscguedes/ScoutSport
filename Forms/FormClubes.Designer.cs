namespace ScoutSport.Forms
{
    partial class FormClubes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClubes));
            txtNome = new TextBox();
            txtPais = new TextBox();
            txtCidade = new TextBox();
            btnNovo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            lblNome = new Label();
            lblCidade = new Label();
            lblPais = new Label();
            dgvClube = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClube).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(75, 119);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(125, 27);
            txtPais.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(75, 165);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(125, 27);
            txtCidade.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 215);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(112, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(6, 292);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(112, 292);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(694, 450);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.Yellow;
            lblNome.Location = new Point(12, 79);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome: ";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.ForeColor = Color.Yellow;
            lblCidade.Location = new Point(6, 172);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(63, 20);
            lblCidade.TabIndex = 9;
            lblCidade.Text = "Cidade: ";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.ForeColor = Color.Yellow;
            lblPais.Location = new Point(12, 126);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(41, 20);
            lblPais.TabIndex = 10;
            lblPais.Text = "Pais: ";
            // 
            // dgvClube
            // 
            dgvClube.AllowUserToAddRows = false;
            dgvClube.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClube.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClube.Location = new Point(228, 76);
            dgvClube.MultiSelect = false;
            dgvClube.Name = "dgvClube";
            dgvClube.ReadOnly = true;
            dgvClube.RowHeadersWidth = 51;
            dgvClube.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClube.Size = new Size(560, 368);
            dgvClube.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.LawnGreen;
            lblTitulo.Location = new Point(324, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(86, 32);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Clubes";
            // 
            // FormClubes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(821, 491);
            Controls.Add(lblTitulo);
            Controls.Add(dgvClube);
            Controls.Add(lblPais);
            Controls.Add(lblCidade);
            Controls.Add(lblNome);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNovo);
            Controls.Add(txtCidade);
            Controls.Add(txtPais);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormClubes";
            Text = "Volta Redonda Futebol Clube";
            ((System.ComponentModel.ISupportInitialize)dgvClube).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPais;
        private TextBox txtCidade;
        private Button btnNovo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnFechar;
        private Label lblNome;
        private Label lblCidade;
        private Label lblPais;
        private DataGridView dgvClube;
        private Label lblTitulo;
        //private DataGridViewCellEventHandler dgvClube_CellContentClick;
    }
}