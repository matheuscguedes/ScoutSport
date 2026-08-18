namespace WinFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnSair = new Button();
            menuStrip1 = new MenuStrip();
            clubesToolStripMenuItem = new ToolStripMenuItem();
            jogadoresToolStripMenuItem = new ToolStripMenuItem();
            observaçõesToolStripMenuItem = new ToolStripMenuItem();
            avaliaçõesToolStripMenuItem = new ToolStripMenuItem();
            lblTitulo = new Label();
            lblVoltaco = new Label();
            btnHistorico = new Button();
            btnComparacao = new Button();
            ptbVoltaco = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbVoltaco).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(25, 384);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LawnGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clubesToolStripMenuItem, jogadoresToolStripMenuItem, observaçõesToolStripMenuItem, avaliaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clubesToolStripMenuItem
            // 
            clubesToolStripMenuItem.Name = "clubesToolStripMenuItem";
            clubesToolStripMenuItem.Size = new Size(67, 24);
            clubesToolStripMenuItem.Text = "Clubes";
            clubesToolStripMenuItem.Click += clubesToolStripMenuItem_Click;
            // 
            // jogadoresToolStripMenuItem
            // 
            jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            jogadoresToolStripMenuItem.Size = new Size(91, 24);
            jogadoresToolStripMenuItem.Text = "Jogadores";
            jogadoresToolStripMenuItem.Click += jogadoresToolStripMenuItem_Click;
            // 
            // observaçõesToolStripMenuItem
            // 
            observaçõesToolStripMenuItem.Name = "observaçõesToolStripMenuItem";
            observaçõesToolStripMenuItem.Size = new Size(105, 24);
            observaçõesToolStripMenuItem.Text = "observações";
            observaçõesToolStripMenuItem.Click += observaçõesToolStripMenuItem_Click;
            // 
            // avaliaçõesToolStripMenuItem
            // 
            avaliaçõesToolStripMenuItem.Name = "avaliaçõesToolStripMenuItem";
            avaliaçõesToolStripMenuItem.Size = new Size(94, 24);
            avaliaçõesToolStripMenuItem.Text = "Avaliações";
            avaliaçõesToolStripMenuItem.Click += avaliaçõesToolStripMenuItem_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(277, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 34);
            lblTitulo.TabIndex = 2;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblVoltaco
            // 
            lblVoltaco.AutoSize = true;
            lblVoltaco.BackColor = Color.Yellow;
            lblVoltaco.Location = new Point(319, 260);
            lblVoltaco.Name = "lblVoltaco";
            lblVoltaco.Size = new Size(0, 20);
            lblVoltaco.TabIndex = 3;
            lblVoltaco.Click += lblVoltaco_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.Turquoise;
            btnHistorico.Location = new Point(25, 280);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(106, 29);
            btnHistorico.TabIndex = 4;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnComparacao
            // 
            btnComparacao.BackColor = Color.Turquoise;
            btnComparacao.Location = new Point(25, 215);
            btnComparacao.Name = "btnComparacao";
            btnComparacao.Size = new Size(106, 29);
            btnComparacao.TabIndex = 5;
            btnComparacao.Text = "Comparação";
            btnComparacao.UseVisualStyleBackColor = false;
            btnComparacao.Click += btnComparacao_Click;
            // 
            // ptbVoltaco
            // 
            ptbVoltaco.Image = (Image)resources.GetObject("ptbVoltaco.Image");
            ptbVoltaco.InitialImage = (Image)resources.GetObject("ptbVoltaco.InitialImage");
            ptbVoltaco.Location = new Point(290, 50);
            ptbVoltaco.Name = "ptbVoltaco";
            ptbVoltaco.Size = new Size(397, 363);
            ptbVoltaco.SizeMode = PictureBoxSizeMode.Zoom;
            ptbVoltaco.TabIndex = 6;
            ptbVoltaco.TabStop = false;
            ptbVoltaco.Click += ptbVoltaco_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(ptbVoltaco);
            Controls.Add(btnComparacao);
            Controls.Add(btnHistorico);
            Controls.Add(lblVoltaco);
            Controls.Add(lblTitulo);
            Controls.Add(btnSair);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "ScoutSport";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbVoltaco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clubesToolStripMenuItem;
        private ToolStripMenuItem jogadoresToolStripMenuItem;
        private ToolStripMenuItem observaçõesToolStripMenuItem;
        private ToolStripMenuItem avaliaçõesToolStripMenuItem;
        private Label lblTitulo;
        private Label lblVoltaco;
        private Button btnHistorico;
        private Button btnComparacao;
        private PictureBox ptbVoltaco;
    }
}
