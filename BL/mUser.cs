using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.BL
{
    class mUser
    {
        public string username;
        public string password;
        public string role;

        public mUser(string username,string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }
}
