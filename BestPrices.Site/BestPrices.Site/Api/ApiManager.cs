using BestPrices.Site.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Api
{
    public class ApiManager
    {
        public IList<Product> GetProducts(string text)
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Pallone",
                    Description = "description",
                    Price = 20.00m,
                    PathPhoto = "/img/prova.jpg",
                    Link = "https://docs.microsoft.com/it-it/aspnet/core/security/gdpr?view=aspnetcore-5.0",
                    IdEcommerce = "a"
                },
                new Product()
                {
                    Name = "Casa",
                    Description = "description",
                    Price = 200.00m,
                    PathPhoto = "/img/prova.jpg",
                    Link = "https://docs.microsoft.com/it-it/aspnet/core/security/gdpr?view=aspnetcore-5.0",
                    IdEcommerce = "b"
                },
            };
        }
    }
}
