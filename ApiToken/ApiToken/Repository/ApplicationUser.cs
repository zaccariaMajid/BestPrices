using ApiToken.Service;
using ApiToken.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SlackAPI;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiToken.Repository
{
    public class ApplicationUser : IApplicationUser
    {
        private readonly IConfiguration Configuration;
        public ApplicationUser(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private List<SlackAPI.User> _users = new List<SlackAPI.User>
         {
             new SlackAPI.User { Id = 1, FirstName = "Hello", LastName = "World", Username = "username", Password = "password" }
         };

        public string Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                     new Claim(ClaimTypes.Name,user.Id.ToString()),
                }),
                IssuedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "Issuer",
                Audience = "Audience"
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public LoginResponse AuthenticateMvc(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                     new Claim(ClaimTypes.Name, user.Id.ToString()),
                }),
                IssuedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "Issuer",
                Audience = "Audience"
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            //Mock response
            LoginResponse response = new LoginResponse()
            {
                token = tokenHandler.WriteToken(token),
                role = "User",
                claims = new List<ClaimDto>()
                 {
                     new ClaimDto() {type = ClaimTypes.Role, value = "UserRole" },
                     new ClaimDto() {type= ClaimTypes.Email, value = "email@email.com" }
                 }
            };

            return response;

        }
    }
}
