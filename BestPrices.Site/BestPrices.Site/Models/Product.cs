using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class Product
    {
        [Key, Required]
        public string IdProduct { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string PathPhoto { get; set; }

        [Required]
        public string Link { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string IdEcommerce { get; set; }
    }
}
