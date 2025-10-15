using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SistemaAtendimento.Repositories
{
    public class AtendimentoRepository
    {
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
            var lista = new List<Atendimentos>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT a.*, c.nome AS cliente_nome, c.cpf_cnpj, u.nome AS usuario_nome, s.nome AS situacao_nome FROM atendimentos a
                 INNER JOIN clientes c ON c.id = a.cliente_id
                 INNER JOIN usuarios u ON u.id = a.usuario_id
                 INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id";
    
                if(string.IsNullOrEmpty(termo) && string.IsNullOrEmpty(condicao))
                {
                   if(condicao == "Código do Atendimento")
                    {
                        sql += "WHERE id = @termo";
                    }else if(condicao == "Nome do Cliente")
                    {
                        sql += "WHERE c.nome LIKE %@termo%";
                    }
                    else 
                    {
                        sql += "WHERE c.cpf_cnpj = @termo";
                    }
                   
                }
            }
            return lista;



        }

        public void Inserir(Atendimentos atendimentos)
        {
        }

        public void Atualizar(Atendimentos atendimentos)
        {
        }

        public void Excluir(int id)
        {
        }
    }
}
