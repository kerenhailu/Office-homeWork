using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Employee
    {
        public string name;
        public string yearBorn;
        public string email;
        public int wage;

        public Employee(string name, string yearBorn, string email, int wage)
        {
            this.name = name;
            this.yearBorn = yearBorn;
            this.email = email;
            this.wage = wage;
        }
    }
}
