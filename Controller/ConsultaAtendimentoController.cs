using System;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class ConsultaAtendimentoController
    {
        private FrmConsultaAtendimento _frmConsultaAtendimento;
        private AtendimentoRepository _atendimentoRepository;

        // Construtor
        public ConsultaAtendimentoController(FrmConsultaAtendimento view)
        {
            _frmConsultaAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
        }

        // Método para listar atendimentos
        public void ListarAtendimentos(string termo = "", string condicao = "")
        {
            try
            {
                // Chama o repositório para buscar os atendimentos
                var listaAtendimentos = _atendimentoRepository.Listar(termo, condicao);

                // Envia a lista para a View exibir
                _frmConsultaAtendimento.ExibirAtendimentos(listaAtendimentos);
            }
            catch (Exception ex)
            {
                // Mostra mensagem de erro na View
                _frmConsultaAtendimento.ExibirMensagem($"Erro ao carregar os atendimentos: {ex.Message}");
            }
        }
    }
}
