using System.Net;
using System.Net.Mail;
using mailSender.Interface;
namespace mailSender.Services
{
    public class Mail : IMail
    {
        public Task SendEmailAsync(string email, string subject, string message, string mail, string password)
        {
            System.Console.WriteLine(mail);
            System.Console.WriteLine(password);
            var client = new SmtpClient("smtp.gmail.com",587);
            client.EnableSsl=true;
            client.Credentials= new NetworkCredential(mail,password);
            MailMessage mailMsg = new MailMessage();
            mailMsg.To.Add(email);
            mailMsg.Subject=subject;
            mailMsg.Body = message;
            //client.Send(mailMsg);
            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                mailMsg.Subject,
                                mailMsg.Body
                                ));            
        }
    }
}