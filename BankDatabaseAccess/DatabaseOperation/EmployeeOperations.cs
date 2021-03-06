using BankDatabaseAccess.EntityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabaseAccess.DatabaseOperation
{
    public class EmployeeOperations : IOperations
    {
        /// <summary>
        /// This method is use for Employee Registration purpose 
        /// </summary>
        /// <param name="personModel">Take an Employee Object</param>
        /// <returns>Returns Row Number</returns>
        public int Insert(PersonModel personModel)
        {
            var query = @"INSERT INTO dbo.[dbo.Employee](Username,FullName,Password,Email,Address,Phone,Nid,Salary) 
                          VALUES ('" + personModel.Username + "'," +
                          "'" + personModel.FullName + "'," +
                          "'" + personModel.Password + "'," +
                          "'" + personModel.Eamil + "'," +
                          "'" + personModel.Address + "'," +
                          "'" + personModel.Phone + "'," +
                          "'" + personModel.Nid + "'," +
                          "'" + new Random().Next(30000, 1000000).ToString() + "')"; // generates Salary from 30k to 100k
                          return DatabaseConnection.Execute(query);
        }
        /// <summary>
        /// This method is use for Deleting an existing Customer account form dashboard
        /// </summary>
        /// <param name="personModel">Takes an Customer Object</param>
        /// <returns>Returns Row Number</returns>
        public int Delete(PersonModel personModel)
        {
            var query = @"DELETE FROM dbo.[dbo.Customers] 
                        WHERE Username = '" + personModel.Username +"'";
            return DatabaseConnection.Execute(query);
        }
        /// <summary>
        /// THis method is use for update an existing Customer Account from dashboard
        /// </summary>
        /// <param name="personModel">Takes an Customer Object</param>
        /// <returns>Returns Row Number</returns>
        public int Update(PersonModel personModel)
        {
            var query = @"UPDATE dbo.[dbo.Customers] SET 
                        Email = '" + personModel.Eamil + "'," +
                        "Phone = '" + personModel.Phone + "'," +
                        "Address = '" + personModel.Address + "'," +
                        "Nid = '" + personModel.Nid + "'" +
                        "WHERE Username = '" + personModel.Username + "'";

            return DatabaseConnection.Execute(query);
        }
        /// <summary>
        /// Update Employee's data from db
        /// </summary>
        /// <param name="personModel">takes an employee object</param>
        /// <returns></returns>
        public int SelfUpdate(PersonModel personModel)
        {
            var query = @"UPDATE dbo.[dbo.Employee] SET 
                        Email = '" + personModel.Eamil + "'," +
                        "Phone = '" + personModel.Phone + "'," +
                        "Address = '" + personModel.Address + "'," +
                        "Nid = '" + personModel.Nid + "'" +
                        "WHERE Username = '"+ personModel.Username +"'";
            return DatabaseConnection.Execute(query);
        }
    }
}
