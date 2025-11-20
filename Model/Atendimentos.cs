using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimento.Model
{
    public class Atendimentos
    {
        public int? Id { get; set; }
        public int? ClienteId { get; set; }//? permite nulo
        public int? UsuarioId { get; set; }
        public string? Observacao { get; set; }
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public int? SituacaoAtendimentoId { get; set; }
     
        public string? ClienteNome { get; set; }
        public string? UsuarioNome { get; set; }
        public string? SituacaoAtendimentoNome { get; set; }

        public string? CpfCnpj { get; set; }

    }
}
