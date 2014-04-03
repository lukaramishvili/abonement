using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    class User
    {
        public string username;
        public string password;

        public User()
        {
        }

        public User(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }
    }
}
