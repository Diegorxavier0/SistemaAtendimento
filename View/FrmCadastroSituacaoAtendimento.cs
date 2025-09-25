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
    }
}
