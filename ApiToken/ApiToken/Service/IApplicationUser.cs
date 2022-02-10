using SlackAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToken.Service
{
    public interface IApplicationUser
    {
        string Authenticate(string username, string password);
        LoginResponse AuthenticateMvc(string username, string password);
    }
}
