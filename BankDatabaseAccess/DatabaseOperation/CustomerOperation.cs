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
        /// <param name="personModel">Take an Customer Object</param>
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

        public int Delete(PersonModel personModel)
        {
            //user cant delete his own account
            throw new NotImplementedException();
        }


        public int Update(PersonModel personModel)
        {
            var query = @"UPDATE dbo.[dbo.Customers] SET 
                        FullName = '" + personModel.FullName + "'," +
                         "Email = '" + personModel.Eamil + "'," +
                         "Phone = '" + personModel.Phone + "'," +
                         "Nid = '" + personModel.Nid + "'," +
                         "Address = '" + personModel.Address + "'" +
                         " WHERE '" + personModel.Username + "' = Username"; ;
            return DatabaseConnection.Execute(query);
        }

        public int UpdateBalance(PersonModel personModel, decimal amount)
        {
            var query = @"UPDATE dbo.[dbo.Customers] SET 
                        Balance = '" + amount + "'" +
                         " WHERE Username = '" + personModel.Username +"'";
            return DatabaseConnection.Execute(query);
        }
    }
}
