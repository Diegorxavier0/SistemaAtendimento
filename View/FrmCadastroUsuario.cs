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
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)//evento criado ao, NÃO PODE SER DIGITADO
        {
            _usuarioController.ListarUsuarios();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirUsuarios(List<Usuarios> usuarios)
        {
            dgvListaUsuarios.DataSource = usuarios;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Usuarios usuario = new Usuarios
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Perfil = cbxPerfil.Text,

            };

            if (!ValidarDados(usuario))
                return;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                //novo cliente
                _usuarioController.Salvar(usuario);
            }
            else
            {
                //editar cliente
                usuario.Id = Convert.ToInt32(txtCodigo.Text);
                //implementar metodo editar no controller e repository
                _usuarioController.Atualizar(usuario);
            }
        }

        public bool ValidarDados(Usuarios usuario)
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

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                ExibirMensagem("O campo Senha é obrigatório.");
                txtSenha.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxPerfil.Text))
            {
                ExibirMensagem("O campo Perfil é obrigatório.");
                cbxPerfil.Focus();
                return false;
            }

            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
            cbxPerfil.Enabled = true;


            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbxPerfil.Text = "";

        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSenha.ReadOnly = true;
            cbxPerfil.Enabled = false;

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

        private void dgvListaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow LinhaSelecionada = dgvListaUsuarios.Rows[e.RowIndex];

                txtCodigo.Text = LinhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = LinhaSelecionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = LinhaSelecionada.Cells["Email"].Value.ToString();
                txtSenha.Text = LinhaSelecionada.Cells["Senha"].Value.ToString();
                cbxPerfil.Text = LinhaSelecionada.Cells["Perfil"].Value.ToString();


                // Habilitar os botões de editar e excluir
                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um usuário para excluir.");
                return;
            }


            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Excluir(id);

            }
        }
    }
}
