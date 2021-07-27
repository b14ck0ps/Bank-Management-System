using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabaseAccess
{
    public static class DatabaseConnection
    {
        public static readonly string Connection = System.Configuration.ConfigurationManager.ConnectionStrings["OpenBankLocal"].ConnectionString;

       public enum Error
        {
            UsernameExist = 4001
        }

        public static int Execute(string query)
        {
            using (var connection = new SqlConnection(Connection))
            {
                try
                {
                    connection.Open();
                    return new SqlCommand(query, connection).ExecuteNonQuery();
                }
                catch (SqlException)
                {
                   return (int)Error.UsernameExist;
                }

            }
        }
    }
}
