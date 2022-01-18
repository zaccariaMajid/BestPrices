using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.History
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
            User = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Daniel",
                Email = "giuggiolidaniel@gmail.com"
            };
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Palla da calcio",
                    Description = "......",
                    PathPhoto = "path",
                    Price = 13.99m,
                    IdEcommerce = Guid.NewGuid().ToString(),
                    Link = "https://www.atalanta.it/scuola-allo-stadio/",
                    Date = DateTime.Now
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Felpa",
                    Description = "......",
                    PathPhoto = "path",
                    Price = 25.99m,
                    IdEcommerce = Guid.NewGuid().ToString(),
                    Link = "https://www.atalanta.it/scuola-allo-stadio/",
                    Date = new DateTime(2022, 1, 24)
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Orologio",
                    Description = "......",
                    PathPhoto = "path",
                    Price = 13.29m,
                    IdEcommerce = Guid.NewGuid().ToString(),
                    Link = "https://www.atalanta.it/scuola-allo-stadio/",
                    Date = new DateTime(2021, 11, 2)
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "T-Shirt",
                    Description = "......",
                    PathPhoto = "path",
                    Price = 7.99m,
                    IdEcommerce = Guid.NewGuid().ToString(),
                    Link = "https://www.atalanta.it/scuola-allo-stadio/",
                    Date = new DateTime(2022, 1, 6)
                }
            };
            Products = Products.OrderByDescending(x => x.Date).ToList();
        }
        public new User User { get; set; }
        public IList<Product> Products { get; set; }
        public void OnGet()
        {
        }
    }
}
