using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Interfaces
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string username,string passwrod);
        bool AuthorizeUser(string username, string role);
    }
}
