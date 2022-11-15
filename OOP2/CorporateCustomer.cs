using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance
    internal class CorporateCustomer:Customer // means that Corporate Customer is a Customer, now properties of Customer also exist in Corporate Customer!!. they all inherited!
                                              // CorporateCustomer extends Customer.
    {
        public string CorporateName { get; set; }
        public string TaxNumber { get; set; }

    }
}
