using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repository;
using SistemaAtendimento.Services;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastroCliente _frmCadastroCliente;
        private ClienteRepository _clienteRepository;

        public ClienteController(FrmCadastroCliente view)
        {
            _frmCadastroCliente = view;
            _clienteRepository = new ClienteRepository();
        }

        public void ListarClientes(string termo = "")
        {
            try
            {
                var listaClientes = _clienteRepository.Listar(termo);
                _frmCadastroCliente.ExibirClientes(listaClientes);
            }
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }

        }

        public void Salvar(Clientes cliente)
        {

            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastroCliente.ExibirMensagem($"Cliente cadastrado com Sucesso:");
               
                //atualizar dataGrid 
                ListarClientes();

                _frmCadastroCliente.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao Cadastrar o Cliente: {ex.Message}");
            }
        }

        public void Atualizar(Clientes cliente)
        {

            try
            {
                _clienteRepository.Atualizar(cliente);
                _frmCadastroCliente.ExibirMensagem($"Cliente atualizado com Sucesso:");

                //atualizar dataGrid 
                ListarClientes();

                _frmCadastroCliente.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao atualizar o Cliente: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _clienteRepository.Excluir(id);
                _frmCadastroCliente.ExibirMensagem($"Cliente excluído com Sucesso:");
                //atualizar dataGrid 
                ListarClientes();
                _frmCadastroCliente.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao excluir o Cliente: {ex.Message}");
            }
        }

        public void GerarRelatorioPDF()
        {
            try 
            {
                var listaClientes = _clienteRepository.Listar();

                var relatorioClientes = new RelatorioClientes();

                string arquivo = relatorioClientes.GerarListaClientes(listaClientes);

                var psi = new ProcessStartInfo(arquivo)
                {
                    UseShellExecute = true
                };
                Process.Start(psi);//abrir o arquivo PDF gerado
            }
            catch (Exception ex)
            {
               ///Erro ao gerar o relatorio 
            }


            
        }
    }
}
