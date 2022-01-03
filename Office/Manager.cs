using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Manager
    {
		public string firstName;
		public string lastName;
		public string dateBorn;
		public string email;
		public int class1;

        public Manager(string firstName, string lastName, string dateBorn, string email, int class1)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateBorn = dateBorn;
            this.email = email;
            this.class1 = class1;
        }
    }
}
