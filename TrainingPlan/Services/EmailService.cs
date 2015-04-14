using System.Net;
using System.Net.Mail;


namespace TrainingPlan.Services
{
    public class EmailService
    {
        private readonly SmtpClient _client;

        public EmailService()
        {
            _client = new SmtpClient();
        }

        public void SendEmail(string subject, string body)
        {
            var mail = new MailMessage();

            var smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Credentials = new System.Net.NetworkCredential("webmasterbtbtraining@gmail.com", "password@!!");
            smtpServer.Port = 587; // Gmail works on this port
            smtpServer.EnableSsl = true;

            mail.From = new MailAddress("webmasterbtbtraining@gmail.com");
            mail.To.Add("nam.vu@bbc.com");
            mail.Subject = subject;
            mail.Body = body;

            smtpServer.Send(mail);

            //var message = new MailMessage("webmasterbtbtraining@gmail.com", "nam.vu@bbc.com")
            //    {
            //        Subject = "What Up, Dog?",
            //        Body = "Why you gotta be all up in my grill?"
            //    };
            //var mailer = new SmtpClient("smtp.gmail.com")
            //    {
            //        Credentials = new NetworkCredential("webmasterbtbtraining@gmail.com", "password@!!"),
            //        Port = 465,
            //        EnableSsl = true
            //    };

            //mailer.Send(message);
        }
    }
}