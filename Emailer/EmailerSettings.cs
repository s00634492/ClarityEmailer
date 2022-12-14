using System;
using System.Collections.Generic;
using System.Text;

namespace Emailer
{
    public class EmailerSettings
    {
        public string Sender { get; set; }
        public string SmtpServer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
