using ScoutSport.Data;
using ScoutSport.Models;

namespace ScoutSport.Forms
{
    public partial class FormClubes : Form
    {
        private int idClubeSelecionado = 0; // variavel para armazenar o id do clube selecionado.

        public FormClubes()
        {
            InitializeComponent();
            //confirguração inicial do formulário
            lblTitulo.Text = "Clubes";
            ConfigurarDgvClube();
            CarregarDgvClubes();
        }

        private bool ValidarCampos()
        {// validar os campos do formulario, garantindo que o utilizador preencheu as informações antes de guardar ou editar um clube.
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do clube é obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("O país do clube é obrigatório.");
                txtPais.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("A cidade do clube é obrigatória.");
                txtCidade.Focus();
                return false;
            }

            return true;
        }

        private Clube ObterClubeDoFormulario()
        { // criar um objeto do tipo Clube com os dados preenchidos, para ser utilizado na hora de guardar ou editar um clube no banco de dados.
            Clube clube = new Clube();
            clube.Nome = txtNome.Text.Trim();
            clube.Pais = txtPais.Text.Trim();
            clube.Cidade = txtCidade.Text.Trim();
            return clube;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {// limpar os campos do formulário para permitir a inserção de um novo clube.
            LimparCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { //guarda um novo clube no base de dados, apos a validação dos campos.
            using var db = new AppDbContext();

            try
            {
                if (!ValidarCampos())
                    return;

                Clube clube = ObterClubeDoFormulario();

                db.Clubes.Add(clube);
                db.SaveChanges();

                MessageBox.Show("Clube guardado com sucesso.");
                CarregarDgvClubes();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao guardar o clube: " + ex.Message);
            }
        }

        private void dgvClube_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow linha = dgvClube.Rows[e.RowIndex];

                    if (linha.Cells["Id"].Value != null)
                        idClubeSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);

                    txtNome.Text = linha.Cells["Nome"].Value?.ToString() ?? "";
                    txtPais.Text = linha.Cells["Pais"].Value?.ToString() ?? "";
                    txtCidade.Text = linha.Cells["Cidade"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao selecionar o clube: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (dgvClube.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um clube na grelha para excluir.");
                    return;
                }
                // Mensagem para confirmar que quer excluir um clube.
                DialogResult resposta = MessageBox.Show(
                    "Tem certeza que deseja excluir este clube?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta != DialogResult.Yes) // sendo a resposta positiva para a exclução do clube.
                    return;

                int idSelecionado = Convert.ToInt32(dgvClube.SelectedRows[0].Cells["Id"].Value);

                Clube? clube = db.Clubes.Find(idSelecionado);

                if (clube == null)
                {
                    MessageBox.Show("Clube não encontrado.");
                    return;
                }

                db.Clubes.Remove(clube);
                db.SaveChanges();

                MessageBox.Show("Clube excluído com sucesso.");
                CarregarDgvClubes();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o clube: " + ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {// editar um clube selecionado na grelha, após a validação dos campos do formulário.
            using var db = new AppDbContext();

            try
            {
                if (dgvClube.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um clube na grelha para editar.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                int idSelecionado = Convert.ToInt32(dgvClube.SelectedRows[0].Cells["Id"].Value);

                Clube? clube = db.Clubes.Find(idSelecionado);

                if (clube == null)
                {
                    MessageBox.Show("Clube não encontrado.");
                    return;
                }

                clube.Nome = txtNome.Text.Trim();
                clube.Pais = txtPais.Text.Trim();
                clube.Cidade = txtCidade.Text.Trim();

                db.SaveChanges();

                MessageBox.Show("Clube editado com sucesso.");
                CarregarDgvClubes();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar o clube: " + ex.Message);
            }
        }

        void ConfigurarDgvClube()
        {// Vai configurar a dataGridView para exibir os clubes.
            dgvClube.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClube.ReadOnly = true;
            dgvClube.AllowUserToAddRows = false;
            dgvClube.AllowUserToDeleteRows = false;
            dgvClube.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClube.MultiSelect = false;
        }

        private void CarregarDgvClubes()
        {// Vai carregar os clubes da base de dados e exibir na dataGridView.
            using var db = new AppDbContext();

            dgvClube.DataSource = null;
            dgvClube.DataSource = db.Clubes.ToList();

            dgvClube.Columns["Id"]?.HeaderText = "ID";
            dgvClube.Columns["Nome"]?.HeaderText = "Nome";
            dgvClube.Columns["Pais"]?.HeaderText = "País";
            dgvClube.Columns["Cidade"]?.HeaderText = "Cidade";
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPais.Clear();
            txtCidade.Clear();

            idClubeSelecionado = 0;
            txtNome.Focus();
        }

    }
}