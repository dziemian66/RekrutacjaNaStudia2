using System;

namespace RekrutacjaNaStudia
{
    class Program
    {
        static void Main(string[] args)
        {        
            FieldOfStudy electrotechnics = new FieldOfStudy("Electrotechnics");

            FieldOfStudy automationAndRobotics = new FieldOfStudy("Automation and Robotics");
            automationAndRobotics.Multipliers["MathExtended"] = 1.5f;
            automationAndRobotics.Multipliers["PhysicsExtended"] = 1.5f;

            FieldOfStudy informatics = new FieldOfStudy("Informatics");         
            informatics.Multipliers["MathBasic"] = 0.75f;
            informatics.Multipliers["ForeignLanguageBasic"] = 0.5f;
            informatics.Multipliers["ForeignLanguageExtended"] = 0.75f;
            informatics.Multipliers["PhysicsExtended"] = 1.0f;

            ListOfStudents listOfStudents = new ListOfStudents();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to university of technology recruiting app!");
                Console.WriteLine("Who are you?");
                Console.WriteLine("1.Recruiter \n2.Student");
                var key = Console.ReadKey();
                switch(key.KeyChar)
                {
                    case '1':
                        Console.WriteLine("\nPress number (1 or 2) and choose what you want to do:");
                        Console.WriteLine("1.Open recruiting for:");
                        Console.WriteLine("2.Close recruiting for:");
                        key = Console.ReadKey();
                        Console.WriteLine("\n1." + electrotechnics.NameFieldOfStudy + "\n2." + automationAndRobotics.NameFieldOfStudy + "\n3." + informatics.NameFieldOfStudy);
                        switch (key.KeyChar)
                        {
                            case '1':                              
                                key = Console.ReadKey();
                                switch( key.KeyChar)
                                {
                                    case '1':
                                        electrotechnics.OpenRecruiting();
                                        break;
                                    case '2':
                                        automationAndRobotics.OpenRecruiting();
                                        break;
                                    case '3':
                                        informatics.OpenRecruiting();
                                        break;
                                    default:
                                        Console.WriteLine("\nIncorrect number.\nPress any key to continue...");
                                        Console.ReadKey();
                                        break;
                                }
                                break;
                            case '2':                                      
                                key = Console.ReadKey();
                                switch (key.KeyChar)
                                {
                                    case '1':
                                        electrotechnics.CloseRecruiting(listOfStudents);
                                        break;
                                    case '2':
                                        automationAndRobotics.CloseRecruiting(listOfStudents);
                                        break;
                                    case '3':
                                        informatics.CloseRecruiting(listOfStudents);
                                        break;
                                    default:
                                        Console.WriteLine("\nIncorrect number.\nPress any key to continue...");
                                        Console.ReadKey();
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case '2':
                        Console.WriteLine("\nPress number (1 or 2) and choose what you want to do:");
                        Console.WriteLine("1.Apply to:");
                        Console.WriteLine("2.Check your application");
                        key = Console.ReadKey();
                        switch (key.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("\n1." + electrotechnics.NameFieldOfStudy + "\n2." + automationAndRobotics.NameFieldOfStudy + "\n3." + informatics.NameFieldOfStudy);
                                key = Console.ReadKey();
                                switch (key.KeyChar)
                                {
                                    case '1':
                                        electrotechnics.CheckAddApplicant();

                                        break;
                                    case '2':
                                        automationAndRobotics.CheckAddApplicant();
                                        break;
                                    case '3':
                                        informatics.CheckAddApplicant();
                                        break;
                                    default:
                                        Console.WriteLine("\nIncorrect number.\nPress any key to continue...");
                                        Console.ReadKey();
                                        break;
                                }
                                
                                break;
                            case '2':
                                listOfStudents.FindStudent();
                                break;
                            default:
                                break;
                        }         
                        break;
                    default:
                        Console.WriteLine("\nIncorrect number.\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                }

            }


  
        }
    }
}