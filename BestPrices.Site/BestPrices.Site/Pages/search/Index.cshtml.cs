using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Api;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BestPrices.Site.Pages.Research
{
    public class IndexModel : PageModel
    {
        private readonly PriceDbContext _context;
        public IndexModel(PriceDbContext context)
        {
            _context = context;
            _apiManager = new ApiManager();
        }
        [BindProperty]
        public string SearchText { get; set; }
        [BindProperty]
        public IList<Product> Products { get; set; }
        [BindProperty]
        public string ErrorText { get; set; }
        public User User { get; set; }
        ApiManager _apiManager { get; set; }

        public IActionResult OnGet()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            return Page();
        }
        public string GetEcommerceById(string id)
        {
            return _context.Ecommerces.SingleOrDefault(x => x.Id == id).Name;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Products = _apiManager.GetProducts(SearchText);
            ErrorText = string.Empty;
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            foreach (var p in Products)
            {
                var sameProduct = _context.Products.Where(x => x.Link == p.Link && x.Price == p.Price).SingleOrDefault();
                if (sameProduct == null)
                    _context.Products.Add(p);
                if (User != null)
                {
                    var newUserProduct = new UserProduct()
                    {
                        Id = Guid.NewGuid().ToString(),
                        IdProduct = p.Id,
                        IdUser = User.Id,
                        Date = DateTime.Now
                    };
                    _context.UsersProducts.Add(newUserProduct);
                }
                _context.SaveChanges();
            }
            if (Products.Count() == 0)
                ErrorText = $"No product found searching: '{SearchText}'";
            return Page();
        }
    }
}
