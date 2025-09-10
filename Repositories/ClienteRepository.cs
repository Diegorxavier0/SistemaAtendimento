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
    public class ClienteRepository
    {
        public List<Clientes> Listar()
        {
            var clientes = new List<Clientes>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Clientes";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            clientes.Add(new Clientes()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString(),
                                TipoPessoa = linhas["tipo_pessoa"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                Celular = linhas["celular"].ToString(),
                                Cep = linhas["cep"].ToString(),
                                Endereco = linhas["endereco"].ToString(),
                                Numero = linhas["numero"].ToString(),
                                Complemento = linhas["complemento"].ToString(),
                                Bairro = linhas["bairro"].ToString(),
                                Cidade = linhas["cidade"].ToString(),
                                Estado = linhas["estado"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])

                            });

                        }
                    }
                }
                return clientes;
            }
        }   public void Inserir(Clientes clientes)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO clientes (nome, email, cpf_cnpj, tipo_pessoa, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado, ativo) VALUES (@nome, @email, @cpf_cnpj, @tipo_pessoa, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @ativo)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", clientes.Nome);
                    comando.Parameters.AddWithValue("@email", clientes.Email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", clientes.Cpf_Cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", clientes.TipoPessoa);
                    comando.Parameters.AddWithValue("@telefone", clientes.Telefone);
                    comando.Parameters.AddWithValue("@celular", clientes.Celular);
                    comando.Parameters.AddWithValue("@cep", clientes.Cep);
                    comando.Parameters.AddWithValue("@endereco", clientes.Endereco);
                    comando.Parameters.AddWithValue("@numero", clientes.Numero);
                    comando.Parameters.AddWithValue("@complemento", clientes.Complemento);
                    comando.Parameters.AddWithValue("@bairro", clientes.Bairro);
                    comando.Parameters.AddWithValue("@cidade", clientes.Cidade);
                    comando.Parameters.AddWithValue("@estado", clientes.Estado);
                    comando.Parameters.AddWithValue("@ativo", clientes.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }


            }
        }
    }
}
