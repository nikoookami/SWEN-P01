using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class UserAccount
    {
        private string username;
        private string usertype;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string UserType
        {
            get { return usertype; }
            set { usertype = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
