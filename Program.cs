using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hms.BL;
using hms.DL;
using hms.UI;

namespace hms
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            string adminOption = "";
            string path = "doctorFile.txt";

            while (option < 5)
            {
                DL.mUserDL.loadData();
                DL.patientDL.loadPatientfromFile();
                DL.doctorDL.loadDoctorfromFile();
                DL.patientDL.sortPatient();
                DL.doctorDL.sortDoctor();
                UI.menuUI.clearScreen();
                UI.menuUI.header();
                UI.menuUI.clearScreen();
                UI.menuUI.hms_header();
                option = UI.menuUI.menu();
                if(option == 1)
                {
                    string w = UI.mUserUI.signIn();
                    UI.menuUI.clearScreen();
                    if (w == "Admin")
                    {
                        while(true)
                        {
                           adminOption = UI.menuUI.Admin_menu();
                            if(adminOption == "1")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                doctor obj = UI.doctorUI.addDoctors();
                                DL.doctorDL.addDoctorinList(obj);
                                DL.doctorDL.addDoctorinFile(path);
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "2")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.doctorUI.viewDoctor();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "3")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                DL.doctorDL.delete_doctor(path);
                               // DL.doctorDL.addDoctorinFile();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "4")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                DL.doctorDL.update_doctor();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "5")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.patientUI.viewPatient();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "6")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                DL.patientDL.deletePatient();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "7")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.patientUI.available_test();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "8")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                int index=0;
                                DL.patientDL.viewAppointments(index);
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "9")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.doctorUI.view_instructions();
                                UI.menuUI.clearScreen();
                            }
                            else if(adminOption == "10")
                            {
                                UI.menuUI.clearScreen();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input....");
                        Console.ReadKey();
                    }
                    UI.menuUI.clearScreen();
                }
                else if(option == 2)
                {
                    string w = UI.mUserUI.signIn();
                    UI.menuUI.clearScreen();
                    if(w == "Doctor")
                    {
                        while(true)
                        {
                            string doctorOption = UI.menuUI.Doctor_menu();
                            if(doctorOption == "1")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                patient obj = UI.patientUI.addPatient();
                                DL.patientDL.addPatientinList(obj);
                                DL.patientDL.addPatientinFile();
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "2")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.patientUI.viewPatient();
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "3")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                DL.patientDL.deletePatient();                                
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "4")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                DL.patientDL.searchPatientbyName();
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "5")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.doctorUI.prescription();
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "6")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                int index = 0;
                                DL.patientDL.viewAppointments(index);
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "7")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.patientUI.available_test();
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "8")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.doctorUI.view_instructions();
                                UI.menuUI.clearScreen();
                            }
                            else if(doctorOption == "9")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Option....");
                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input...");
                        Console.ReadKey();
                    }
                }
                else if(option == 3)
                {
                    string w = UI.mUserUI.signIn();
                    UI.menuUI.clearScreen();
                    if (w == "Patient")
                    {
                        while (true)
                        {
                            string patientOption = UI.menuUI.Patient_menu();
                            if (patientOption == "1")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                patient obj = DL.patientDL.bookAppointments();
                                int pat = 0;
                                DL.patientDL.addAppointmentinList(obj, pat);
                                UI.menuUI.clearScreen();
                            }
                            else if (patientOption == "2")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                int idx = 0;
                                DL.patientDL.viewAppointments(idx);
                                UI.menuUI.clearScreen();
                            }
                            else if (patientOption == "3")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.doctorUI.viewDoctor();
                                UI.menuUI.clearScreen();
                            }
                            else if (patientOption == "4")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.patientUI.viewRecord();
                                UI.menuUI.clearScreen();
                            }
                            else if (patientOption == "5")
                            {
                                UI.menuUI.clearScreen();
                                UI.menuUI.header();
                                UI.doctorUI.prescription();
                                UI.menuUI.clearScreen();
                            }
                            else if (patientOption == "6")
                            {
                                UI.menuUI.clearScreen();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option...");
                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input....");
                        Console.ReadKey();
                    }
                }
                else if(option == 4)
                {
                    UI.menuUI.clearScreen();
                    UI.menuUI.header();
                    UI.doctorUI.view_instructions();
                    UI.menuUI.clearScreen();
                }
            }
            Console.ReadKey();
        }
    }
}
