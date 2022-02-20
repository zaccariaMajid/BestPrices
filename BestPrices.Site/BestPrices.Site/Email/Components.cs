using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Email
{
    public static class Components
    {
        public static string NameSender = "BestPrices Developer";
        public static string Sender = "bestpricesitispaleocapa";
        public static string Subject = "Email verification";
        public static string User = "User";
        public static string Body = $"Hi {User}, welcome on BestPrices!\nClick into the link to verify your email address and enable your account";
    }
}
