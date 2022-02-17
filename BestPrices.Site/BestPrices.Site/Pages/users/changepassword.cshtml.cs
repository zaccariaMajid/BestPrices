using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestPrices.Site.Pages.users
{
    public class changepasswordModel : PageModel
    {
        private readonly PriceDbContext _context;
        public changepasswordModel(PriceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string OldPassword { get; set; }
        [BindProperty]
        public string NewPassword { get; set; }
        [BindProperty]
        public string newConfirmedPassword { get; set; }
        [BindProperty]
        public string ErrorText { get; set; }
        [BindProperty]
        public User User { get; set; } 
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(string.IsNullOrEmpty(OldPassword) ||
                string.IsNullOrEmpty(NewPassword) ||
                string.IsNullOrEmpty(newConfirmedPassword))
            {
                ErrorText = "Empty fields in the form";
                return Page();
            }
            string encOldPassword = PasswordManager.EncodePasswordToBase64(OldPassword);

            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            if (User.Password != encOldPassword)
            {
                ErrorText = "Old password wrong";
                return Page();
            }
            string encNewPassword = PasswordManager.EncodePasswordToBase64(NewPassword);
            string encConfirmedPassword = PasswordManager.EncodePasswordToBase64(newConfirmedPassword);
            if (encNewPassword != encConfirmedPassword)
            {
                ErrorText = "Passwords doesn't match";
                return Page();
            }
            _context.Users.SingleOrDefault(x => x.Id == User.Id).Password = encNewPassword;
            _context.SaveChanges();
            ErrorText = string.Empty;
            return RedirectToPage("/users/Index");
        }
    }
}
