using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimento.Model
{
    public class EtapasAtendimentos
    {
        public int Id { get; set; }
        public int AtendimentoId { get; set; }
        public int UsuarioId { get; set; }

        public int EtapaId { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public string? Observacao { get; set; }
    }
}
