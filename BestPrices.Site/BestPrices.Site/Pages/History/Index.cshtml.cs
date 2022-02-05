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
        public IList<ProductHistoryDto> Products { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            Products = new List<ProductHistoryDto>();
            if (User == null)
                return Page();

            var userProducts = _context.UsersProducts.Where(x => x.IdUser == User.Id).ToList();
            foreach (var p in _context.Products)
            {
                var matchingUp = userProducts.Where(x => x.IdProduct == p.Id).ToList();
                foreach (var up in matchingUp)
                {
                    Products.Add(new ProductHistoryDto()
                    {
                        Date = up.Date,
                        Name = p.Name,
                        Link = p.Link
                    });
                }

            }
            return Page();
        }
    }
}
