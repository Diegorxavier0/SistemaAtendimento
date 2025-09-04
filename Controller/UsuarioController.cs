using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;   

        public UsuarioController(FrmCadastroUsuario view ) 
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var listaUsuarios = _usuarioRepository.Listar();
                _frmCadastroUsuario.ExibirUsuarios(listaUsuarios);
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao carregar os usuarios: {ex.Message}");
            }

        }
    }
}
