using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hms.BL;
using hms.UI;

namespace hms.DL
{
    class patientDL
    {
        public static List<patient> patientList = new List<patient>();

        public static void addPatientinList(patient obj)
        {
            patientList.Add(obj);
        }

        public static void addPatientinFile()
        {
            string path = "patientFile.txt";
            StreamWriter patientFile = new StreamWriter(path,true);
            for(int i=0;i< patientList.Count;i++)
            {
                patientFile.WriteLine(patientList[i].patientName + "," + patientList[i].patientGender + "," + patientList[i].patientAge + "," + patientList[i].patientDisease + "," + patientList[i].patientId + "," + patientList[i].patientAddress + "," + patientList[i].patientBlood + "," + patientList[i].patientMobile + "," + patientList[i].patientCnic);
            }
            patientFile.Flush();
            patientFile.Close();
        }

        public static void loadPatientfromFile()
        {
            string path = "patientFile.txt";
            StreamReader patientFile = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = patientFile.ReadLine())!= null)
                {
                    string patientName, patientDisease, patientBlood, patientCnic, patientGender, patientMobile, patientAddress;
                    int patientAge = 0, patientId = 0;
                    string[] splittedRecord = record.Split(',');
                    patientName = splittedRecord[0];
                    patientGender = splittedRecord[1];
                    patientAge = int.Parse(splittedRecord[2]);
                    patientDisease = splittedRecord[3];
                    patientId = int.Parse(splittedRecord[4]);
                    patientAddress = splittedRecord[5];
                    patientBlood = splittedRecord[6];
                    patientMobile = splittedRecord[7];
                    patientCnic = splittedRecord[8];
                    patient obj = new patient(patientName, patientAge, patientDisease, patientBlood, patientCnic, patientId, patientGender, patientMobile, patientAddress);
                    patientList.Add(obj);
                }
            }
            else
            {
                Console.WriteLine("File does not exist...");
                Console.ReadKey();
            }
        }

        public static void updatePatient()
        {
            int idx, id;
            string change;
            Console.WriteLine("Enter patient's ID ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter which thing you want to change ");
            change = Console.ReadLine();
            for (int i = 0; i < patientList.Count; i++)
            {
                if (id == patientList[i].patientId)
                {
                    idx = i;
                    if (change == "name" || change == "Name" || change == "NAME")
                    {
                        Console.WriteLine("Enter patient name... ");
                        patientList[idx].patientName = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|,                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[idx].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "id" || change == "Id" || change == "ID")
                    {
                        Console.WriteLine("Enter patient id... ");
                        patientList[idx].patientId = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[idx].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "gender" || change == "Gender" || change == "GENDER")
                    {
                        Console.WriteLine("Enter patient gender... ");
                        patientList[idx].patientGender = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[idx].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "age" || change == "AGE" || change == "Age")
                    {
                        Console.WriteLine("Enter patient age... ");
                        patientList[idx].patientAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[idx].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "disease" || change == "Disease" || change == "DISEASE" || change == "dis" || change == "Dis")
                    {
                        Console.WriteLine("Enter patient disease... ");
                        patientList[idx].patientDisease = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[idx].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "blood" || change == "Blood" || change == "BLOOD")
                    {
                        Console.WriteLine("Enter patient blood group... ");
                        patientList[idx].patientBlood = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[idx].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "mobile" || change == "Mobile" || change == "MOBILE")
                    {
                        Console.WriteLine("Enter patient mobile no... ");
                        patientList[idx].patientMobile = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[idx].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else if (change == "address" || change == "Address" || change == "ADDRESS" || change == "add")
                    {
                        Console.WriteLine("Enter patient's address... ");
                        patientList[idx].patientAddress = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[idx].patientAddress);
                    }
                    else if (change == "cnic" || change == "CNIC" || change == "Cnic")
                    {
                        Console.WriteLine("Enter patient's cnic... ");
                        patientList[idx].patientCnic = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE PATIENT |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\tPatient Name\tID\tAge\tDisease\tGender\tBlood_Group\tCNIC\tMobile-No\tAddress");
                        Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[idx].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
                    }
                    else
                    {
                        Console.WriteLine("Enter valid thing for change ");
                    }
                }
            }
            Console.ReadKey();
        }

        public static void deletePatient()
        {
            int temp_id;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Enter  patient id");
            temp_id = int.Parse(Console.ReadLine());
            for (int i = 0; i < patientList.Count; i++)
            {
                if (temp_id == patientList[i].patientId)
                {
                    patientList.Remove(patientList[i]);
                }
            }
        }

        public static patient bookAppointments()
        {
            int patNo=0;
            string doctorName;
            string patientName, patientDisease, patientBlood, patientCnic, patientGender, patientMobile, patientAddress;
            int patientAge = 0, patientId = 0;
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
                patientBlood = Console.ReadLine();
                if (patientBlood.Length == 1 || patientBlood.Length == 2 || patientBlood.Length == 3)
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
                Console.WriteLine("Enter patient mobile no: ");
                patientMobile = Console.ReadLine();

                if (patientMobile.Length == 11)
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
                Console.WriteLine("Enter patient cnic: ");
                patientCnic = Console.ReadLine();

                if (patientCnic.Length == 13)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            Console.WriteLine("Enter doctor name for appointment... ");
            doctorName = Console.ReadLine();
            patNo++;
            Console.WriteLine("\n");                      
            patient obj = new patient(patientName, patientAge, patientDisease, patientBlood, patientCnic, patientId, patientGender, patientMobile, patientAddress);
            return obj;
        }
        public static void addAppointmentinList(patient obj,int patNo)
        {
            if(patNo < 15)
            {
                patientList.Add(obj);
                Console.WriteLine("Appointment Booked......");
            }
            else
            {
                Console.WriteLine("Appointment not booked!!! Try again next day");
            }
        }

        public static void viewAppointments(int idx)
        {
            Console.WriteLine("\tPatient Name\tPatient Age\tPatient Disease\tPatient blood group\tPatient Cnic");
            for (int i = 0; i < patientList.Count; i++)
            {
                Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic);
            }
        }

        public static void searchPatientbyName()
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
            for (int i = 0; i < patientList.Count; i++)
            {
                if (name == patientList[i].patientName)
                {
                    Console.WriteLine(patientList[i].patientName + "\t\t" + patientList[i].patientAge + "\t\t" + patientList[i].patientDisease + "\t\t" + patientList[i].patientBlood + "\t\t" + patientList[i].patientCnic + "\t\t" + patientList[i].patientId + "\t\t" + patientList[i].patientGender + "\t\t" + patientList[i].patientMobile + "\t\t" + patientList[i].patientAddress);
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
        public static void sortPatient()
        {
            patientList = patientList.OrderByDescending(o => o.patientAge).ToList();
        }
    }
}
