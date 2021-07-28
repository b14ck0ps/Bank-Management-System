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
        /// Update User Balance
        /// </summary>
        /// <param name="personModel">Take an Customer Object</param>
        /// <param name="amount">Take amount of money to deposit</param>
        int UpdateBalance(EntityModel.PersonModel personModel, decimal amount);
    }
}
