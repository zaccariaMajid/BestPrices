using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class UserProduct
    {
        [Key, Required]
        public string Id { get; set; }

        [Required]
        public string IdUser { get; set; }

        [Required]
        public string IdProduct { get; set; }

        [Required]
        public bool IsFavourite { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
