using BestPrices.Site.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace BestPrices.Site.Api
{
    public class ApiManager
    {
        public IList<Product> GetProducts(string text)
        {
            //api url = somee

            string apiUrl = "https://localhost:44349/Products/" + text; // + text in url aggiungere in appconfig
            string jsonString = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            string token = ""; // aggiungere in appconfig
            request.Headers.Add("Authorization", $"Bearer {token}");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                jsonString = reader.ReadToEnd();
            return ToApiResult(JsonConvert.DeserializeObject<Result>(jsonString)).Data.ToList();

            //return new List<Product>()
            //{
            //    new Product()
            //    {
            //        Name = "Pallone",
            //        Price = "€20.00",
            //        PathPhoto = "/img/prova.jpg",
            //        Link = "https://docs.microsoft.com/it-it/aspnet/core/security/gdpr?view=aspnetcore-5.0",
            //        IdEcommerce = "A"
            //    },
            //    new Product()
            //    {
            //        Name = "Casa",
            //        Price = "€200.00",
            //        PathPhoto = "http://www.starcoppe.it/images/grafica-immagine-b.jpg",
            //        Link = "https://docs.microsoft.com/it-it/aspnet/core/security/gdpr?view=aspnetcore-5.0",
            //        IdEcommerce = "B"
            //    }
            //};
        }

        ApiResult ToApiResult(Result input)
        {
            var result = new ApiResult();
            result.Data = input.Results.Select(x => new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = x.Name,
                Price = x.Price,
                PathPhoto = x.PathPhoto,
                Link = x.Link,
                IdEcommerce = x.IdEcommerce
            }).ToArray();
            return result;
        }
    }

    public class Result
    {
        public Results[] Results { get; set; }
    }
    public class Results
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string PathPhoto { get; set; }
        public string Link { get; set; }
        public string IdEcommerce { get; set; }
    }

    public class ApiResult
    {
        public Product[] Data { get; set; }
    }
}
