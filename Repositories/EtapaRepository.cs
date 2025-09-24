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
    public class EtapaRepository
    {
        // Método para listar todas as etapas
        public List<Etapas> Listar()
        {
            var etapas = new List<Etapas>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Etapas";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            etapas.Add(new Etapas()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Ordem = linhas["ordem"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
            }

            return etapas;
        }

        // Método para inserir uma nova etapa
        public void Inserir(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO Etapas (nome, ordem, ativo) VALUES (@nome, @ordem, @ativo)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", etapa.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE Etapas SET nome = @nome, ordem = @ordem, ativo = @ativo WHERE id = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", etapa.Id);
                    comando.Parameters.AddWithValue("@nome", etapa.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
