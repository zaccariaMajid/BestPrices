using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Pages
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
    }
}
