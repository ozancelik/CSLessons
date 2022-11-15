namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // interfaces can also store reference numbers of classes that implement it.
            // interfaces are used for situations that are alternatives to each other and have different code contents.
            // this approach ensures sustainability in software


            ILoanManager personalLoanManager = new PersonalLoanManager();
            ILoanManager carLoanManager = new CarLoanManager();
            ILoanManager homeLoanManager = new HomeLoanManager();
            ILoanManager businessLoanManager = new BusinessLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService() } ;

            ApplicationManager applicationManager = new ApplicationManager();

            applicationManager.Apply(businessLoanManager, loggers );

            List<ILoanManager> loans = new List<ILoanManager>() { personalLoanManager, carLoanManager };
            
            //applicationManager.MakeLoanPreInformation(loans);

        }
    }
}