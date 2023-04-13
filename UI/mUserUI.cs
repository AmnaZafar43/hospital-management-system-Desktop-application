using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hms.DL;
using hms.BL;

namespace hms.UI
{
    class mUserUI
    {
        public static string signIn()
        {
            string username, password;
            Console.WriteLine("Enter username...");
            username = Console.ReadLine();
            Console.WriteLine("Enter password...");
            password = Console.ReadLine();
            for(int i=0;i<DL.mUserDL.mUserList.Count;i++)
            {
                if (username == DL.mUserDL.mUserList[i].username && password == DL.mUserDL.mUserList[i].password)
                {
                    return DL.mUserDL.mUserList[i].role;
                }
            }
            return "Invalid user";
        }
    }
}
