using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.users
{
    public class changepasswordModel : PageModel
    {
        private readonly PriceDbContext _context;
        public changepasswordModel(PriceDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string OldPassword { get; set; }
        [BindProperty]
        public string NewPassword { get; set; }
        [BindProperty]
        public string NewPasswordConf { get; set; }
        public User User { get; set; } 
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            return Page();
        }
    }
}
