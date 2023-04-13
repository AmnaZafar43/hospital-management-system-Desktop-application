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
    class doctorDL
    {


        public static List<doctor> doctorList = new List<doctor>();
        
        public static void addDoctorinList(doctor obj)
        {
            doctorList.Add(obj);
        }

        public static void addDoctorinFile(string path)
        {
            string path2 = "doctorFile.txt";
            StreamWriter doctorFile = new StreamWriter(path2);
            for(int i=0;i<doctorList.Count;i++)
            {
                doctorFile.WriteLine(doctorList[i].doctorName + "," + doctorList[i].doctorGender + "," + doctorList[i].doctorAge + "," + doctorList[i].doctorSpecialization + "," + doctorList[i].doctorId + "," + doctorList[i].doctorBlood + "," + doctorList[i].doctorMobile + "," + doctorList[i].doctorMail + "," + doctorList[i].doctorAddress);
            }
            doctorFile.Flush();
            doctorFile.Close();
        }
        public static void loadDoctorfromFile()
        {
            string path = "doctorFile.txt";
            StreamReader doctorFile = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = doctorFile.ReadLine())!= null)
                {
                    string doctorName, doctorGender, doctorAddress, doctorSpecialization, doctorMail, doctorMobile, doctorBlood;
                    int doctorAge, doctorId;
                    string[] splittedRecord = record.Split(',');
                    doctorName = splittedRecord[0];
                    doctorGender = splittedRecord[1];
                    doctorAge = int.Parse(splittedRecord[2]);
                    doctorSpecialization = splittedRecord[3];
                    doctorId = int.Parse(splittedRecord[4]);
                    doctorBlood = splittedRecord[5];
                    doctorMobile = splittedRecord[6];
                    doctorMail = splittedRecord[7];
                    doctorAddress = splittedRecord[8];
                    doctor obj = new doctor(doctorName, doctorAge, doctorGender, doctorSpecialization, doctorId, doctorAddress, doctorBlood, doctorMail, doctorMobile);
                    doctorList.Add(obj);
                }
            }
            else
            {
                Console.WriteLine("File does not exist...");
                Console.ReadKey();
            }
        }

        public static void delete_doctor(string path)
        {
            int temp_id,index=0;
            doctorUI.viewDoctor();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Enter doctor id");
            temp_id = int.Parse(Console.ReadLine());
            foreach (doctor d in doctorList)
            {
                if (temp_id==d.doctorId)
                {
                    doctorList.RemoveAt(index);
                    break;
                }
                index++;
            }
            doctorUI.viewDoctor();
            addDoctorinFile(path);
        }

        public static void update_doctor()
        {
            int idx;
            string change;
            int id;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Enter doctor id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter which thing you want to change..");
            change = Console.ReadLine();
            for (int i = 0; i < doctorList.Count; i++)
            {
                if (id == doctorList[i].doctorId)
                {
                    idx = i;
                    if (change == "name" || change == "Name" || change == "NAME")
                    {
                        Console.WriteLine("\tEnter doctor name");
                        doctorList[idx].doctorName = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE DOCTOR  |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Doctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[idx].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[i].doctorMail);

                    }
                    else if (change == "gender" || change == "Gender" || change == "GENDER")
                    {
                        Console.WriteLine("\tEnter doctor gender");
                        doctorList[idx].doctorGender = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE DOCTOR  |");
                        Console.WriteLine("\t\t|_________________|");

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Doctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[idx].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[i].doctorMail);
                    }
                    else if (change == "age" || change == "AGE" || change == "Age")
                    {
                        Console.WriteLine("\tEnter doctor age");
                        doctorList[idx].doctorAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE DOCTOR  |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\tDoctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[idx].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[i].doctorMail);
                    }
                    else if (change == "specialization" || change == "Spec" || change == "spec" || change == "Specialization")
                    {
                        Console.WriteLine("\tEnter doctor specialization");
                        doctorList[idx].doctorSpecialization = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE DOCTOR  |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Doctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[idx].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[i].doctorMail);
                    }
                    else if (change == "blood" || change == "Blood" || change == "BLOOD")
                    {
                        Console.WriteLine("\tEnter doctor's blood group");
                        doctorList[idx].doctorBlood = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\tDoctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[idx].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[i].doctorMail);
                    }
                    else if (change == "mobile" || change == "Mobile" || change == "MOBILE")
                    {
                        Console.WriteLine("\tEnter doctor's mobile no");
                        doctorList[idx].doctorMobile = Console.ReadLine();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\tDoctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[idx].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[i].doctorMail);
                    }
                    else if (change == "address" || change == "Address" || change == "ADDRESS")
                    {
                        Console.WriteLine("\tEnter doctor's address");
                        doctorList[idx].doctorAddress = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE DOCTOR  |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\tDoctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[idx].doctorAddress + "\t\t" + doctorList[i].doctorMail);
                    }
                    else if (change == "email" || change == "mail" || change == "e_mail" || change == "Email")
                    {
                        Console.WriteLine("\tEnter doctor e_mail");
                        doctorList[idx].doctorMail = Console.ReadLine();
                        Console.WriteLine("\n\n\n\n");
                        Console.WriteLine("\t\t _________________");
                        Console.WriteLine("\t\t|                 |");
                        Console.WriteLine("\t\t|  UPDATE DOCTOR  |");
                        Console.WriteLine("\t\t|_________________|");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\tDoctor Name\tDoctor ID\tGender\tAge\tSpecialization\tBlood_Group\tMobile-No\tAddress\tEmail");
                        Console.WriteLine("\n\n");
                        Console.WriteLine(doctorList[i].doctorName + "\t\t" + doctorList[i].doctorId + "\t\t" + doctorList[i].doctorGender + "\t\t" + doctorList[i].doctorAge + "\t\t" + doctorList[i].doctorSpecialization + "\t\t" + doctorList[i].doctorBlood + "\t\t" + doctorList[i].doctorMobile + "\t\t" + doctorList[i].doctorAddress + "\t\t" + doctorList[idx].doctorMail);
                    }
                    else
                    {
                        Console.WriteLine("Enter valid thing for change ");
                    }
                }

            }
            Console.ReadKey();
        }
        public static void sortDoctor()
        {
            doctorList = doctorList.OrderByDescending(o => o.doctorAge).ToList();
        }
    }
}
