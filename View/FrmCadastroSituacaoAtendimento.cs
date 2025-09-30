using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroSituacaoAtendimento : Form
    {
        private SituacaoAtendimentoController _situacaoAtendimentoController;

        public FrmCadastroSituacaoAtendimento()
        {
            InitializeComponent();
            _situacaoAtendimentoController = new SituacaoAtendimentoController(this);
        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoAtendimentoController.ListarSituacaoAtendimentos();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirSituacaoAtendimentos(List<SituacaoAtendimentos> situacaoAtendimentos)
        {
            dgvListaSituacaoAtendimento.DataSource = situacaoAtendimentos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoAtendimentos situacaoAtendimentos = new SituacaoAtendimentos
            {
                Nome = txtNome.Text,
                Cor = txtCor.Text,
                Ativo = rdbAtivo.Checked,

            };

            if (!ValidarDados(situacaoAtendimentos))
                return;

            // if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            //{
            //novo cliente
            _situacaoAtendimentoController.Salvar(situacaoAtendimentos);
        }
        // }
        //  else
        // {
        //editar cliente
        //  situacaoAtendimento.Id = Convert.ToInt32(txtCodigo.Text);
        //implementar metodo editar no controller e repository
        // _situacaoAtendimentoController.Atualizar(situacaoAtendimentos);
        //}
        // }
        public bool ValidarDados(SituacaoAtendimentos situacaoAtendimentos)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCor.Text))
            {
                ExibirMensagem("O campo Cor é obrigatório.");
                txtCor.Focus();
                return false;
            }

            return true; // Retorna true se passou nas validações
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtCor.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCor.Clear();
            rdbAtivo.Checked = true;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;
            pnlSituacao.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvListaSituacaoAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow LinhaSelecionada = dgvListaSituacaoAtendimento.Rows[e.RowIndex];

                txtCodigo.Text = LinhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = LinhaSelecionada.Cells["Nome"].Value.ToString();
                txtCor.Text = LinhaSelecionada.Cells["Cor"].Value.ToString();

                rdbAtivo.Checked = Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);

                // Habilitar os botões de editar e excluir
                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                ExibirMensagem("Selecione uma Situação de Atendimento.");
                return;
            }


            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta situação?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _situacaoAtendimentoController.Excluir(id);//arrumar no controller

            }
        }
    }
}
