using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hms.DL;
using hms.BL;

namespace hms.UI
{
    class patientUI
    {
        public static patient addPatient()
        {
            string blood, mobile, cnic;
            string patientName,patientDisease,patientBlood,patientCnic,patientGender,patientMobile,patientAddress;
            int patientAge=0,patientId=0;
            Console.WriteLine("Enter patient name: ");
            patientName = Console.ReadLine();
            Console.WriteLine("Enter patient gender: ");
            patientGender = Console.ReadLine();
            Console.WriteLine("Enter patient age: ");
            patientAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter patient disease: ");
            patientDisease = Console.ReadLine();
            Console.WriteLine("Enter patient id: ");
            patientId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter patient address: ");
            patientAddress = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Enter patient blood group: ");
                blood = Console.ReadLine();
                if (blood.Length == 1 || blood.Length == 2 || blood.Length == 3)
                {
                    patientBlood = blood;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter patient mobile no: ");
                mobile = Console.ReadLine();

                if (mobile.Length == 11)
                {
                    patientMobile = mobile;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter patient cnic: ");
                cnic = Console.ReadLine();

                if (cnic.Length == 13)
                {
                    patientCnic = cnic;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            patient obj = new patient(patientName, patientAge, patientDisease, patientBlood, patientCnic, patientId, patientGender, patientMobile, patientAddress);
            return obj;
        }

        public static void viewPatient()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t _________________");
            Console.WriteLine("\t\t|                 |");
            Console.WriteLine("\t\t|  VIEW PATIENTS  |");
            Console.WriteLine("\t\t|_________________|");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\tPatient Name\tID\tAge\tDisease\t\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
            for (int i = 0; i < DL.patientDL.patientList.Count; i++)
            {
                Console.WriteLine(DL.patientDL.patientList[i].patientName + "\t" + DL.patientDL.patientList[i].patientId + "\t" + DL.patientDL.patientList[i].patientAge + "\t" + DL.patientDL.patientList[i].patientDisease + "\t" + DL.patientDL.patientList[i].patientGender + "\t" + DL.patientDL.patientList[i].patientBlood + "\t" + DL.patientDL.patientList[i].patientCnic + "\t" + DL.patientDL.patientList[i].patientMobile + "\t" + DL.patientDL.patientList[i].patientAddress);
            }
            Console.ReadKey();
        }

        public static void viewRecord()
        {
            string name;
            Console.WriteLine("Enter patient name ");
            name = Console.ReadLine();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t _________________");
            Console.WriteLine("\t\t|                 |");
            Console.WriteLine("\t\t|  VIEW PATIENT   |");
            Console.WriteLine("\t\t|_________________|");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\tPatient Name\tAge\tDisease\tBlood Group\tCNIC\tID\tGender\tMobile-No\tAddress");
            for (int i = 0; i < DL.patientDL.patientList.Count; i++)
            {
                if (name == DL.patientDL.patientList[i].patientName)
                {
                    Console.WriteLine(DL.patientDL.patientList[i].patientName + "\t\t" + DL.patientDL.patientList[i].patientAge + "\t\t" + DL.patientDL.patientList[i].patientDisease + "\t\t" + DL.patientDL.patientList[i].patientBlood + "\t\t" + DL.patientDL.patientList[i].patientCnic + "\t\t" + DL.patientDL.patientList[i].patientId + "\t\t" + DL.patientDL.patientList[i].patientGender + "\t\t" + DL.patientDL.patientList[i].patientMobile + "\t\t" + DL.patientDL.patientList[i].patientAddress);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid name!!");
                    break;
                }
            }
            Console.ReadKey();
        }
        public static void available_test()
        {
            string test_name;
            Console.WriteLine("\t\t _________________");
            Console.WriteLine("\t\t|                 |");
            Console.WriteLine("\t\t|  TEST DETAILS   |");
            Console.WriteLine("\t\t|_________________|");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t ECG      ");
            Console.WriteLine("\t Liver Panel");
            Console.WriteLine("\t Hemoglobin A1C");
            Console.WriteLine("\t CBC          ");
            Console.WriteLine("\n\n\n");
            Console.WriteLine(" Enter your test name ");
            test_name = Console.ReadLine();
            if (test_name == "ECG" || test_name == "Ecg" || test_name == "ecg")
            {

                Console.WriteLine("Available");
            }
            else if (test_name == "Liver panel" || test_name == "LP" || test_name == "lp" || test_name == "liver panel")
            {
                Console.WriteLine("Available");
            }
            else if (test_name == "hmg" || test_name == "Hmg" || test_name == "hemoglobin")
            {
                Console.WriteLine("Available");
            }
            else if (test_name == "cbc" || test_name == "Cbc" || test_name == "CBC")
            {
                Console.WriteLine("Available");
            }
            else
            {
                Console.WriteLine("Not Available");
            }
            Console.ReadKey();
        }
    }
}
