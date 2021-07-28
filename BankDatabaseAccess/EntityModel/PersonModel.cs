using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabaseAccess.EntityModel
{
    public abstract class PersonModel
    {
        /// <summary>
        /// This is the Person Username. Value can not be null.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// This is the Person Password. Value can not be null.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// This is the person Email. Value can not be null.
        /// </summary>
        public string Eamil { get; set; }
        /// <summary>
        /// This is person phone number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// This is person National ID number. Value can not be null.
        /// </summary>
        public string Nid { get; set; }
        /// <summary>
        /// This is person Address. Value cant be null.
        /// </summary>
        public string Address { get; set; }
    }
}
