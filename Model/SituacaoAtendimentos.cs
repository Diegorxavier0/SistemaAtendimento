using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimento.Model
{
    public class SituacaoAtendimentos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cor { get; set; }
        public bool? Ativo { get; set; }
       
    }
}
