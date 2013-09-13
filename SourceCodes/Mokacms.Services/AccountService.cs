using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokacms.Services
{
    public class AccountService
    {
        public bool Login(string username, string password)
        {
            var result = false;
            if (username == "robin" && password == "robin")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
