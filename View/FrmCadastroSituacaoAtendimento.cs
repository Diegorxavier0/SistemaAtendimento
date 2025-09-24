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

            if (!ValidarDados(cliente))
                return;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                //novo cliente
                _clienteController.Salvar(cliente);
            }
            else
            {
                //editar cliente
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                //implementar metodo editar no controller e repository
                _clienteController.Atualizar(cliente);
            }
        }
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

            //terminar proxima aula
        }
    }
