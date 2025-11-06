using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;
using static SistemaAtendimento.FrmCadastroCliente;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SistemaAtendimento.Database;
using System.Drawing.Text;

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
            cbxSituacaoAtendimento.DataSource = situacaoAtendimento;
            cbxSituacaoAtendimento.DisplayMember = "Nome";
            cbxSituacaoAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.ValueMember = "Id";
        }

        //        private void HabilitarCampos();
        //        {
        //            cbxNomeCliente.Enabled = false;
        //            cbxEtapaAtendimento.Enabled = true;
        //            cbxSituacaoAtendimento.Enabled = true;
        //            txtDescricaoAtendimento.Enabled = true;
        //            dtpDataAtendimento.Enabled = true;
        //            btnSalvarAtendimento.Enabled = true;
        //        }
        //}

        private void HabilitarCampos()
        {
            txtObservacaoAtendimento.ReadOnly = false;
            txtObservacaoAtendimento.Enabled = true;
            cbxNomeCliente.Enabled = true;
            cbxEtapaAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            dtpAberturaAtendimento.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            LimparCampos();
            txtObservacaoAtendimento.ReadOnly = true;
            cbxNomeCliente.Enabled = false;
            cbxEtapaAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            dtpAberturaAtendimento.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void LimparCampos()
        {
            txtObservacaoAtendimento.Clear();
            cbxNomeCliente.SelectedIndex = -1;
            cbxEtapaAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.SelectedIndex = -1;
            dtpAberturaAtendimento.Value = DateTime.Now;
            txtCodigoCliente.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendimentos atendimento = new Atendimentos
            {


                ClienteId = string.IsNullOrWhiteSpace(txtCodigoCliente.Text) ? null: Convert.ToInt32(cbxNomeCliente.SelectedValue),
                // ? if ternário tenta depois convert,
                UsuarioId = 1, // Substitua pelo ID do usuário logado
                SituacaoAtendimentoId = cbxSituacaoAtendimento.SelectedValue == null ? null : Convert.ToInt32(cbxSituacaoAtendimento.SelectedValue),
                Observacao = txtObservacaoAtendimento.Text,
                DataAbertura = dtpAberturaAtendimento.Value,
            };

            if (!Validardados(atendimento))
                return;

            _atendimentoController.Salvar(atendimento);
        }
            
        private bool Validardados(Atendimentos atendimento)
        {
            //criar regras de validação de campos 
            if(string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
            {
                cbxNomeCliente.Focus();// coloca o foco no campo
                ExibirMensagem("Selecione um Cliente");
                return false;
            }

            if(cbxSituacaoAtendimento.SelectedValue == null)
            {
                cbxSituacaoAtendimento.Focus();
                ExibirMensagem("Selecione uma Situação do Atendimento");
                return false;
            }

            if(string.IsNullOrWhiteSpace(txtObservacaoAtendimento.Text))
            {
                
                ExibirMensagem("Informe uma Observação do Atendimento");
                txtObservacaoAtendimento.Focus();
                return false;
            }

            return true;

        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

    }
}

