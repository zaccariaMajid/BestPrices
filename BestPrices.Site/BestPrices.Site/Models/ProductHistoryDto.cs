using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class ProductHistoryDto
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
