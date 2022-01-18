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
    public class UserProduct
    {
<<<<<<< Updated upstream
        public string IdUser { get; set; }
        public string IdProduct { get; set; }
        public bool IsFavourite { get; set; }
=======
        [Key, Required]
        public string IdUserProduct { get; set; }

        [Required]
        public string IdUser { get; set; }

        [Required]
        public string IdProduct { get; set; }

        [Required]
        public bool IsFavorite { get; set; }
>>>>>>> Stashed changes
    }
}
