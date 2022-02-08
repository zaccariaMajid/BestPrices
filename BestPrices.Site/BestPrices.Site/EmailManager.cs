using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Net.Pop3;
using MailKit.Security;

namespace BestPrices.Site
{
    public class EmailManager
    {
        public async Task SendEmail(EmailComponents components, EmailCredentials credentials)
        {
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(components.NameSender, components.Sender));
            msg.To.Add(new MailboxAddress(components.NameRecipient, components.Recipient));
            msg.Subject = components.Subject;
            msg.Body = new TextPart()
            {
                Text = components.Body
            };
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.Auto);
                await client.AuthenticateAsync(credentials.Username, credentials.Password);
                await client.SendAsync(msg);
                await client.DisconnectAsync(true);
            }
        }
        //public static void SendEmail(EmailComponents components)
        //{
        //    string to = components.Sender;
        //    string from = components.Recipient;
        //    MailMessage message = new MailMessage(from, to);
        //    message.Subject = components.Subject;
        //    message.Body = components.Body;
        //    SmtpClient client = new SmtpClient(components.Server);
        //    // Credentials are necessary if the server requires the client
        //    // to authenticate before it will send email on the client's behalf.
        //    client.UseDefaultCredentials = true;

        //    try
        //    {
        //        client.Send(message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
        //            ex.ToString());
        //    }
        //}
    }

    public struct EmailCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public struct EmailComponents
    {
        public string NameSender { get; set; }
        public string Sender { get; set; }
        public string NameRecipient { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
