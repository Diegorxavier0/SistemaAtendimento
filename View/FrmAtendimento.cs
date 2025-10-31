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

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form
    {
        private AtendimentoController _atendimentoController;

        public FrmAtendimento()
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this); //this injeta esse formulario no controlador
        }

        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();

        }

        private void carregarClientes()
        {
            var clientes = _atendimentoController.ListarClientes();
            cbxNomeCliente.DataSource = clientes;
            cbxNomeCliente.DisplayMember = "Nome";
            cbxNomeCliente.SelectedIndex = -1;
            cbxNomeCliente.ValueMember = "Id";

            //filtros no comBobox
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//faz a busca enquanto digita
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.ListItems;//faz a busca no que já tem na lista

            txtCodigoCliente.Text = "";// faz o campo do id comecar vazio 
        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            carregarClientes();
            CarregarEtapas();
            CarregarSituacaoAtendimento();
        }

 

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNomeCliente.SelectedValue != null)//se o vaor é diferente de null ,entao tem alguma informação la 
            {
                txtCodigoCliente.Text = cbxNomeCliente.SelectedValue.ToString();
            }
        }

        private void CarregarEtapas()
        {
            var etapas = _atendimentoController.ListarEtapas();
            cbxEtapaAtendimento.DataSource = etapas;
            cbxEtapaAtendimento.DisplayMember = "Nome";
            cbxEtapaAtendimento.SelectedIndex = -1;
            //cbxEtapaAtendimento.ValueMember = "Id";  NAO É NECESSARIO DESSA LINHA 

        }
        private void CarregarSituacaoAtendimento()
        {
            var situacaoAtendimento = _atendimentoController.ListarSituacaoAtendimentos();
            cbxSituacaoAtendimento.DataSource= situacaoAtendimento;
            cbxSituacaoAtendimento.DisplayMember= "Nome";
            cbxSituacaoAtendimento .SelectedIndex = -1;
        }
    }
}
