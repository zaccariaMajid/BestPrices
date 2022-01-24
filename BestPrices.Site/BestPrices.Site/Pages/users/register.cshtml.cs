using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.Users
{
    public class RegisterModel : PageModel
    {
        private readonly PriceDbContext _context;
        public RegisterModel(PriceDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ConfirmedPassword { get; set; }
        [BindProperty]
        public string username { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            string encPassword = PasswordManager.EncodePasswordToBase64(Password);
            string encConfirmedPassword = PasswordManager.EncodePasswordToBase64(ConfirmedPassword);
            if (encPassword != encConfirmedPassword)
                return Page();
            var newUser = new BestPrices.Site.Models.User()
            {
                Id = Guid.NewGuid().ToString(),
                Email = email,
                Password = encPassword,
                Username = username
            };
            _context.Users.Add(newUser);

            var cookies = Response.Cookies;
            var options = new Microsoft.AspNetCore.Http.CookieOptions() { Expires = DateTime.Now.AddDays(30), IsEssential = true };
            var index = CookiesManager.CurrentUserId;
            cookies.Delete(index);
            cookies.Append(index, newUser.Id, options);
            _context.SaveChangesAsync();
            return RedirectToPage("/users/Index");
        }
    }
}