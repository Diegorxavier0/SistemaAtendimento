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

    public class EtapasAtendimentoController

    {

        private EtapasAtendimentoRepository _etapasAtendimentoRepository;
        private FrmAtendimento _frmAtendimento;

        // criando o cosntrutor

        public EtapasAtendimentoController(FrmAtendimento view)

        {
            _frmAtendimento = view;
            _etapasAtendimentoRepository = new EtapasAtendimentoRepository();

        }

        public List<EtapasAtendimentos> Listar(int atendimentoId)

        {

            return _etapasAtendimentoRepository.Listar(atendimentoId);

        }
        public void Salvar(EtapasAtendimentos etapaAtendimento)
        {
            try 
            {
                _etapasAtendimentoRepository.Inserir(etapaAtendimento);
                _frmAtendimento.ExibirMensagem("Atendimento etapa salvo com sucesso!");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem("Erro ao cadastrar o Atendimento Etapa: " + ex.Message);
            }
        }

        public void Excluir(int atendimentoId)
        {
            try
            {
                _etapasAtendimentoRepository.Excluir(atendimentoId);
                _frmAtendimento.ExibirMensagem("Etapas do atendimento excluídas com sucesso!");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem("Erro ao excluir as etapas do atendimento: " + ex.Message);
            }
        }
    }

}

