using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace MokaCms.Services
{
    public class  AccountService
    {
        public bool Login(string username, string password)
        {
            var result = username == "hayley" && password == "hayley";

            return result;

        }
    }
}
