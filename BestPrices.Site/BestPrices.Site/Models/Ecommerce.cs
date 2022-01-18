using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class Ecommerce
    {
        [Key, Required]
        public string IdEcommerce { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Link { get; set; }
    }
}
