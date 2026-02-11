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
    public partial class FrmLogin : Form
    {
        private UsuarioController _usuarioController;

        public FrmLogin()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(null);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = _usuarioController.Autenticar(
               txtEmail.Text.Trim(),
               txtSenha.Text.Trim()
               );

            if (usuario != null)
            {
                MessageBox.Show($"Bem-Vindo, {usuario.Nome}");
                FrmTelaPrincipal principal = new FrmTelaPrincipal();
                principal.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("E-mail ou Senha inválidos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
