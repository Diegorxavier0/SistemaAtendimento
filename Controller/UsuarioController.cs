using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
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
                _frmCadastroUsuario.ExibirMensagem($"Erro ao carregar os usuários: {ex.Message}");
            }

        }
        public void Salvar(Usuarios usuario)
        {

            try
            {
                _usuarioRepository.Inserir(usuario);
                _frmCadastroUsuario.ExibirMensagem($"Usuário cadastrado com Sucesso:");

                //atualizar dataGrid 
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Cadastrar o Usuário: {ex.Message}");
            }
        }
        public void Atualizar(Usuarios usuario)
        {

            try
            {
                _usuarioRepository.Atualizar(usuario);
                _frmCadastroUsuario.ExibirMensagem($"Usuário atualizado com Sucesso:");

                //atualizar dataGrid 
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao atualizar o Usuário: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _frmCadastroUsuario.ExibirMensagem($"Usuário excluído com Sucesso:");
                //atualizar dataGrid 
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao excluir o Usuário {ex.Message}");
            }
        }
    }
}
