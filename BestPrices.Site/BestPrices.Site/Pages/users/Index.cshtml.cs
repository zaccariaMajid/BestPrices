using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.users
{
    public class IndexModel : PageModel
    {
        private readonly PriceDbContext _context;
        public IndexModel(PriceDbContext context)
        {
            _context = context;
        }

        public new User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var cookies = HttpContext.Request.Cookies;
            var userId = cookies[CookiesManager.UserIdKey];
            try
            {
                User = _context.Users.SingleOrDefault(x => x.Id == userId);
            }
            catch
            {
                User = null;
            }
            return Page();
        }
        public async Task<IActionResult>OnPostAsync()
        {
            var cookies = Response.Cookies;
            var index = CookiesManager.UserIdKey;
            var options = new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
                IsEssential = true,
                Secure = true
            };
            cookies.Append(index, string.Empty, options);
            return Page();
        }
    }
}
