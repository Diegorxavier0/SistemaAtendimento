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
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;
        public FrmCadastroEtapa()
        {
            InitializeComponent();
            _etapaController = new EtapaController(this);
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirEtapas(List<Etapas> etapas)
        {
            dgvListaEtapas.DataSource = etapas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etapas etapa = new Etapas
            {


                Nome = txtNome.Text,
                Ordem = txtOrdem.Text,
                Ativo = rdbAtivo.Checked,

            };

            if (!ValidarDados(etapa))
                return;

            _etapaController.Salvar(etapa);
        }

        public bool ValidarDados(Etapas etapas)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOrdem.Text))
            {
                ExibirMensagem("O campo Ordem é obrigatório.");
                txtOrdem.Focus();
                return false;
            }
            return true;
        }

        //criando métodos

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void Limparcampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;

        }

        public void DesabilitarCampos()
        {
            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;




            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }



        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }
    }
}

