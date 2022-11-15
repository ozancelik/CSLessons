using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class CarLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Car Loan Payment Plan Calculated"); 
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
