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
    }
}
