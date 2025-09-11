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

namespace SistemaAtendimento
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteController _clienteController;
        public FrmCadastroCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this);
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
        }


        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes 
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cpf_Cnpj = txtCpfCnpj.Text,
                TipoPessoa = rdbFisica.Checked ? "F" : "J",
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                Ativo = rdbAtivo.Checked,

            };


            if (!ValidarDados(cliente))
                return;
            _clienteController.Salvar(cliente);

        }

        public bool ValidarDados(Clientes clientes)
        {
           if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }

            // 🔹 Validação do Tipo de Pessoa
            if (rdbFisica.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
                {
                    ExibirMensagem("Digite o CPF (Pessoa Física).");
                    txtCpfCnpj.Focus();
                    return false;
                }
            }
            else if (rdbJuridico.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
                {
                    ExibirMensagem("Digite o CNPJ (Pessoa Jurídica).");
                    txtCpfCnpj.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O campo Cep é obrigatório.");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O campo Endereço é obrigatório.");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo Numero é obrigatório.");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O campo bairro é obrigatório.");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                cbxEstado.Focus();
                return false;
            }
            return true;
        }
    }
}
