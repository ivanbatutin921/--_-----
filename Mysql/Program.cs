using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class Program:Register
    {
        static void Main(string[] args)
        {
            Register r = new Register();
            r.Register_User();

            //Login login = new Login();
            //login.Login_User();
        }
    }
}
