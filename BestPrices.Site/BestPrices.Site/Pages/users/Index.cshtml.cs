
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
        public int FavCount { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            FavCount = _context.UsersProducts.Where(x => x.IdUser == User.Id && x.IsFavourite)
                                             .ToList()
                                             .Count;
            return Page();
        }
        public async Task<IActionResult>OnPostAsync()
        {
            var cookies = Response.Cookies;
            var index = CookiesManager.UserIdKey;
            var options = CookiesManager.CookieOptions;
            cookies.Append(index, string.Empty, options);
            return Page();
        }
    }
}
