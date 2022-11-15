using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method Injection
        //Loan and Logger injected
        public void Apply(ILoanManager loanManager, List<ILoggerService>loggerServices)
        {
            // Evaluate applicant information.
            //
            //When we use Home Loan Manager class to calculate applicant payment plan, than Apply class is dependent to the Home Loan Manager class
            //but we have lots of different Loan Types, this is not correct form, so it is not correct approach!!
            //HomeLoanManager homeLoanManager = new HomeLoanManager();
            //homeLoanManager.Calculate();
            //***instead we use ILoanManager, it can keep reference number of all different types of Loan Classes.

            loanManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void MakeLoanPreInformation(List<ILoanManager> loans) //Here we dont know how many different type of Loan queried, so we use List.

        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }

        }
    }
}
