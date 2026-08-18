using ScoutSport.Data;

namespace ScoutSport.Forms
{
    public partial class FormHistoricoJogador : Form
    {
        public FormHistoricoJogador()
        {
            InitializeComponent();
            lblTitulo.Text = "Histórico do Jogador";
            ConfigurarDgvAvaliacao();
            ConfigurarDgvObservacao();
            CarregarJogadores();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbJogador.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um jogador.");
                    cmbJogador.Focus();
                    return;
                }

                CarregarHistoricoJogador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar o histórico do jogador: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarHistoricoJogador()
        {
            using var db = new AppDbContext();

            try
            {
                int idJogador = Convert.ToInt32(cmbJogador.SelectedValue);

                var observacoes = from o in db.Observacoes
                                  join j in db.Jogadores on o.JogadorId equals j.Id
                                  where o.JogadorId == idJogador
                                  orderby o.DataObservacao descending
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

                dgvHistoricoObservacao.DataSource = observacoes.ToList();

                dgvHistoricoObservacao.Columns["Id"]?.HeaderText = "ID";
                dgvHistoricoObservacao.Columns["Jogador"]?.HeaderText = "Jogador";
                dgvHistoricoObservacao.Columns["DataObservacao"]?.HeaderText = "Data Observação";
                dgvHistoricoObservacao.Columns["Adversario"]?.HeaderText = "Adversário";
                dgvHistoricoObservacao.Columns["Competicao"]?.HeaderText = "Competição";
                dgvHistoricoObservacao.Columns["PosicaoObservada"]?.HeaderText = "Posição Observada";
                dgvHistoricoObservacao.Columns["Comentario"]?.HeaderText = "Comentário";

                var avaliacoes = from a in db.Avaliacoes
                                 join o in db.Observacoes on a.ObservacaoId equals o.Id
                                 join j in db.Jogadores on o.JogadorId equals j.Id
                                 where o.JogadorId == idJogador
                                 orderby o.DataObservacao descending
                                 select new
                                 {
                                     a.Id,
                                     Jogador = j.Nome,
                                     o.DataObservacao,
                                     o.Adversario,
                                     a.Tecnica,
                                     a.Velocidade,
                                     a.InteligenciaTatica,
                                     a.Fisico,
                                     a.Atitude,
                                     a.NotaFinal,
                                     a.Potencial
                                 };

                dgvHistoricoAvaliacao.DataSource = avaliacoes.ToList();

                dgvHistoricoAvaliacao.Columns["Id"]?.HeaderText = "ID";
                dgvHistoricoAvaliacao.Columns["Jogador"]?.HeaderText = "Jogador";
                dgvHistoricoAvaliacao.Columns["DataObservacao"]?.HeaderText = "Data Observação";
                dgvHistoricoAvaliacao.Columns["Adversario"]?.HeaderText = "Adversário";
                dgvHistoricoAvaliacao.Columns["Tecnica"]?.HeaderText = "Técnica";
                dgvHistoricoAvaliacao.Columns["Velocidade"]?.HeaderText = "Velocidade";
                dgvHistoricoAvaliacao.Columns["InteligenciaTatica"]?.HeaderText = "Inteligência Tática";
                dgvHistoricoAvaliacao.Columns["Fisico"]?.HeaderText = "Físico";
                dgvHistoricoAvaliacao.Columns["Atitude"]?.HeaderText = "Atitude";
                dgvHistoricoAvaliacao.Columns["NotaFinal"]?.HeaderText = "Nota Final";
                dgvHistoricoAvaliacao.Columns["Potencial"]?.HeaderText = "Potencial";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar o histórico do jogador: " + ex.Message);
            }
        }

        private void ConfigurarDgvAvaliacao()
        {
            dgvHistoricoAvaliacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoricoAvaliacao.ReadOnly = true;
            dgvHistoricoAvaliacao.AllowUserToAddRows = false;
            dgvHistoricoAvaliacao.AllowUserToDeleteRows = false;
            dgvHistoricoAvaliacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistoricoAvaliacao.MultiSelect = false;
        }

        private void ConfigurarDgvObservacao()
        {
            dgvHistoricoObservacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoricoObservacao.ReadOnly = true;
            dgvHistoricoObservacao.AllowUserToAddRows = false;
            dgvHistoricoObservacao.AllowUserToDeleteRows = false;
            dgvHistoricoObservacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistoricoObservacao.MultiSelect = false;
        }

        private void CarregarJogadores()
        {
            using var db = new AppDbContext();

            try
            {
                cmbJogador.DataSource = null;
                cmbJogador.DataSource = db.Jogadores.ToList();
                cmbJogador.DisplayMember = "Nome";
                cmbJogador.ValueMember = "Id";
                cmbJogador.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os jogadores: " + ex.Message);
            }
        }
    }
}