using System.Data.SqlClient;
using System.Data;

namespace BankDatabaseAccess.DatabaseOperation
{
    public class DataReader
    {
        private string query;
        private  DataTable DataTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, DatabaseConnection.Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        /// <summary>
        /// This method read data from the data base
        /// </summary>
        /// <param name="personModel">Enter a person model ie. Employee or Customer</param>
        /// <param name="customer">This is true if customer data needed</param>
        /// <param name="employee">This is true if eployee data nedded</param>
        /// <returns>This return a datatable of the given object from the database</returns>
        public DataTable GetSingleData(EntityModel.PersonModel personModel,bool customer,bool employee)
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
            return DataTable();
        }
        /// <summary>
        /// This method read the whole data from a table
        /// </summary>
        /// <param name="customer">Set True if Customer data table needed</param>
        /// <param name="employee">Set True id Employee data needed</param>
        /// <returns>Return all Coloumns and rows from the table</returns>
        public DataTable GetAllData(bool customer = false, bool employee = false)
        {
            if (customer)
            {
                query = @"SELECT * 
                      FROM dbo.[dbo.Customers]";
            }
            if (employee)
            {
                query = @"SELECT * 
                      FROM dbo.[dbo.Employee]";
            }
            return DataTable();
        }
    }
}
