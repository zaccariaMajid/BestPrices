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
        [BindProperty]
        public new User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var cookies = HttpContext.Request.Cookies;
            try
            {
                User = _context.Users.SingleOrDefault(x => x.Id == cookies[CookiesManager.CurrentUserId]);
            }
            catch
            {
                User = null;
            }
            return Page();
        }
    }
}
