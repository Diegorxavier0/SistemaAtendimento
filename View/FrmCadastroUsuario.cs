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
    }
}
