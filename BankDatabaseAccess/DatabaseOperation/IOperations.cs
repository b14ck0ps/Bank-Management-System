using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabaseAccess.DatabaseOperation
{
    interface IOperations
    {

        int Insert(EntityModel.PersonModel personModel);
        int Update(EntityModel.PersonModel personModel);
        int Delete(EntityModel.PersonModel personModel);

    }
}
