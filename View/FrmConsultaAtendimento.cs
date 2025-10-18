using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmConsultaAtendimento : Form
    {
        private ConsultaAtendimentoController _consultaAtendimentoController;
        public FrmConsultaAtendimento()
        {
            InitializeComponent();
            _consultaAtendimentoController = new ConsultaAtendimentoController(this);
        }

        private void FrmConsultaAtendimento_Load(object sender, EventArgs e)
        {
            _consultaAtendimentoController.ListarAtendimentos();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirAtendimentos(List<Atendimentos> atendimentos)
        {
            // Lógica para exibir a lista de atendimentos na interface do usuário
            // Por exemplo, preencher um DataGridView ou ListBox com os dados

            dgvConsultaAtendimento.DataSource = atendimentos;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtFiltro.Text.Trim();
            string condicaoSelecionada = cbxFiltro.SelectedItem?.ToString() ?? "";

            string condicaoRepo = "";

            if (condicaoSelecionada == "Código do Atendimento")
            {
                condicaoRepo = "Código do Atendimento";
            }
            else if (condicaoSelecionada == "Nome do Cliente")
            {
                condicaoRepo = "Nome do Cliente";
            }
            else if (condicaoSelecionada == "CPF" || condicaoSelecionada == "CNPJ")
            {
                condicaoRepo = "CPF/CNPJ";
            }

            _consultaAtendimentoController.ListarAtendimentos(termo, condicaoRepo);
        }
    }
}
