using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabaseAccess.DatabaseOperation
{
    interface IOperations
    {
        /// <summary>
        /// Insert Data to the database
        /// </summary>
        /// <param name="personModel">Customer or Employee Model</param>
        /// <returns></returns>
        int Insert(EntityModel.PersonModel personModel);
        /// <summary>
        /// Update data from databse
        /// </summary>
        /// <param name="personModel">Customer or Employee Model</param>
        /// <returns></returns>
        int Update(EntityModel.PersonModel personModel);
        /// <summary>
        /// Delete data from database
        /// </summary>
        /// <param name="personModel">Customer or Employee Model</param>
        /// <returns></returns>
        int Delete(EntityModel.PersonModel personModel);

    }
}
