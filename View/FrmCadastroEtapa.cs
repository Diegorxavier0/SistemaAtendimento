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
    }
}
