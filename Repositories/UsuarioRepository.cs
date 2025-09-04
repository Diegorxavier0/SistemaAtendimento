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
   public class UsuarioRepository
    {
        public List<Usuarios> Listar()
        {
            var usuarios = new List<Usuarios>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Usuarios";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            usuarios.Add(new Usuarios()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Senha = linhas["senha"].ToString(),
                                Perfil = linhas["perfil"].ToString(),
                            });
                        }
                    }
                }
                return usuarios;

            }

        }






    }
}
