using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Net.Pop3;
using MailKit.Security;
using MailKit;

namespace BestPrices.Site.Email
{
    public class EmailManager
    {
        public bool SendEmail(EmailComponents components, EmailCredentials credentials)
        {
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(components.NameSender, components.Sender));
            msg.To.Add(MailboxAddress.Parse(components.Recipient));
            msg.Subject = components.Subject;
            msg.Body = new TextPart("plain")
            {
                Text = components.Body
            };

            using (var client = new SmtpClient())
            {
                bool toReturn;
                try
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate(credentials.Username, credentials.Password);
                    client.Send(msg);
                    toReturn = true;
                }
                catch (Exception ex)
                {
                    var error = ex.Message;
                    toReturn = false;
                }
                finally
                {
                    client.Disconnect(true);
                }
                return toReturn;
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
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
