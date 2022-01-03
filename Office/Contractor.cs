using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Contractor
    {
        public string fullName;
        public int IdentifiedNumber;
        public string email;
        public string CompanyName;

        public Contractor(string fullName, int identifiedNumber, string email, string companyName)
        {
            this.fullName = fullName;
            IdentifiedNumber = identifiedNumber;
            this.email = email;
            CompanyName = companyName;
        }
    }
}
