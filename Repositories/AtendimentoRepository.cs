using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class AtendimentoRepository
    {
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
            var lista = new List<Atendimentos>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT a.*, 
                                      c.nome AS cliente_nome, 
                                      c.cpf_cnpj, 
                                      u.nome AS usuario_nome, 
                                      s.nome AS situacao_nome 
                               FROM atendimentos a
                               INNER JOIN clientes c ON c.id = a.cliente_id
                               INNER JOIN usuarios u ON u.id = a.usuario_id
                               INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id";

                // Só entra aqui se houver termo E condição
                if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                {
                    if (condicao == "Código do Atendimento")
                    {
                        sql += " WHERE a.id = @termo";
                    }
                    else if (condicao == "Nome do Cliente")
                    {
                        sql += " WHERE c.nome LIKE @termo";
                    }
                    else if (condicao == "CPF/CNPJ")
                    {
                        sql += " WHERE c.cpf_cnpj = @termo";
                    }
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                    {
                        if (condicao == "Nome do Cliente")
                        {
                            comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@termo", termo);
                        }
                    }

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            lista.Add(new Atendimentos
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                ClienteId = Convert.ToInt32(linhas["cliente_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                Observacao = linhas["observacao"].ToString(),
                                DataAbertura = linhas["data_abertura"] as DateTime?,
                                DataFechamento = linhas["data_fechamento"] as DateTime?,
                                SituacaoAtendimentoId = Convert.ToInt32(linhas["situacao_atendimento_id"]),
                                ClienteNome = linhas["cliente_nome"].ToString(),
                                UsuarioNome = linhas["usuario_nome"].ToString(),
                                SituacaoAtendimentoNome = linhas["situacao_nome"].ToString(),
                                CpfCnpj = linhas["cpf_cnpj"].ToString()
                            });
                        }
                    }
                }

                return lista;
            }
        }
            // public Atendimentos? BuscarPorId(int id)
            // {
            //var resultado = Listar(id.ToString(), "Código do Atendimento");
            //return resultado.FirstOrDefault();
            // }
        
        public Atendimentos? BuscarPorId(int id)//função pra buscar um unico registro 
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT 
                                a.*, 
                                c.nome AS cliente_nome,
                                u.nome AS usuario_nome,
                                s.nome AS situacao_nome 
                                FROM atendimentos a 
                                INNER JOIN clientes c ON c.id = a.cliente_id 
                                INNER JOIN usuarios u ON u.id = a.usuario_id
                                INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id 
                                WHERE a.id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue(@"id", id);
                    conexao.Open();

                    using (var linha = comando.ExecuteReader())
                    {
                        if (linha.Read())
                        {
                            return new Atendimentos
                            {
                                Id = Convert.ToInt32(linha["id"]),
                                ClienteId = Convert.ToInt32(linha["cliente_id"]),
                                UsuarioId = Convert.ToInt32(linha["usuario_id"]),
                                Observacao = linha["observacao"].ToString(),
                                DataAbertura = linha["data_abertura"] as DateTime?,//Cast para DateTime?
                                DataFechamento = linha["data_fechamento"] as DateTime?,
                                SituacaoAtendimentoId = Convert.ToInt32(linha["situacao_atendimento_id"]),
                                ClienteNome = linha["cliente_nome"].ToString(),
                                UsuarioNome = linha["usuario_nome"].ToString(),
                                SituacaoAtendimentoNome = linha["situacao_nome"].ToString()
                            };


                        }
                    }
                }
            }
            return null;
     }   
        
        public int Inserir(Atendimentos atendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO atendimentos 
                              (cliente_id, usuario_id, observacao, data_abertura, situacao_atendimento_id) OUTPUT INSERTED.id
                              VALUES 
                              (@cliente_id, @usuario_id, @observacao, @data_abertura, @situacao_atendimento_id)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimentos.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimentos.UsuarioId);
                    comando.Parameters.AddWithValue("@observacao", atendimentos.Observacao);
                    comando.Parameters.AddWithValue("@data_abertura", atendimentos.DataAbertura);
                   
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimentos.SituacaoAtendimentoId);
                    conexao.Open();

                    return Convert.ToInt32(comando.ExecuteScalar());//retorna o id inserido
                    //comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Atendimentos atendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE atendimentos SET 
                       cliente_id = @cliente_id, 
                       usuario_id = @usuario_id, 
                       observacao = @observacao, 
                       data_abertura = @data_abertura, 
                       situacao_atendimento_id = @situacao_atendimento_id
                       WHERE id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimentos.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimentos.UsuarioId);
                    comando.Parameters.AddWithValue("@observacao", atendimentos.Observacao);
                    comando.Parameters.AddWithValue("@data_abertura", atendimentos.DataAbertura);

                    //comando.Parameters.AddWithValue("@data_fechamento",
                    //    (object?)atendimentos.DataFechamento ?? DBNull.Value);

                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimentos.SituacaoAtendimentoId);
                    comando.Parameters.AddWithValue("@id", atendimentos.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM atendimentos WHERE id = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
