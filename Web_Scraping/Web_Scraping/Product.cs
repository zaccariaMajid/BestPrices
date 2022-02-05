using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Web_Scraping
{
    public class Product
    {
        [Key, Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string PathPhoto { get; set; }
        [Required]
        public string IdEcommerce { get; set; }
    }
}