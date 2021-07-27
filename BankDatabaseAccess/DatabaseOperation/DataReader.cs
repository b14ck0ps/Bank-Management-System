using System.Data.SqlClient;
using System.Data;

namespace BankDatabaseAccess.DatabaseOperation
{
    public class DataReader
    {
        private string query;
        /// <summary>
        /// This method read data from the data base
        /// </summary>
        /// <param name="personModel">Enter a person model ie. Employee or Customer</param>
        /// <param name="customer">This is true if customer data needed</param>
        /// <param name="employee">This is true if eployee data nedded</param>
        /// <returns>This return a datatable of the given object from the database</returns>
        public DataTable GetData(EntityModel.PersonModel personModel,bool customer,bool employee)
        {
            if (customer)
            {
                query = @"SELECT * 
                        FROM dbo.[dbo.Customers] 
                        WHERE Username = '" + personModel.Username + "'";
            }
            if (employee)
            {
                query = @"SELECT * 
                        FROM dbo.[dbo.Employee] 
                        WHERE Username = '" + personModel.Username + "'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(query, DatabaseConnection.Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
