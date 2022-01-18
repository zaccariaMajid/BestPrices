using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PathPhoto { get; set; }
        public decimal Price { get; set; }
        public string IdEcommerce { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
    }
}
