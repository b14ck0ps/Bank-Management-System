using System.Data.SqlClient;
using System.Data;

namespace BankDatabaseAccess.DatabaseOperation
{
    public class DataReader
    {
        private string query = "--";
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
            query = @"SELECT * 
                        FROM dbo.[dbo."+ Table(customer,employee) +"] " +
                        "WHERE Username =  '"+ personModel.Username +"'";
            return DataTable();
        }
        /// <summary>
        /// This method read the whole data from a table exept Passwords
        /// </summary>
        /// <param name="customer">Set True if Customer data table needed</param>
        /// <param name="employee">Set True id Employee data needed</param>
        /// <returns>Return all Coloumns and rows from the table</returns>
        public DataTable GetAllData(bool customer = false, bool employee = false)
        {
                query = @"SELECT 
                             [FullName] AS 'Full Name'
                            ,[Email] AS 'Email Address'
                            ,[Phone] AS 'Phone Number'
                            ,[Nid] AS 'National ID'
                            ,[Balance] AS Balance
                            ,[Address] AS Address
                            ,[JoinDate] AS 'Account Created'
                        FROM dbo.[dbo." + Table(customer,employee) +"]";
            return DataTable();
        }
        /// <summary>
        /// This declare from which table data will be read
        /// </summary>
        /// <param name="customer">True if customer table needed</param>
        /// <param name="employee">True if employee table needed</param>
        /// <returns>Return The Table name as a string</returns>
        private string Table(bool customer, bool employee)
        {
            if (customer)
                return "Customers";
            if (employee)
                return "Employee";
            return null;
        }
    }
}
