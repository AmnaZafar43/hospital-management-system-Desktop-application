using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hms.BL;

namespace hms.DL
{
    class mUserDL
    {
        public static List<mUser> mUserList = new List<mUser>();
       
        public static void loadData()
        {
            string path = "sign.txt";
            StreamReader sign = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = sign.ReadLine())!= null)
                {
                    string[] splittedRecord = record.Split(',');
                    string username = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    mUser obj = new mUser(username, password, role);
                    mUserList.Add(obj);
                }
            }
            else
            {
                Console.WriteLine("File does not exist...");
                Console.ReadKey();
            }
        }
    }
}
