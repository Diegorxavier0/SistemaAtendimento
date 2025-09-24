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
        }   public void Inserir(Clientes cliente)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO clientes (nome, email, cpf_cnpj, tipo_pessoa, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado, ativo) VALUES (@nome, @email, @cpf_cnpj, @tipo_pessoa, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @ativo)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", cliente.Cpf_Cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", cliente.TipoPessoa);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@celular", cliente.Celular);
                    comando.Parameters.AddWithValue("@cep", cliente.Cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@complemento", cliente.Complemento);
                    comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@ativo", cliente.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();

                   
                }


            }
        }

        public void Atualizar(Clientes cliente)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE clientes SET nome = @nome, email = @email, cpf_cnpj = @cpf_cnpj, tipo_pessoa = @tipo_pessoa, telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, ativo = @ativo WHERE id= @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", cliente.Cpf_Cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", cliente.TipoPessoa);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@celular", cliente.Celular);
                    comando.Parameters.AddWithValue("@cep", cliente.Cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@complemento", cliente.Complemento);
                    comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@ativo", cliente.Ativo);
                    conexao.Open();//abre conexão com o banco
                    comando.ExecuteNonQuery();//executa o comando
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM clientes WHERE id = @id";
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
