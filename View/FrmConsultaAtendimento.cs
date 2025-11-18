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

        private void dgvConsultaAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dgvConsultaAtendimento.Rows[e.RowIndex].Cells["Id"].Value;

                // FECHA a tela atual antes de abrir a próxima
                this.Hide();  // esconde para não aparecer piscando

                FrmAtendimento frmAtendimento = new FrmAtendimento(id);
                frmAtendimento.ShowDialog(); // abre o atendimento

               this.Close(); // fecha de vez a tela de consulta
            }
        }
    }
}
