using ScoutSport.Data;
using ScoutSport.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScoutSport.Forms
{
    public partial class FormObservacao : Form
    {
        public FormObservacao()
        {
            InitializeComponent();
            // Configurações iniciais do DataGridView e carregamento de dados
            ConfigurarDgvObservacao();
            CarregarComboJogadores();
            CarregarDgvObservacao();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            { //verifica se os campos obrigatórios estão preenchidos antes de guardar a observação.
                if (!ValidarCampos())
                    return;

                Observacao observacao = new Observacao();

                observacao.JogadorId = Convert.ToInt32(cmbJogador.SelectedValue);
                observacao.DataObservacao = dtpObservacao.Value;
                observacao.Adversario = txtAdversario.Text.Trim();
                observacao.Competicao = txtCompeticao.Text.Trim();
                observacao.PosicaoObservada = txtPosicao.Text.Trim();
                observacao.Comentario = txtComentario.Text.Trim();
                // vai adicionar a nova observação a base de dados e salvar as alterações.
                db.Observacoes.Add(observacao);
                db.SaveChanges();
                // uma mensagem de sucesso é exibida.
                MessageBox.Show("Observação guardada com sucesso.");
                CarregarDgvObservacao();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao guardar a observação: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            
            try
            {
                if (dgvObservacao.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma observação na grelha para editar.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                int idSelecionado = Convert.ToInt32(dgvObservacao.SelectedRows[0].Cells["Id"].Value);

                Observacao? observacao = db.Observacoes.Find(idSelecionado);

                if (observacao == null)
                {
                    MessageBox.Show("Observação não encontrada.");
                    return;
                }

                observacao.JogadorId = Convert.ToInt32(cmbJogador.SelectedValue);
                observacao.DataObservacao = dtpObservacao.Value;
                observacao.Adversario = txtAdversario.Text.Trim();
                observacao.Competicao = txtCompeticao.Text.Trim();
                observacao.PosicaoObservada = txtPosicao.Text.Trim();
                observacao.Comentario = txtComentario.Text.Trim();

                db.SaveChanges();

                MessageBox.Show("Observação editada com sucesso.");
                CarregarDgvObservacao();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar a observação: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (dgvObservacao.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma observação na grelha para excluir.");
                    return;
                }

                DialogResult resposta = MessageBox.Show(
                    "Tem certeza que deseja excluir esta observação?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta != DialogResult.Yes)
                    return;

                int idSelecionado = Convert.ToInt32(dgvObservacao.SelectedRows[0].Cells["Id"].Value);

                Observacao? observacao = db.Observacoes.Find(idSelecionado);

                if (observacao == null)
                {
                    MessageBox.Show("Observação não encontrada.");
                    return;
                }

                db.Observacoes.Remove(observacao);
                db.SaveChanges();

                MessageBox.Show("Observação excluída com sucesso.");
                CarregarDgvObservacao();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir a observação: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            cmbJogador.SelectedIndex = -1;
            dtpObservacao.Value = DateTime.Today;
            txtAdversario.Clear();
            txtCompeticao.Clear();
            txtPosicao.Clear();
            txtComentario.Clear();
            cmbJogador.Focus();
        }

        private bool ValidarCampos()
        {
            if (cmbJogador.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogador.");
                cmbJogador.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAdversario.Text))
            {
                MessageBox.Show("O adversário é obrigatório.");
                txtAdversario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCompeticao.Text))
            {
                MessageBox.Show("A competição é obrigatória.");
                txtCompeticao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPosicao.Text))
            {
                MessageBox.Show("A posição observada é obrigatória.");
                txtPosicao.Focus();
                return false;
            }

            return true;
        }

        private void CarregarDgvObservacao()
        {
            using var db = new AppDbContext();

            try
            {
                dgvObservacao.DataSource = null;

                var lista = from o in db.Observacoes
                            join j in db.Jogadores on o.JogadorId equals j.Id
                            select new
                            {
                                o.Id,
                                Jogador = j.Nome,
                                o.DataObservacao,
                                o.Adversario,
                                o.Competicao,
                                o.PosicaoObservada,
                                o.Comentario
                            };

                dgvObservacao.DataSource = lista.ToList();

                dgvObservacao.Columns["Id"]?.HeaderText = "ID";
                dgvObservacao.Columns["Jogador"]?.HeaderText = "Jogador";
                dgvObservacao.Columns["DataObservacao"]?.HeaderText = "Data Observação";
                dgvObservacao.Columns["Adversario"]?.HeaderText = "Adversário";
                dgvObservacao.Columns["Competicao"]?.HeaderText = "Competição";
                dgvObservacao.Columns["PosicaoObservada"]?.HeaderText = "Posição Observada";
                dgvObservacao.Columns["Comentario"]?.HeaderText = "Comentário";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as observações: " + ex.Message);
            }
        }

        private void CarregarComboJogadores()
        {
            using var db = new AppDbContext();

            try
            {
                var jogadores = db.Jogadores
                    .Select(j => new { j.Id, j.Nome })
                    .ToList();

                cmbJogador.DataSource = jogadores;
                cmbJogador.DisplayMember = "Nome";
                cmbJogador.ValueMember = "Id";
                cmbJogador.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os jogadores: " + ex.Message);
            }
        }

        private void dgvObservacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using var db = new AppDbContext();

                int idSelecionado = Convert.ToInt32(dgvObservacao.Rows[e.RowIndex].Cells["Id"].Value);

                Observacao? observacao = db.Observacoes.Find(idSelecionado);

                if (observacao != null)
                {
                    cmbJogador.SelectedValue = observacao.JogadorId;
                    dtpObservacao.Value = observacao.DataObservacao;
                    txtAdversario.Text = observacao.Adversario ?? "";
                    txtCompeticao.Text = observacao.Competicao ?? "";
                    txtPosicao.Text = observacao.PosicaoObservada ?? "";
                    txtComentario.Text = observacao.Comentario ?? "";
                }
            }
        }

        private void ConfigurarDgvObservacao()
        {
            dgvObservacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObservacao.ReadOnly = true;
            dgvObservacao.AllowUserToAddRows = false;
            dgvObservacao.AllowUserToDeleteRows = false;
            dgvObservacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObservacao.MultiSelect = false;
        }
    }
}