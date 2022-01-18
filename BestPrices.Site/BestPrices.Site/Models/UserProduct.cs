using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class UserProduct
    {
        public string IdUser { get; set; }
        public string IdProduct { get; set; }
        public bool IsFavourite { get; set; }
    }
}
