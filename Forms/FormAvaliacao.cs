using ScoutSport.Data;
using ScoutSport.Models;

namespace ScoutSport.Forms
{
    public partial class FormAvaliacao : Form
    {
        public FormAvaliacao()
        {
            InitializeComponent();

            ConfigurarDgvAvaliacao();
            CarregarObservacoes();
            CarregarDgvAvaliacao();

            txtNotaFinal.ReadOnly = true;
            txtPotencial.ReadOnly = true;
        }

        private void CarregarObservacoes()
        {
            using var db = new AppDbContext();

            try
            {
                cmbObservacao.DataSource = null;

                var lista = from o in db.Observacoes
                            join j in db.Jogadores on o.JogadorId equals j.Id
                            select new
                            {
                                o.Id,
                                Descricao = j.Nome + " - " + o.DataObservacao
                            };

                cmbObservacao.DataSource = lista.ToList();
                cmbObservacao.DisplayMember = "Descricao";
                cmbObservacao.ValueMember = "Id";
                cmbObservacao.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as observações: " + ex.Message);
            }
        }

        private void CarregarDgvAvaliacao()
        {
            using var db = new AppDbContext();

            try
            {
                dgvAvaliacao.DataSource = null;

                var lista = from a in db.Avaliacoes
                            join o in db.Observacoes on a.ObservacaoId equals o.Id
                            join j in db.Jogadores on o.JogadorId equals j.Id
                            select new
                            {
                                a.Id,
                                Observacao = j.Nome + " - " + o.DataObservacao,
                                a.Tecnica,
                                a.Velocidade,
                                a.InteligenciaTatica,
                                a.Fisico,
                                a.Atitude,
                                a.NotaFinal,
                                a.Potencial
                            };

                dgvAvaliacao.DataSource = lista.ToList();

                dgvAvaliacao.Columns["Id"]?.HeaderText = "ID";
                dgvAvaliacao.Columns["Observacao"]?.HeaderText = "Observação";
                dgvAvaliacao.Columns["Tecnica"]?.HeaderText = "Técnica";
                dgvAvaliacao.Columns["Velocidade"]?.HeaderText = "Velocidade";
                dgvAvaliacao.Columns["InteligenciaTatica"]?.HeaderText = "Inteligência Tática";
                dgvAvaliacao.Columns["Fisico"]?.HeaderText = "Físico";
                dgvAvaliacao.Columns["Atitude"]?.HeaderText = "Atitude";
                dgvAvaliacao.Columns["NotaFinal"]?.HeaderText = "Nota Final";
                dgvAvaliacao.Columns["Potencial"]?.HeaderText = "Potencial";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as avaliações: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            cmbObservacao.SelectedIndex = -1;
            txtTecnica.Clear();
            txtVelocidade.Clear();
            txtInteligencia.Clear();
            txtFisico.Clear();
            txtAtitude.Clear();
            txtNotaFinal.Clear();
            txtPotencial.Clear();
            cmbObservacao.Focus();
        }

        bool ValidarNota(TextBox txt, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("O campo " + nomeCampo + " é obrigatório.");
                txt.Focus();
                return false;
            }

            if (!decimal.TryParse(txt.Text, out decimal valor))
            {
                MessageBox.Show("O campo " + nomeCampo + " deve ser numérico.");
                txt.Focus();
                return false;
            }

            if (valor < 0 || valor > 20)
            {
                MessageBox.Show("O campo " + nomeCampo + " deve estar entre 0 e 20.");
                txt.Focus();
                return false;
            }

            return true;
        }
        private bool ValidarCampos()
        {
            if (cmbObservacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma observação.");
                cmbObservacao.Focus();
                return false;
            }

            if (!ValidarNota(txtTecnica, "Técnica"))
                return false;

            if (!ValidarNota(txtVelocidade, "Velocidade"))
                return false;

            if (!ValidarNota(txtInteligencia, "Inteligência Tática"))
                return false;

            if (!ValidarNota(txtFisico, "Físico"))
                return false;

            if (!ValidarNota(txtAtitude, "Atitude"))
                return false;

            return true;
        }

        private decimal CalcularNotaFinal()
        {
            decimal tecnica = Convert.ToDecimal(txtTecnica.Text);
            decimal velocidade = Convert.ToDecimal(txtVelocidade.Text);
            decimal inteligenciaTatica = Convert.ToDecimal(txtInteligencia.Text);
            decimal fisico = Convert.ToDecimal(txtFisico.Text);
            decimal atitude = Convert.ToDecimal(txtAtitude.Text);

            return (tecnica + velocidade + inteligenciaTatica + fisico + atitude) / 5;
        }

        private string ClassificarPotencial(decimal notaFinal)
        {
            if (notaFinal < 10)
                return "Baixo";

            if (notaFinal < 14)
                return "Médio";

            return "Elevado";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                decimal notaFinal = CalcularNotaFinal();

                txtNotaFinal.Text = notaFinal.ToString("0.00");
                txtPotencial.Text = ClassificarPotencial(notaFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao calcular a avaliação: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (!ValidarCampos())
                    return;

                decimal notaFinal = CalcularNotaFinal();
                string potencial = ClassificarPotencial(notaFinal);

                txtNotaFinal.Text = notaFinal.ToString("0.00");
                txtPotencial.Text = potencial;

                int observacaoId = Convert.ToInt32(cmbObservacao.SelectedValue);

                bool jaExiste = db.Avaliacoes.Any(a => a.ObservacaoId == observacaoId);

                if (jaExiste)
                {
                    MessageBox.Show("Esta observação já possui uma avaliação.");
                    return;
                }

                Avaliacao avaliacao = new Avaliacao();
                avaliacao.ObservacaoId = observacaoId;
                avaliacao.Tecnica = Convert.ToDecimal(txtTecnica.Text);
                avaliacao.Velocidade = Convert.ToDecimal(txtVelocidade.Text);
                avaliacao.InteligenciaTatica = Convert.ToDecimal(txtInteligencia.Text);
                avaliacao.Fisico = Convert.ToDecimal(txtFisico.Text);
                avaliacao.Atitude = Convert.ToDecimal(txtAtitude.Text);
                avaliacao.NotaFinal = notaFinal;
                avaliacao.Potencial = potencial;

                db.Avaliacoes.Add(avaliacao);
                db.SaveChanges();

                MessageBox.Show("Avaliação guardada com sucesso.");
                CarregarDgvAvaliacao();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao guardar a avaliação: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (dgvAvaliacao.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma avaliação na grelha para editar.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                int idSelecionado = Convert.ToInt32(dgvAvaliacao.SelectedRows[0].Cells["Id"].Value);
                int observacaoId = Convert.ToInt32(cmbObservacao.SelectedValue);

                bool jaExiste = db.Avaliacoes.Any(a => a.ObservacaoId == observacaoId && a.Id != idSelecionado);

                if (jaExiste)
                {
                    MessageBox.Show("Esta observação já possui outra avaliação.");
                    return;
                }

                Avaliacao? avaliacao = db.Avaliacoes.Find(idSelecionado);

                if (avaliacao == null)
                {
                    MessageBox.Show("Avaliação não encontrada.");
                    return;
                }

                decimal notaFinal = CalcularNotaFinal();
                string potencial = ClassificarPotencial(notaFinal);

                txtNotaFinal.Text = notaFinal.ToString("0.00");
                txtPotencial.Text = potencial;

                avaliacao.ObservacaoId = observacaoId;
                avaliacao.Tecnica = Convert.ToDecimal(txtTecnica.Text);
                avaliacao.Velocidade = Convert.ToDecimal(txtVelocidade.Text);
                avaliacao.InteligenciaTatica = Convert.ToDecimal(txtInteligencia.Text);
                avaliacao.Fisico = Convert.ToDecimal(txtFisico.Text);
                avaliacao.Atitude = Convert.ToDecimal(txtAtitude.Text);
                avaliacao.NotaFinal = notaFinal;
                avaliacao.Potencial = potencial;

                db.SaveChanges();

                MessageBox.Show("Avaliação editada com sucesso.");
                CarregarDgvAvaliacao();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar a avaliação: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (dgvAvaliacao.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma avaliação na grelha para excluir.");
                    return;
                }

                DialogResult resposta = MessageBox.Show(
                    "Tem certeza que deseja excluir esta avaliação?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta != DialogResult.Yes)
                    return;

                int idSelecionado = Convert.ToInt32(dgvAvaliacao.SelectedRows[0].Cells["Id"].Value);

                Avaliacao? avaliacao = db.Avaliacoes.Find(idSelecionado);

                if (avaliacao == null)
                {
                    MessageBox.Show("Avaliação não encontrada.");
                    return;
                }

                db.Avaliacoes.Remove(avaliacao);
                db.SaveChanges();

                MessageBox.Show("Avaliação excluída com sucesso.");
                CarregarDgvAvaliacao();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir a avaliação: " + ex.Message);
            }
        }

        private void dgvAvaliacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using var db = new AppDbContext();

            try
            {
                if (e.RowIndex >= 0)
                {
                    int idSelecionado = Convert.ToInt32(dgvAvaliacao.Rows[e.RowIndex].Cells["Id"].Value);

                    Avaliacao? avaliacao = db.Avaliacoes.Find(idSelecionado);

                    if (avaliacao != null)
                    {
                        cmbObservacao.SelectedValue = avaliacao.ObservacaoId;
                        txtTecnica.Text = avaliacao.Tecnica.ToString();
                        txtVelocidade.Text = avaliacao.Velocidade.ToString();
                        txtInteligencia.Text = avaliacao.InteligenciaTatica.ToString();
                        txtFisico.Text = avaliacao.Fisico.ToString();
                        txtAtitude.Text = avaliacao.Atitude.ToString();
                        txtNotaFinal.Text = avaliacao.NotaFinal.ToString("0.00");
                        txtPotencial.Text = avaliacao.Potencial ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao selecionar a avaliação: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarDgvAvaliacao()
        {
            dgvAvaliacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvaliacao.ReadOnly = true;
            dgvAvaliacao.AllowUserToAddRows = false;
            dgvAvaliacao.AllowUserToDeleteRows = false;
            dgvAvaliacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvaliacao.MultiSelect = false;
        }
    }
}