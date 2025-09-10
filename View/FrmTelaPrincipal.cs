using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.View;



namespace SistemaAtendimento
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conexão estabelecida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void etapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEtapa frmCadastroEtapa = new FrmCadastroEtapa();
            frmCadastroEtapa.ShowDialog();
        }

        private void situacaoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroSituacaoAtendimento frmCadastroSituacaoAtendimento = new FrmCadastroSituacaoAtendimento();
            frmCadastroSituacaoAtendimento.ShowDialog();
        }
    }
}
