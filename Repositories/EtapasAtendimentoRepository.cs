using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class EtapasAtendimentoRepository
    {
        public List<EtapasAtendimentos> Listar(int atendimentoId)
        {
            var etapasAtendimentos = new List<EtapasAtendimentos>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT * FROM etapa_atendimentos WHERE atendimento_id = @atendimentoId";

                using(var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@atendimentoId", atendimentoId);
                    conexao.Open();
                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            
                            etapasAtendimentos.Add(new EtapasAtendimentos 
                            { 
                                Id = Convert.ToInt32(linhas["id"]),
                                AtendimentoId = Convert.ToInt32(linhas["atendimento_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                EtapaId = Convert.ToInt32(linhas["etapa_id"]),
                                DataCadastro = (linhas["data_cadastro"] as DateTime?),
                                Observacao = linhas["observacao"].ToString(),
                            });
                        }
                    }
                }
            }
            return etapasAtendimentos;
        }

        public void Inserir(EtapasAtendimentos etapaAtendimento)


        {
            // Lógica para inserir a etapa do atendimento no banco de dados
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO etapa_atendimentos (atendimento_id, usuario_id, etapa_id, data_cadastro, observacao)
                               VALUES (@atendimentoId, @usuarioId, @etapaId, @dataCadastro, @observacao)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@atendimentoId", etapaAtendimento.AtendimentoId);
                    comando.Parameters.AddWithValue("@usuarioId", etapaAtendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@etapaId", etapaAtendimento.EtapaId);
                    comando.Parameters.AddWithValue("@dataCadastro", etapaAtendimento.DataCadastro ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@observacao", etapaAtendimento.Observacao ?? (object)DBNull.Value);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }

        }

        public void Excluir(int atendimentoId)
        {
            // Lógica para excluir etapas do atendimento pelo ID do atendimento no banco de dados
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"DELETE FROM etapa_atendimentos WHERE atendimento_id = @atendimentoId";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@atendimentoId", atendimentoId);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
