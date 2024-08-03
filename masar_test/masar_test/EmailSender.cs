using System.Net.Mail;
using System.Net;

namespace SendingEmails
{

    class Program
    {
        static void Main(string[] args) {

            string frommail = "mktiito.o@gmail.com";
            string frompass = "tiito#2004";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(frommail);
            message.Subject = "test";
            message.To.Add(new MailAddress("mktiito2004@gmail.com"));
            message.Body = "<html><body> Kosmaak ya hazem </body></html>";
            message.IsBodyHtml = true; 

            var smtpClient = new smtpClient ("smtp.gmail.com");
            {

                Port = 587,
                    Credentials = new NetworkCredentials(frommail, frompass),
                    EnableSsl = true,
            };


            smtpClient.send(message);


        }

    }

    /*public class EailSender : IEmailSender
    {

        public Task SendEmailAsync(string email, string subject, string message) {
            var mail = "mktiito.o@gmail.com";
            var pw = "tiito#2004";
            var client = new SmtpClient("mktiito2004@gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential (mail,pw)
            };f

            return client.SendAsync(new MailMassage(from: mail, to: email, subject, message));
                
        
        }

    }*/


        


}
