using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.Users
{
    public class LoginModel : PageModel
    {
        private readonly PriceDbContext _context;
        public LoginModel(PriceDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            string encPassword = PasswordManager.EncodePasswordToBase64(Password);
            return RedirectToPage("/users/Index");
        }
    }
}
