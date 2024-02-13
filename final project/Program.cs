using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Program
    {
        private static bool isLoggedIn = false;

        static void Main(string[] args)
        {
            while (!isLoggedIn)
            {
                isLoggedIn = Login();
            }

            DisplayMainMenu();
        }

        static bool Login()
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
              
                return true;
            }

            else Console.WriteLine("enter a valid username and passowrd");
            return false;

        }

        static void DisplayMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Student Menu");
                Console.WriteLine("2. Course Menu");
                Console.WriteLine("3. Score Menu");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayStudentMenu();
                        break;
                    case "2":
                        DisplayCourseMenu();
                        break;
                    case "3":
                        DisplayScoreMenu();
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayStudentMenu()
        {
            while (true)
            {
                Console.WriteLine("\nStudent Menu:");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Remove student");
                Console.WriteLine("3. Edit student info");
                Console.WriteLine("4. Info for all students");
                Console.WriteLine("5. Search student by ID");
                Console.WriteLine("6. Display static student");
                Console.WriteLine("7. Exit Student Menu");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student.AddNewStudent();
                        break;
                    case "2":
                        Student.RemoveStudent();
                        break;
                    case "3":
                        Student.EditStudentInfo();
                        break;
                    case "4":
                        Student.InfoForAllStudents();
                        break;
                    case "5":
                        Student.SearchStudentByID();
                        break;
                    case "6":
                        Student.DisplayStaticStudent();
                        break;
                    case "7":
                        Console.WriteLine("Exiting Student Menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
           }

        static void DisplayCourseMenu()
        {
            while (true)
            {
                Console.WriteLine("\nCourse Menu:");
                Console.WriteLine("1. Add new course");
                Console.WriteLine("2. Remove course");
                Console.WriteLine("3. Edit course info");
                Console.WriteLine("4. Print all courses in file");
                
                Console.WriteLine("5. Exit course Menu");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Course.AddNewCourse();
                        break;
                    case "2":
                        Course.RemoveCourse();
                        break;
                    case "3":
                        Course.EditCourseInfo();
                        break;
                    case "4":
                        Course.PrintCoursesInFile();
                        break;                    
                 
                    case "5":
                        Console.WriteLine("Exiting Course Menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayScoreMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Score Menu:");
                Console.WriteLine("1. Score average of course");
                Console.WriteLine("2. Print scores in file");
                Console.WriteLine("3. Remove score");
                Console.WriteLine("4. Manage student score");

                Console.WriteLine("5. Exit Score Menu");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Score.ScoreAvg();
                        break;
                    case "2":
                        Score.PrintScoreInFile();
                        break;
                    case "3":
                        Score.RemoveScore();
                        break;
                    case "4":
                        Score.ManageStudentScore();
                        break;

                    case "5":
                        Console.WriteLine("Exiting Score Menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

    }
}
