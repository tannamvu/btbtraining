using System.Net;
using System.Net.Mail;
using SendGrid;

namespace TrainingPlan.Services
{
    public class EmailService
    {
        private const string Username = "azure_8aa224a4adff9b6f22626db352f958b7@azure.com";
        private const string Pswd = "9fOVb781UeTzPvX";

        public static void SendEmail(string subject, string body)
        {
            var credentials = new NetworkCredential(Username, Pswd);

            //todo: Make this asynchronous 
            
            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();
            myMessage.AddTo("enquiries@btbtraining.com");
            myMessage.From = new MailAddress("webmaster@btbtraining.com", "Webmaster");
            myMessage.Subject = subject;
            myMessage.Text = body;

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the email.
            transportWeb.DeliverAsync(myMessage);
        }
    }
}