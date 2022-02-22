using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Http;
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
        public string UsernameEmail { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ErrorText { get; set; }
        public User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            string encPassword = PasswordManager.EncodePasswordToBase64(Password);
            User user = _context.Users.SingleOrDefault(x => (x.Username == UsernameEmail || x.Email == UsernameEmail) && x.Password == encPassword);
            if(user == null)
            {
                ErrorText = "Username/email or password wrong";
                return Page();
            }
            var cookies = HttpContext.Response.Cookies;
            var options = new Microsoft.AspNetCore.Http.CookieOptions() { Expires = DateTime.Now.AddDays(30), 
                IsEssential = true, Secure = true };
            var key = CookiesManager.UserIdKey;
            cookies.Delete(key);
            cookies.Append(key, user.Id, options);
            return RedirectToPage("/users/Index");
        }
    }
}
