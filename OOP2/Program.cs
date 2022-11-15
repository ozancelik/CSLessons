namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNr = "12345";
            individualCustomer1.Name = "Ozan";
            individualCustomer1.Surname = "Çelik";
            individualCustomer1.TcNo = "1234567890";

            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 2;
            corporateCustomer1.CustomerNr = "123123";
            corporateCustomer1.CorporateName = "kodlama.io";
            corporateCustomer1.TaxNumber = "1212";

            //now Customer class can store for both reference number of individual and corporate type customers.
            //  = new ClassName means; assign reference number of memory for that class to left handside.
            Customer customer3 = new IndividualCustomer();

            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(corporateCustomer1);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            


        }
    }
}