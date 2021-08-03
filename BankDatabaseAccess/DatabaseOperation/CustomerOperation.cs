using BankDatabaseAccess.EntityModel;
using System;

namespace BankDatabaseAccess.DatabaseOperation
{
    
    public class CustomerOperation : IOperations , ITransaction
    {
        private const decimal InitialBalance = 100;
        /// <summary>
        /// This method is use for Customers Registration Purpose.
        /// </summary>
        /// <param name="personModel">Take a Customer Object</param>
        /// <returns>Return Row Number</returns>
        public int Insert(PersonModel personModel)
        {
            var query = @"INSERT INTO dbo.[dbo.Customers](Username,Fullname,Password,Email,Phone,Nid,Address,Balance) 
                          VALUES ('" + personModel.Username + "'," +
                          "'" + personModel.FullName + "'," +
                          "'" + personModel.Password + "'," +
                          "'" + personModel.Eamil + "'," +
                          "'" + personModel.Phone + "'," +
                          "'" + personModel.Nid + "'," +
                          "'" + personModel.Address + "'," +
                          "'" + InitialBalance + "')"; // Set Opening Balance 1000 taka for all customers
            return DatabaseConnection.Execute(query);
        }
        /// <summary>
        /// Delete a user from data base
        /// </summary>
        /// <param name="personModel">Take a Customer Object</param>
        /// <returns>row effect</returns>
        public int Delete(PersonModel personModel)
        {
           return new EmployeeOperations().Delete(personModel);
        }

        /// <summary>
        /// Update a user form data base
        /// </summary>
        /// <param name="personModel">Take a Customer Object</param>
        /// <returns>row effect</returns>
        public int Update(PersonModel personModel)
        {
            var query = @"UPDATE dbo.[dbo.Customers] SET 
                         Email = '" + personModel.Eamil + "'," +
                         "Phone = '" + personModel.Phone + "'," +
                         "Nid = '" + personModel.Nid + "'," +
                         "Address = '" + personModel.Address + "'" +
                         " WHERE '" + personModel.Username + "' = Username"; ;
            return DatabaseConnection.Execute(query);
        }
        /// <summary>
        /// Update customer balance
        /// </summary>
        /// <param name="personModel">Take a Customer Object</param>
        /// <param name="amount"></param>
        /// <returns>row effected</returns>
        public int UpdateBalance(PersonModel personModel, decimal amount)
        {
            var query = @"UPDATE dbo.[dbo.Customers] SET 
                        Balance = '" + amount + "'" +
                         " WHERE Username = '" + personModel.Username +"'";
            return DatabaseConnection.Execute(query);
        }
    }
}
