using System;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groupContext = new List<Group>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Menu: 1 - Add group  | 2 - Add student | 3 - Add student mark | 4 - View student list | 5 - Find student | 6 - Delete group | exit");
                Console.ResetColor();

                string userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "exit")
                {
                    break;
                }

                int selection;
                bool selectionIsValid = int.TryParse(userResponse, out selection);

                if (selectionIsValid && selection >= 1 && selection <=6) 
                {
                    switch (selection)
                    {
                        case (int)AppMenuSelection.Addgroup:

                            Console.WriteLine("Enter student name: ");
                            string ctName = Console.ReadLine();
                            if (string.IsNullOrEmpty(ctName))
                            {
                                Console.WriteLine("Group name invalid.");
                                break;
                            }

                            Console.WriteLine("Enter group MaxStudentCount: ");
                            int groupMaxStudentCount;
                            bool groupMaxStudentCountIsValid = int.TryParse(Console.ReadLine(), out groupMaxStudentCount);
                            if (!groupMaxStudentCountIsValid)
                            {
                                Console.WriteLine("MaxStudentCount invalid.");
                                break;
                            }

                            Group newgroup = new Group(ctName, groupMaxStudentCount);
                            if (groupContext.Contains(newgroup))

                            {
                                Console.WriteLine("Group already exists");
                            }
                            groupContext.Add(newgroup);
                            Console.WriteLine("Group added successfully.");

                            break;
                        case (int)AppMenuSelection.Addstudent:
                            if (groupContext.Count<=0)
                            {
                                Console.WriteLine("Group name invaled.");
                                break;
                            }

                            Console.Write("Enter student name: ");
                            string studentName = Console.ReadLine();
                            if (string.IsNullOrEmpty(studentName))
                            {
                                Console.WriteLine("Student name invalid.");
                                break;
                            }

                            Console.Write("Enter student Surname: ");
                            string studentSurname = Console.ReadLine();
                            if (string.IsNullOrEmpty(studentSurname))
                            {
                                Console.WriteLine("Student Surname invalid.");
                                break;
                            }

                            Console.WriteLine("Enter student Point: ");
                            int studentPoint;
                            bool studentPointIsValid = int.TryParse(Console.ReadLine(), out studentPoint);
                            if (!studentPointIsValid)
                            {
                                Console.WriteLine("Point invalid.");
                                break;
                            }

                            break;
                        case (int)AppMenuSelection.Addstudentmark:
                            Console.WriteLine("3 cu funksiya secildi ");
                            break;
                        case (int)AppMenuSelection.Viewstudentlist:
                            Console.WriteLine("4 cu funksiya secildi ");
                            break;
                        case (int)AppMenuSelection.Findstudent:
                            Console.WriteLine("5 ci funksiya secildi ");
                            break;
                        case (int)AppMenuSelection.Deletegroup:
                            Console.WriteLine("6 ci funksiya secildi ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid menu selection.");
                }
            }
        }

    }
}
