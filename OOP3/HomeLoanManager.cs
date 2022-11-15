using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HomeLoanManager : ILoanManager //Home Loan Manager is a Loan Manager. Now we can use Calculate method of Loan Manager in HomeLoanManager.
                                                  //So we don't need to create Calculate method again and again for different type of Loans.
    {
        public void Calculate()
        {
            Console.WriteLine("Home Loan Payment Plan Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
