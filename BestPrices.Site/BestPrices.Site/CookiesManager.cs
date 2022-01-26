using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site
{
    public static class CookiesManager
    {
        public static string UserIdKey = "UserId";
        public static CookieOptions CookieOptions = new CookieOptions()
        {
            Expires = DateTime.Now.AddDays(30),
            IsEssential = true,
            Secure = true
        };
        public static User GetUserByCookies(HttpRequest request, PriceDbContext context)
        {
            User user;
            var cookies = request.Cookies;
            var userId = cookies[CookiesManager.UserIdKey];
            try
            {
                user = context.Users.SingleOrDefault(x => x.Id == userId);
            }
            catch
            {
                user = null;
            }
            return user;
        }
    }
}
