using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DependencyInjection.IEmailService;

namespace DependencyInjection
{
    public class ReportService
    {
        private readonly IEmailService _emailService;


        /*
                public ReportService()
                {
                    _emailService = new EmailService(); // ❗ Hardcoded - tight coupling
                    _emailService = new SmsService();
                }*/


        public ReportService(IEmailService emailService)//Loosely Couples
        {
            _emailService = emailService;
        }
        public void SendReport()
        {
            
            _emailService.Send("Sending report...");
        }
    }

}
