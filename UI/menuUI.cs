using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.UI
{
    class menuUI
    {
        public static void header()
        {
            Console.WriteLine("*               *   *             *    ***************");
            Console.WriteLine("*               *   * *         * *    *              ");
            Console.WriteLine("*               *   *  *       *  *    *              ");
            Console.WriteLine("*               *   *   *     *   *    *              ");
            Console.WriteLine("*               *   *    *  *     *    *              ");
            Console.WriteLine("*************** *   *     *       *    ************** ");
            Console.WriteLine("*               *   *             *                 * ");
            Console.WriteLine("*               *   *             *                 * ");
            Console.WriteLine("*               *   *             *                 * ");
            Console.WriteLine("*               *   *             *                 * ");
            Console.WriteLine("*               *   *             *                 * ");
            Console.WriteLine("*               *   *             *     ************* ");
            Console.WriteLine("\n\n");
        }
        public static void hms_header()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("********                                     ********");
            Console.WriteLine("          Service Hospital Management System         ");
            Console.WriteLine("********                                     ********");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("\n\n");
        }
        public static int menu()
        {
            int option;
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|                  1- Admin                          |");
            Console.WriteLine("|                  2- Doctor                         |");
            Console.WriteLine("|                  3- Patient                        |");
            Console.WriteLine("|                  4- Instructions                   |");
            Console.WriteLine("|                  5- Exit                           |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter your option ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static string Admin_menu()
        {
            string option;
            Console.WriteLine(" _________________");
            Console.WriteLine("|                 |");
            Console.WriteLine("|     ADMIN       |");
            Console.WriteLine("|_________________|");
            Console.WriteLine();
            Console.WriteLine("      1- Add Doctors...");
            Console.WriteLine("      2- View Doctors...");
            Console.WriteLine("      3- Delete Doctors...");
            Console.WriteLine("      4- Update Doctors...");
            Console.WriteLine("      5- View Patient...");
            Console.WriteLine("      6- Delete Patient...");
            Console.WriteLine("      7- View Available Test Details...");
            Console.WriteLine("      8- View Appointments...");
            Console.WriteLine("      9- View Instructions...");
            Console.WriteLine("     10- Logout...");
            Console.WriteLine();
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.WriteLine("\nEnter your option ");
            option = Console.ReadLine();
            return option;
        }
        public static string Doctor_menu()
        {
            string option;
            Console.WriteLine(" _________________");
            Console.WriteLine("|                 |");
            Console.WriteLine("|     DOCTOR      |");
            Console.WriteLine("|_________________|");
            Console.WriteLine();
            Console.WriteLine("      1- Add Patients...");
            Console.WriteLine("      2- View Patients...");
            Console.WriteLine("      3- Delete Patients...");
            Console.WriteLine("      4- Search Patient by name...");
            Console.WriteLine("      5- Give Prescription...");
            Console.WriteLine("      6- View Appointments...");
            Console.WriteLine("      7- Laboratory Test...");
            Console.WriteLine("      8- View Instructions...");
            Console.WriteLine("      9- Logout...");
            Console.WriteLine();
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.WriteLine("\nEnter your option ");
            option = Console.ReadLine();
            return option;
        }
        public static string Patient_menu()
        {
            string option;
            Console.WriteLine(" _________________");
            Console.WriteLine("|                 |");
            Console.WriteLine("|     PATIENT     |");
            Console.WriteLine("|_________________|");
            Console.WriteLine();
            Console.WriteLine("      1- Book Appointments...");
            Console.WriteLine("      2- View Appointments...");
            Console.WriteLine("      3- View Doctors...");
            Console.WriteLine("      4- View his/her record...");
            Console.WriteLine("      5- View Prescription...");
            Console.WriteLine("      6- Logout...");
            Console.WriteLine();
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            Console.WriteLine("\nEnter your option ");
            option = Console.ReadLine();
            return option;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
