using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DependencyInjection.IEmailService;

namespace DependencyInjection
{
    internal class EmailService : IEmailService
    {
            public void Send(string message)//Implementing the method not overriding 
            {
                Console.WriteLine("EmailService: " + message);
            }


    }
    public class SmsService : IEmailService
    {
        public void Send(string message)//Implementing the method not overriding 
        {
            Console.WriteLine("SmsService: " + message);
        }
    }

    public class MockService : IEmailService
    {
        public void Send(string message)
        {
            Console.WriteLine("Mock message sent: " + message);
        }
    }
}
