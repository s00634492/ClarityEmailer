using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    public class Emailer
    {
        EmailerSettings Settings { get; set; }

        public Emailer(EmailerSettings settings)
        {
            Settings = settings;
        }

        public void SendEmail(Email email)
        {
            // format email values
            var from = MailboxAddress.Parse(Settings.Sender);
            var to = MailboxAddress.Parse(email.Recipient);
            var body = new BodyBuilder() { TextBody = email.Body }.ToMessageBody();

            // build mime email object
            var mime = new MimeMessage();
            mime.From.Add(from);
            mime.To.Add(to);
            mime.Subject = email.Subject ?? "";
            mime.Body = body;

            // attempt to send
            var client = new SmtpClient();
            client.Connect(Settings.SmtpServer);
            client.Authenticate(Settings.Username, Settings.Password);
            client.Send(mime);
            client.Disconnect(true);
            client.Dispose();
        }
    }
}
