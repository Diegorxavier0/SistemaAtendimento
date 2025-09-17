using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (string.IsNullOrWhiteSpace(txtNome.Text))
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


            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                if (rdbFisica.Checked)
                {
                    ExibirMensagem("O Campo CPF é Obrigatório");

                }
                else
                {
                    ExibirMensagem("O Campo CNPJ é Obrigatório");
                }

                txtCpfCnpj.Focus();
                return false;
            }
            else
            {
                if (rdbFisica.Checked)
                {
                    //verficar se o cpf é valido


                }
                else
                {
                    //verificar se o cnpj é valido
                }


            }

            //            Console.Write("Digite o CPF: ");
            //            string cpf = Console.ReadLine();

            //            cpf = Regex.Replace(cpf, "[^0-9]", "");

            //            if (cpf.Length != 11)
            //            {
            //                Console.WriteLine("CPF deve conter 11 digitos");
            //                return;
            //            }

            //            if (cpf.Distinct().Count() == 1)
            //            {
            //                Console.WriteLine("CPF inválido! Números repetidos não são permitidos");
            //                return;
            //            }

            //            int digX = CalculaDV(cpf, 9, 10);
            //            int digY = CalculaDV(cpf, 10, 11);

            //            if (
            //                int.Parse(cpf[9].ToString()) == digX &&
            //                int.Parse(cpf[10].ToString()) == digY
            //               )
            //            {
            //                Console.WriteLine("CPF VÁLIDO!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("CPF INVÁLIDO!");
            //            }
            //        }

            //        public static int CalculaDV(string cpf, int qtdeNumeros, int peso)
            //        {
            //            int soma = 0;
            //            char[] cpfVetor = cpf.ToCharArray();

            //            for (int i = 0; i < qtdeNumeros; i++)
            //            {
            //                soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);
            //            }

            //            int resto = soma % 11;
            //            int digito = 0;

            //            if (resto >= 2)
            //            {
            //                digito = 11 - resto;
            //            }

            //            return digito;
            //        }
            //    }
            //}






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

        private void rdbJuridico_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridico.Checked)
            {
                lblCpfCnpj.Text = "CNPJ";

            }

        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFisica.Checked)
            {
                lblCpfCnpj.Text = "CPF";
            }
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            pnlTipoPessoa.Enabled = true;
            txtCpfCnpj.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtBairro.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void Limparcampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCpfCnpj.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            cbxEstado.Text = "";
            rdbAtivo.Checked = true;
            rdbFisica.Checked = true;
        }

        public void DesabilitarCampos()
        {
            Limparcampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            pnlTipoPessoa.Enabled = false;
            txtCpfCnpj.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtBairro.ReadOnly = true;
            cbxEstado.Enabled = false;
            pnlSituacao.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }
    }


}
