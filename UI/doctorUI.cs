using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hms.BL;
using hms.DL;

namespace hms.UI
{
    class doctorUI
    {
        public static doctor addDoctors()
        {
            string doctorName, doctorGender, doctorAddress, doctorSpecialization, doctorMail, doctorMobile, doctorBlood;
            int doctorAge, doctorId;
            Console.WriteLine("Enter doctor name: ");
            doctorName = Console.ReadLine();
            Console.WriteLine("Enter doctor gender: ");
            doctorGender = Console.ReadLine();
            Console.WriteLine("Enter doctor age: ");
            doctorAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter doctor specialization: ");
            doctorSpecialization = Console.ReadLine();
            Console.WriteLine("Enter doctor id: ");
            doctorId = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter doctor blood group: ");
                doctorBlood = Console.ReadLine();
                if (doctorBlood.Length == 1 || doctorBlood.Length == 2 || doctorBlood.Length == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter doctor mobile no: ");
                doctorMobile = Console.ReadLine();

                if (doctorMobile.Length == 11)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            Console.WriteLine("Enter doctor mail: ");
            doctorMail = Console.ReadLine();
            Console.WriteLine("Enter doctor address: ");
            doctorAddress = Console.ReadLine();
            doctor obj = new doctor(doctorName, doctorAge, doctorGender, doctorSpecialization, doctorId, doctorAddress, doctorBlood, doctorMail, doctorMobile);
            return obj;
        }
        public static void view_instructions()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("1- Make sure you are visiting hospital during visiting hours.");
            Console.WriteLine("2- Keep your voice low down and phone on silent in earmarked zone.");
            Console.WriteLine("3- Don't break hospital rules or violate safety.");
            Console.WriteLine("4- Don't touch any type of equipment.");
            Console.WriteLine("5- We provide advancing healthcare quality and patient safety.");
            Console.WriteLine("6- We are making healthcare data and perfomance measures transparent and publicly available.");
            Console.WriteLine("\n\n\n");
            Console.ReadKey();
        }

        public static void prescription()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t _________________");
            Console.WriteLine("\t\t|                 |");
            Console.WriteLine("\t\t|  PRESCRIPTIONS  |");
            Console.WriteLine("\t\t|_________________|");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Medicines given ");
            Console.WriteLine("-----1-    Drop Calpol 100");
            Console.WriteLine(" PARACETAMOL(100MG) ");
            Console.WriteLine("  0.75ml_Stat ");
            Console.WriteLine("-----2-    Syrup ibugesic Plus");
            Console.WriteLine("  2ml - SoS");
            Console.WriteLine("-----3-    Drop Ascroil LS");
            Console.WriteLine(" AMBROXOL(7.5)+LEVOSALBUTAMOL(0.25MG)+GUAIFENSIN");
            Console.WriteLine("  1ml -3 times a day X 5 days(O--O--O)");
            Console.WriteLine("-----4-    Drop Atarax");
            Console.WriteLine("  HYDROXYZINE(6 MG)");
            Console.WriteLine("  0.5ml- 2 times a day X 5 days(O--O)");
            Console.WriteLine("-----5-     Nasoclear Nasal ");
            Console.WriteLine("  3 times a day X 5 days(O--O--O)");
            Console.ReadKey();
        }

        public static void viewDoctor()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t _________________");
            Console.WriteLine("\t\t|                 |");
            Console.WriteLine("\t\t|  VIEW DOCTORS   |");
            Console.WriteLine("\t\t|_________________|");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("NAME\t\tAGE\tGENDER\tSPECIALIATION\tBLOOD-GROUP\tID\tMOBILE-NO\tADDRESS\tMAIL");
            for (int i = 0; i < DL.doctorDL.doctorList.Count; i++)
            {
                Console.WriteLine(DL.doctorDL.doctorList[i].doctorName + "\t" + DL.doctorDL.doctorList[i].doctorAge + "\t" + DL.doctorDL.doctorList[i].doctorGender + "\t" + DL.doctorDL.doctorList[i].doctorSpecialization + "\t" + DL.doctorDL.doctorList[i].doctorBlood + "\t" + DL.doctorDL.doctorList[i].doctorId + "\t" + DL.doctorDL.doctorList[i].doctorMobile + "\t" + DL.doctorDL.doctorList[i].doctorAddress + "\t" + DL.doctorDL.doctorList[i].doctorMail);
            }
            Console.ReadKey();
        }
    }
}
