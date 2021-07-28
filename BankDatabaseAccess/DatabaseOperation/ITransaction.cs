using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabaseAccess.DatabaseOperation
{
    interface ITransaction
    {
        /// <summary>
        /// Deposit money from Customer balance
        /// </summary>
        /// <param name="personModel">Take an Customer Object</param>
        /// <param name="amount">Take amount of money to deposit</param>
        int Deposit(EntityModel.PersonModel personModel, decimal amount);
        /// <summary>
        /// Withdraw money from Customer balance
        /// </summary>
        /// <param name="personModel">Take an Customer Object</param>
        /// <param name="amount">Take amount of money to withdraw</param> 
        int Withdraw(EntityModel.PersonModel personModel, decimal amount);
    }
}
