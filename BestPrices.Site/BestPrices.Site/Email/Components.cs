using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Email
{
    public class Components
    {
        public Components(string user) => User = user;
        public string NameSender { get => "BestPrices Developer"; }
        public string Sender { get => "bestpricesitispaleocapa"; }
        public string Subject { get => "Email verification"; }
        public string User { get; set; }
        public string Body { get => $"Hi {User}, welcome on BestPrices!\nClick into the link to verify your email address and enable your account"; }
    }
}
