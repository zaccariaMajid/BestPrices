using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.favourites
{
    public class indexModel : PageModel
    {
        private readonly PriceDbContext _context;
        public indexModel(PriceDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public IList<Product> Products { get; set; }
        public User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            if (User != null)
            {
                IList<string> IdProducts = _context.UsersProducts.Where(x => x.IdUser == User.Id && x.IsFavourite == true)
                                                                 .ToList()
                                                                 .Select(y => y.IdProduct)
                                                                 .ToList();
                Products = _context.Products.Where(x => IdProducts.Contains(x.Id))
                                            .ToList();
            }

            return Page();
        }
        public string GetEcommerceById(string id)
        {
            return _context.Ecommerces.SingleOrDefault(x => x.Id == id).Name;
        }
    }
}
