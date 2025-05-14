namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*Example of Tight coupling
            var reportService = new ReportService();
            reportService.SendReport();*/

            IEmailService emailService = new EmailService();//or SmsService, or MockService
            ReportService reportService = new ReportService(emailService);
            reportService.SendReport();
        }
    }
}
