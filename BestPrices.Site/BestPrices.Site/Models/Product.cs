using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> Stashed changes
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class Product
    {
<<<<<<< Updated upstream
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PathPhoto { get; set; }
        public decimal Price { get; set; }
        public string IdEcommerce { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
=======
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
>>>>>>> Stashed changes
    }
}
