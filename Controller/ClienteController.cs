using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastroCliente _frmCadastroCliente;
        private ClienteRepository _clienteRepository;

        public ClienteController(FrmCadastroCliente view )
        {
            _frmCadastroCliente = view;
            _clienteRepository = new ClienteRepository();
        }

        public void ListarClientes()
        {
            var listaClientes = _clienteRepository.Listar();
            _frmCadastroCliente.ExibirClientes(listaClientes);
        }
    }
}
