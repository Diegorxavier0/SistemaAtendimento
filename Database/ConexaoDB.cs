using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaAtendimento.Database
{
    public static class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SistemaAtendimentoDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
