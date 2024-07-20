using AssignmentOOP03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03
{
    internal class BasicAuthenticationService:IAuthenticationService
    {
        Users[] usersarr = new Users[] { new Users { Name = "Bilal", Password = "666666",Role ="admin" }
        , new Users { Name = "Ali", Password = "55556", Role = "user" },
            new Users { Name = "Yahya", Password = "677776",Role ="user" } };

        public bool AuthenticateUser(string username, string passwrod)
        {
            for (int i = 0; i < usersarr.Length; i++) 
            {
                if (username == usersarr[i].Name && passwrod == usersarr[i].Password) 
                    return true;
               
                    
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < usersarr.Length; i++)
            {
                if (username == usersarr[i].Name && role == usersarr[i].Role)
                    return true;


            }
            return false;

        }
    }
}
