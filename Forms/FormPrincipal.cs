using Microsoft.Data.SqlClient;
using ScoutSport.Data;
using ScoutSport.Forms;
using System;

namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            lblTitulo.Text = "ScoutSport";
            //lblVoltaco.Text = "Voltaço";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "ScoutSport";
        }

        private void clubesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClubes formClubes = new FormClubes();
            formClubes.ShowDialog();
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJogador formJogador = new FormJogador();
            formJogador.ShowDialog();
        }

        private void observaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormObservacao formObservacao = new FormObservacao();
            formObservacao.ShowDialog();
        }

        private void avaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAvaliacao formAvaliacao = new FormAvaliacao();
            formAvaliacao.ShowDialog();
        }

        private void lblVoltaco_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FormHistoricoJogador historico = new FormHistoricoJogador();
            historico.ShowDialog();
        }

        private void btnComparacao_Click(object sender, EventArgs e)
        {
            FormComparacao fc = new FormComparacao();
            fc.ShowDialog();
        }

        private void ptbVoltaco_Click(object sender, EventArgs e)
        {

        }
    }
}
