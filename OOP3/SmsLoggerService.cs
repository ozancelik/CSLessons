﻿namespace OOP3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS sent to the customer");
        }
    }


}