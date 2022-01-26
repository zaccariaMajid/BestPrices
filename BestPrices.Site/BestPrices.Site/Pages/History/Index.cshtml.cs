using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.History
{
    public class IndexModel : PageModel
    {
        private readonly PriceDbContext _context;
        public IndexModel(PriceDbContext context)
        {
            _context = context;
        }
        public new User User { get; set; }
        public IList<Product> Products { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            if (User == null)
            {
                Products = new List<Product>();
                return Page();
            }
            Products = _context.Products
            .Where(x => _context.UsersProducts
                        .Select(x => x.IdUser)
                        .ToList()
                        .Contains(User.Id) &&
                    _context.UsersProducts
                        .Select(x => x.IdProduct)
                        .ToList()
                        .Contains(x.Id))
            .ToList();
            Products = Products.OrderByDescending(x => x.Date).ToList();
            return Page();
        }
    }
}
