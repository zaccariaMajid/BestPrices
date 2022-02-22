using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using BestPrices.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BestPrices.Site.Email;

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
        [BindProperty]
        public string ErrorText { get; set; }
        [BindProperty]
        public bool IsSended { get; set; }
        [BindProperty]
        public bool IsFirstOpen { get; set; } = true;
        public User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (_context.Users.Select(x => x.Email).Contains(email))
            {
                ErrorText = "Email is already used";
                return Page();
            }

            if (_context.Users.Select(x => x.Username).Contains(username))
            {
                ErrorText = "Username is already taken";
                return Page();
            }

            string encPassword = PasswordManager.EncodePasswordToBase64(Password);
            string encConfirmedPassword = PasswordManager.EncodePasswordToBase64(ConfirmedPassword);
            if (encPassword != encConfirmedPassword)
            {
                ErrorText = "Passwords don't match";
                return Page();
            }

            var newUser = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Email = email,
                Password = encPassword,
                Username = username
            };
            _context.Users.Add(newUser);

            var emailmanager = new EmailManager();
            var newEmailToken = new EmailToken()
            {
                Id = Guid.NewGuid().ToString(),
                IdUser = newUser.Id,
                Date = DateTime.Now,
                Token = new TokenMaker().GetToken()
            };
            _context.EmailTokens.Add(newEmailToken);
            Components components = new Components(username, newEmailToken.Token);
            var emailComponents = new EmailComponents
            {
                NameSender = components.NameSender,
                Sender = components.Sender,
                Recipient = email,
                Subject = components.Subject,
                Body = components.Body
            };
            IsSended = emailmanager.SendEmail(emailComponents, Credentials.EmailCredentials);
            IsFirstOpen = false;

            //var cookies = Response.Cookies;
            //var options = CookiesManager.CookieOptions;
            //var key = CookiesManager.UserIdKey;
            //cookies.Delete(key);
            //cookies.Append(key, newUser.Id, options);
            _context.SaveChanges();
            ErrorText = string.Empty;
            if (IsSended)
                return RedirectToPage("/users/verification", new { id = newUser.Id});
            return Page();
        }
    }
}