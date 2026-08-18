using ScoutSport.Data;
using ScoutSport.Models;
using System.Data;

namespace ScoutSport.Forms
{
    public partial class FormComparacao : Form
    {
        public FormComparacao()
        {
            InitializeComponent();
            lblComparar.Text = "Comparação entre Jogadores";

            ConfigurarDgvComparacao();
            CarregarJogadores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {// seleciona o primiro jogador para a comparação
                if (cmbJogador1.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione o primeiro jogador.");
                    cmbJogador1.Focus();
                    return;
                }
                // seleciona o segundo jogador para a comparação
                if (cmbJogador2.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione o segundo jogador.");
                    cmbJogador2.Focus();
                    return;
                }
                // vai converter os valores selecionados para inteiro 
                if (Convert.ToInt32(cmbJogador1.SelectedValue) == Convert.ToInt32(cmbJogador2.SelectedValue))
                {// uma mensagem de erro caso os jogadores selecionados sejam iguais
                    MessageBox.Show("Selecione jogadores diferentes para comparar.");
                    cmbJogador2.Focus();
                    return;
                }

                CompararJogadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao comparar os jogadores: " + ex.Message);
            }
        }
        // metodo para carregar os jogadores para a combobox.
        private void CarregarJogadores()
        {
            using var db = new AppDbContext();

            try
            {// vai buscar a lista de jogadores no banco de dados e atribuir a combobox
                var listaJogadores = db.Jogadores.ToList();
                //lista de jogadores na combobox 1
                cmbJogador1.DataSource = null;
                cmbJogador1.DataSource = listaJogadores;
                cmbJogador1.DisplayMember = "Nome";
                cmbJogador1.ValueMember = "Id";
                cmbJogador1.SelectedIndex = -1;
                //lista de jogadores na combobox 2
                cmbJogador2.DataSource = null;
                cmbJogador2.DataSource = db.Jogadores.ToList();
                cmbJogador2.DisplayMember = "Nome";
                cmbJogador2.ValueMember = "Id";
                cmbJogador2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os jogadores: " + ex.Message);
            }
        }

        private void ConfigurarDgvComparacao()
        {// configurações do DataGridView para comparação
            dgvComparacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComparacao.ReadOnly = true;
            dgvComparacao.AllowUserToAddRows = false;
            dgvComparacao.AllowUserToDeleteRows = false;
            dgvComparacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComparacao.MultiSelect = false;
        }

        private string ObterNomeClube(int? clubeId)
        {// obtém o nome do clube com base no ID
            using var db = new AppDbContext();

            if (clubeId == null)
                return "";

            Clube? clube = db.Clubes.Find(clubeId.Value);

            if (clube == null)
                return "";

            return clube.Nome ?? "";
        }

        private int ContarObservacoes(int idJogador)
        {// conta o número de observações para um jogador específico
            using var db = new AppDbContext();
            return db.Observacoes.Count(o => o.JogadorId == idJogador);
        }

        private int ContarAvaliacoes(int idJogador)
        {// conta o número de avaliações para um jogador específico
            using var db = new AppDbContext();
            //faz um join entre as tabelas avaliações e observações para contar avaliações de um jogador
            return (from a in db.Avaliacoes
                    join o in db.Observacoes on a.ObservacaoId equals o.Id
                    where o.JogadorId == idJogador
                    select a).Count();
        }

        private decimal ObterMediaNotaFinal(int idJogador)
        {// calcula a média da nota final para um jogador específico
            using var db = new AppDbContext();

            var notas = from a in db.Avaliacoes
                        join o in db.Observacoes on a.ObservacaoId equals o.Id
                        where o.JogadorId == idJogador
                        select a.NotaFinal;

            if (!notas.Any()) // se não encontrar nenhuma nota, vai retornar 0 para evitar erro em divisão
                return 0;

            return notas.Average();
        }

        private string ObterUltimoPotencial(int idJogador)
        {// obtém o último potencial registrado para um jogador específico
            using var db = new AppDbContext();

            var potencial = (from a in db.Avaliacoes
                             join o in db.Observacoes on a.ObservacaoId equals o.Id
                             where o.JogadorId == idJogador
                             orderby o.DataObservacao descending
                             select a.Potencial).FirstOrDefault();

            return potencial ?? "Sem avaliação";
        }

        private void CompararJogadores()
        {// método principal para comparar os jogadores selecionados e exibir os resultados no DataGridView
            using var db = new AppDbContext();
            // obtém os IDs dos jogadores selecionados nas comboboxes
            int idJogador1 = Convert.ToInt32(cmbJogador1.SelectedValue);
            int idJogador2 = Convert.ToInt32(cmbJogador2.SelectedValue);
            // busca os jogadores no banco de dados com base nos IDs selecionados
            Jogador? jogador1 = db.Jogadores.Find(idJogador1);
            Jogador? jogador2 = db.Jogadores.Find(idJogador2);

            if (jogador1 == null || jogador2 == null)
            {
                MessageBox.Show("Jogador não encontrado.");
                return;
            }
            // cria uma tabela para exibir as comparações entre os jogadores
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Indicador");
            tabela.Columns.Add("Jogador1");
            tabela.Columns.Add("Jogador2");

            tabela.Rows.Add("Nome", jogador1.Nome ?? "", jogador2.Nome ?? "");
            tabela.Rows.Add("Clube", ObterNomeClube(jogador1.ClubeId), ObterNomeClube(jogador2.ClubeId));
            tabela.Rows.Add("Posição", jogador1.Posicao ?? "", jogador2.Posicao ?? "");
            tabela.Rows.Add("Nacionalidade", jogador1.Nacionalidade ?? "", jogador2.Nacionalidade ?? "");
            tabela.Rows.Add("Nº Observações", ContarObservacoes(jogador1.Id), ContarObservacoes(jogador2.Id));
            tabela.Rows.Add("Nº Avaliações", ContarAvaliacoes(jogador1.Id), ContarAvaliacoes(jogador2.Id));
            tabela.Rows.Add("Média Nota Final", ObterMediaNotaFinal(jogador1.Id).ToString("0.00"), ObterMediaNotaFinal(jogador2.Id).ToString("0.00"));
            tabela.Rows.Add("Último Potencial", ObterUltimoPotencial(jogador1.Id), ObterUltimoPotencial(jogador2.Id));

            dgvComparacao.DataSource = tabela;

            dgvComparacao.Columns["Indicador"]?.HeaderText = "Indicador";
            dgvComparacao.Columns["Jogador1"]?.HeaderText = jogador1.Nome ?? "Jogador 1";
            dgvComparacao.Columns["Jogador2"]?.HeaderText = jogador2.Nome ?? "Jogador 2";

            DestacarVencedor();
        }



        void DestacarVencedor()
        {// método para destacar o jogador com a melhor média de nota final, colorindo a célula correspondente
            foreach (DataGridViewRow row in dgvComparacao.Rows)
            {
                row.Cells["Jogador1"].Style.BackColor = Color.White;
                row.Cells["Jogador2"].Style.BackColor = Color.White;

                if (row.Cells["Indicador"].Value?.ToString() == "Média Nota Final")
                {
                    if (decimal.TryParse(row.Cells["Jogador1"].Value?.ToString(), out decimal nota1) &&
                        decimal.TryParse(row.Cells["Jogador2"].Value?.ToString(), out decimal nota2))
                    {
                        if (nota1 > nota2)
                        {
                            row.Cells["Jogador1"].Style.BackColor = Color.LightGreen;
                        }
                        else if (nota2 > nota1)
                        {
                            row.Cells["Jogador2"].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
        }
    }
}