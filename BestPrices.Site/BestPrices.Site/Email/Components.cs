using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Email
{
    public class Components
    {
        public Components(string user, string token)
        {
            User = user;
            Token = token;
        }
        public string NameSender { get => "BestPrices Developer"; }
        public string Sender { get => "bestpricesitispaleocapa"; }
        public string Subject { get => "Email verification"; }
        public string User { get; set; }
        public string Token { get; set; }
        public string Body { get => $"Hi {User}, welcome on BestPrices!\nInsert this code into the verification page to verify your identity:\n{Token}"; }
    }
}
