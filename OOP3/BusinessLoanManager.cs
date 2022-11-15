using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BusinessLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Business Loan Payment Plan Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
