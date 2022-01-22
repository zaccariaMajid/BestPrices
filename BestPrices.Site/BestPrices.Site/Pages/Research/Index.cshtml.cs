using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BestPrices.Site.Pages.Research
{
    public class IndexModel : PageModel
    {
        private readonly PriceDbContext _context;
        public IndexModel(PriceDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string ReasearchText { get; set; }
        [BindProperty]
        public IList<Product> Products { get; set; }
       
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<string> GetEcommerceById(string id)
        {
            return _context.Sites.SingleOrDefault(x => x.Id == id).Name;
        }
    }
}
