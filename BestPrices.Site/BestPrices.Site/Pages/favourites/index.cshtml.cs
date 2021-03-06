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
                var userProducts = _context.UsersProducts.OrderByDescending(x => x.Date).ToList();
                IList<string> IdProducts = userProducts.Where(x => x.IdUser == User.Id && x.IsFavourite)
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

        /// <summary>
        /// Pages/Favourites/Index?handler=SetFavorite&userId={userId}&productId={productId}
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IActionResult OnGetSetFavorite(string userId, string productId)
        {
            var u = _context.UsersProducts
                .Where(x => x.IdUser == userId && x.IdProduct == productId)
                .FirstOrDefault();

            u.IsFavourite = true;

            _context.SaveChanges();

            return Content("true");
        }

        /// <summary>
        /// Pages/Favourites/Index?handler=DeleteFavorite&userId={userId}&productId={productId}
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IActionResult OnGetDeleteFavorite(string userId, string productId)
        {
            var u = _context.UsersProducts
                .Where(x => x.IdUser == userId && x.IdProduct == productId)
                .FirstOrDefault();

            u.IsFavourite = false;

            _context.SaveChanges();

            return Content("true");
        }
    }
}
