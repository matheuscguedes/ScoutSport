using ScoutSport.Data;
using ScoutSport.Models;

namespace ScoutSport.Forms
{
    public partial class FormJogador : Form
    {
        public FormJogador()
        {
            InitializeComponent();
            lblTitulo.Text = "Cadastro de Jogador";
            // Configurações iniciais do DataGridView
            ConfigurarDgvJogador();
            CarregarClubes();
            CarregarDgvJogador();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {// verifica se há linha selecionada na datagridview.
                if (dgvJogador.SelectedRows.Count == 0)
                { // se não ha linha selecionada, exibe mensagem e retorna.
                    MessageBox.Show("Selecione um jogador na grelha para editar.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                int idSelecionado = Convert.ToInt32(dgvJogador.SelectedRows[0].Cells["Id"].Value); //obter o id do jogador selecionado da grid

                Jogador? jogador = db.Jogadores.Find(idSelecionado); //buscar o jogador na base de dados usando o id obtido

                if (jogador == null)
                { // mensagem se o jogador não exister ou não for encontrado.
                    MessageBox.Show("Jogador não encontrado.");
                    return;
                }
                //atualiza os campos do jogador conforma os dados inseridos no formulario.
                jogador.ClubeId = Convert.ToInt32(cmbClube.SelectedValue);
                jogador.Nome = txtNome.Text.Trim();
                jogador.DataNascimento = dtpNascimento.Value;
                jogador.Nacionalidade = txtNacionalidade.Text.Trim();
                jogador.Posicao = txtPosicao.Text.Trim();
                jogador.Altura = string.IsNullOrWhiteSpace(txtAltura.Text) ? null : Convert.ToDecimal(txtAltura.Text);
                jogador.Peso = string.IsNullOrWhiteSpace(txtPeso.Text) ? null : Convert.ToDecimal(txtPeso.Text);

                db.SaveChanges();
                // mensagem quando o jogador é editado com sucesso.
                MessageBox.Show("Jogador editado com sucesso.");
                CarregarDgvJogador();
                LimparCampos();
            }
            catch (Exception ex)
            {// mensagem de erro durante a edição do jogador.
                MessageBox.Show("Ocorreu um erro ao editar o jogador: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {// verifica se existe o jogador na grid para ser excluido, se não exibe mensagem e retorna.
                if (dgvJogador.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um jogador na grelha para excluir.");
                    return;
                }

                DialogResult resposta = MessageBox.Show(
                    "Tem certeza que deseja excluir este jogador?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta != DialogResult.Yes)
                    return;

                int idSelecionado = Convert.ToInt32(dgvJogador.SelectedRows[0].Cells["Id"].Value);

                Jogador? jogador = db.Jogadores.Find(idSelecionado);// busca o jogador na base de dados usando o id obtido da grid.

                if (jogador == null)
                {
                    MessageBox.Show("Jogador não encontrado.");
                    return;
                }

                db.Jogadores.Remove(jogador);
                db.SaveChanges();

                MessageBox.Show("Jogador excluído com sucesso.");
                CarregarDgvJogador();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o jogador: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (!ValidarCampos())
                    return;

                Jogador jogador = ObterJogador(); //Obter os dados do jogador a partir dos campos do formulario e criar um objeto jogador.

                db.Jogadores.Add(jogador);
                db.SaveChanges();

                MessageBox.Show("Jogador guardado com sucesso."); // mensagem de sucesso ao guardar o jogador.
                CarregarDgvJogador();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao guardar o jogador: " + ex.Message);
            }
        }

        private void cmbClube_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void CarregarClubes()
        { //carrega os clubes da base de dados e exibe na combobox, configura a combobox para exibir o nome do clube.
            using var db = new AppDbContext();

            try
            {
                cmbClube.DataSource = db.Clubes.ToList();
                cmbClube.DisplayMember = "Nome";
                cmbClube.ValueMember = "Id";
                cmbClube.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os clubes: " + ex.Message);
            }
        }

        void CarregarDgvJogador()
        {// carrega os jogadores da base de dados e exibe na grid, utiliza o join para obter o nome do clube associado de cada jogador.
            using var db = new AppDbContext();

            try
            {
                var lista = from j in db.Jogadores
                            join c in db.Clubes on j.ClubeId equals c.Id
                            select new
                            {
                                j.Id,
                                Clube = c.Nome,
                                j.Nome,
                                j.DataNascimento,
                                j.Nacionalidade,
                                j.Posicao,
                                j.Altura,
                                j.Peso
                            };

                dgvJogador.DataSource = lista.ToList();
                //configura as colunas da grid.
                dgvJogador.Columns["Id"]?.HeaderText = "ID";
                dgvJogador.Columns["Clube"]?.HeaderText = "Clube";
                dgvJogador.Columns["Nome"]?.HeaderText = "Nome";
                dgvJogador.Columns["DataNascimento"]?.HeaderText = "Data Nascimento";
                dgvJogador.Columns["Nacionalidade"]?.HeaderText = "Nacionalidade";
                dgvJogador.Columns["Posicao"]?.HeaderText = "Posição";
                dgvJogador.Columns["Altura"]?.HeaderText = "Altura";
                dgvJogador.Columns["Peso"]?.HeaderText = "Peso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os jogadores: " + ex.Message);
            }
        }

        void LimparCampos()
        {
            txtNome.Clear();
            txtNacionalidade.Clear();
            txtPosicao.Clear();
            txtAltura.Clear();
            txtPeso.Clear();
            cmbClube.SelectedIndex = -1;
            dtpNascimento.Value = DateTime.Now;
            txtNome.Focus();
        }

        bool ValidarCampos()
        { // vai validar os campos do formulario, para assegurar que os dados inseridos são os corretos.
            if (cmbClube.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um clube.");
                cmbClube.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do jogador é obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPosicao.Text))
            {
                MessageBox.Show("A posição do jogador é obrigatória.");
                txtPosicao.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtAltura.Text) && !decimal.TryParse(txtAltura.Text, out _))
            {
                MessageBox.Show("A altura deve ser numérica.");
                txtAltura.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtPeso.Text) && !decimal.TryParse(txtPeso.Text, out _))
            {
                MessageBox.Show("O peso deve ser numérico.");
                txtPeso.Focus();
                return false;
            }

            return true;
        }

        Jogador ObterJogador()
        { //com objeto jogador, vai obter os dados que foram inseridos em cada campo do formulario e atribuir ao objeto jogador.
            Jogador jogador = new Jogador();
            jogador.ClubeId = Convert.ToInt32(cmbClube.SelectedValue);
            jogador.Nome = txtNome.Text.Trim();
            jogador.DataNascimento = dtpNascimento.Value;
            jogador.Nacionalidade = txtNacionalidade.Text.Trim();
            jogador.Posicao = txtPosicao.Text.Trim();

            if (!string.IsNullOrWhiteSpace(txtAltura.Text))
                jogador.Altura = Convert.ToDecimal(txtAltura.Text);

            if (!string.IsNullOrWhiteSpace(txtPeso.Text))
                jogador.Peso = Convert.ToDecimal(txtPeso.Text);

            return jogador;
        }

        void ConfigurarDgvJogador()
        {//configura a grid para exibir os dados dos jogadores.
            dgvJogador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJogador.ReadOnly = true;
            dgvJogador.AllowUserToAddRows = false;
            dgvJogador.AllowUserToDeleteRows = false;
            dgvJogador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJogador.MultiSelect = false;
        }
    }
}