using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.Repository;
using SistemaAtendimento.View;


namespace SistemaAtendimento.Controller
{
    
    public class AtendimentoController
    {
        //vincula com o frm
        private FrmAtendimento _frmAtendimento;
        private AtendimentoRepository _atendimentoRepository;
        private ClienteRepository _clienteRepository;
        private EtapaRepository _etapaRepository;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public AtendimentoController(FrmAtendimento view ) 
        {
            _frmAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
            _clienteRepository = new ClienteRepository();
            _etapaRepository = new EtapaRepository();
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public List<Clientes> ListarClientes() 
        
        {
            return _clienteRepository.Listar();
        }

        public List<Etapas> ListarEtapas()
        { 
        return _etapaRepository.Listar();
        }

        public List<SituacaoAtendimentos> ListarSituacaoAtendimentos()
        {
            return _situacaoAtendimentoRepository.Listar();
        }


    }
}

