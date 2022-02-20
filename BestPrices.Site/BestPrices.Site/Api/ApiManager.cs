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
        public static string url = "https://localhost:44349/";
        public static async Task<string> PostAsync(string nomeProdotto, string token)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "Products/" + nomeProdotto);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    //string json = JsonConvert.SerializeObject(request);

                    streamWriter.Write(nomeProdotto);
                }

                var httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                List<Product> response = new List<Product>();
                string result = "";
                //CreaTelecameraResponse response;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    //response = JsonConvert.DeserializeObject<List<Product>>(result);
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IList<Product> GetProducts(string text)
        {
            var result = PostAsync(text, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RyaW5nIiwianRpIjoiOGNiYTg4NjctN2NkYS00MzYyLTg5ZjMtZmZjMTg2OTUzN2I4IiwiZXhwIjoxNjc2ODAxMTM5LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjU5OTIxIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwIn0.UOU3QyR758YusBQ06D4E0QuOXxPN2DktE1fA8onYs2g").Result;

            List<Product> response = new List<Product>();

            //api url = somee

            //string apiUrl = "https://localhost:44349/Products/" + text; // + text in url aggiungere in appconfig
            //string jsonString = string.Empty;
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            //string token = ""; // aggiungere in appconfig
            //request.Headers.Add("Authorization", $"Bearer {token}");
            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //using (Stream stream = response.GetResponseStream())
            //using (StreamReader reader = new StreamReader(stream))
            //    jsonString = reader.ReadToEnd();
            return ToApiResult(JsonConvert.DeserializeObject<Result>(result)).Data.ToList();

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
                Link = x.Link,
                PathPhoto = x.PathPhoto,
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
