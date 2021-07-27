using BankDatabaseAccess.EntityModel;
using System;

namespace BankDatabaseAccess.DatabaseOperation
{
    public class CustomerOperation : IOperations , ITransaction
    {
        /// <summary>
        /// This method is use for Customers Registration Purpose.
        /// </summary>
        /// <param name="personModel">Take an Customer Object</param>
        /// <returns>Return Row Number</returns>
        public int Insert(PersonModel personModel)
        {
            decimal initialBalance = 1000;
            var query = @"INSERT INTO dbo.[dbo.Customers](Username,Password,Email,Phone,Nid,Balance) 
                          VALUES ('" + personModel.Username + "'," +
                          "'" + personModel.Password + "'," +
                          "'" + personModel.Eamil + "'," +
                          "'" + personModel.Phone + "'," +
                          "'" + personModel.Nid + "'," +
                          "'" + initialBalance + "')"; // generates Opening Balance from 500 to 1k
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
                        Email = '" + personModel.Eamil + "'," +
                         "Phone = '" + personModel.Phone + "'," +
                         "Nid = '" + personModel.Nid + "'" +
                         " WHERE '" + personModel.Username + "' = Username"; ;
            return DatabaseConnection.Execute(query);
        }

        public int Deposit(CustomerModel personModel, decimal amount)
        {
            var query = @"UPDATE dbo.[dbo.Customers] SET 
                        Balance = '" + amount + "'," +
                         " WHERE '"+ personModel.Username +"' = Username";
            return DatabaseConnection.Execute(query);
        }

        public int Withdraw(CustomerModel personModel, decimal amount)
        {
            //TODO - Withdraw Logic 
            throw new NotImplementedException();
        }
    }
}
