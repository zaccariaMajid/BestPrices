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
        public User User { get; set; }
        ApiManager _apiManager { get; set; }

        public IActionResult OnGet()
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
        public string GetEcommerceById(string id)
        {
            return "Amazon";
            //return _context.Sites.SingleOrDefault(x => x.Id == id).Name;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Products = _apiManager.GetProducts(SearchText);
            //foreach (var p in Products)
            //{
            //    _context.Products.Add(p);
            //    if (User != null)
            //        _context.UsersProducts.Add(new UserProduct()
            //        {
            //            Id = Guid.NewGuid().ToString(),
            //            IdProduct = p.Id,
            //            IdUser = User.Id
            //        });
            //    _context.SaveChanges();
            //}
            return Page();
        }
    }
}
