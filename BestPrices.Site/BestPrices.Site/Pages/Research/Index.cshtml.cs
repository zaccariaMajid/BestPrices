using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Api;
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
            _apiManager = new ApiManager();
        }
        [BindProperty]
        public string ResearchText { get; set; }
        [BindProperty]
        public IList<Product> Products { get; set; }
        ApiManager _apiManager { get; set; }
       
        public IActionResult OnGet()
        {
            return Page();
        }
        public string GetEcommerceById(string id)
        {
            return "Amazon";
            //return _context.Sites.SingleOrDefault(x => x.Id == id).Name;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Products = _apiManager.GetProducts(ResearchText);
            return Page();
        }
    }
}
