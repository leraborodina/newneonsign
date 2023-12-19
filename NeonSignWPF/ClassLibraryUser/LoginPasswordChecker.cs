using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUser
{
    public class LoginPasswordChecker
    {
        public static bool ValidateUser(string password, string login)
        {
            if (password == null || login == null)
                return false;
            if (password == "password" && login == "login")
                return true;
            if(password.Length < 5)
                return false;
            return true;
        }

    }
}
