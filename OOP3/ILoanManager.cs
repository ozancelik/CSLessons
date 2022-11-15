using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // interfaces can also store reference numbers of classes that implement it.
    // interfaces are used for situations that are alternatives to each other and have different code contents.
    // in this example, every Loan Type has Calculate method, but all have different code, they have different interest rate, file cost etc.
    interface ILoanManager //When the signature() is same, but the inside of method is different, we use interface instead of class
                           //we use interface as template
                           //to increase legibility, we added 'I' letter right to the beginning.
    {
        void Calculate();

        void DoSomething();

    }
}
