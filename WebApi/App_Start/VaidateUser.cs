using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.App_Start
{
    public class ApiSecurity
    {
        public static bool VaidateUser(string username, string password)
        {
            if (username == "niraj" && password == "user123456")
                return true;
            else
                return false;
        }
    }
}