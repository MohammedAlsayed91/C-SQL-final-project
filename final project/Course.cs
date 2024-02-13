using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Course
    {

        public static SqlConnection connection()
        {
            course stu = new course();
            string str = @"Data Source=DESKTOP-7222SDS\MSSQLSERVER1;Initial Catalog=finalProject;Integrated Security=True";
            SqlConnection con;
            con = new SqlConnection(str);
            con.Open();
            return con;
        }


        public static void AddNewCourse()
        {

            SqlConnection con = connection();

            Console.WriteLine("Enter course name:");
            string name = Console.ReadLine();

            

            string query = "INSERT INTO course(courseName) VALUES('" + name + "')";


            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

            Console.WriteLine("New course added successfully");

            con.Close();
        }

        public static void RemoveCourse()
        {


            SqlConnection con = connection();


            Console.WriteLine("enter ID of course to edit : ");

            int courseId = Convert.ToInt32(Console.ReadLine());







            string query = "delete from course where CourseId = ('" + courseId + "' )";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Course removed successfully");
        }

        public static void EditCourseInfo()
        {

            SqlConnection con = connection();

            Console.WriteLine("enter ID of Course to update : ");

            int courseId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter new course name:");
            string name = Console.ReadLine();



            string query = "UPDATE course SET courseName = '" + name + "' WHERE CourseId = '" + courseId+"'";



            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

            Console.WriteLine("New course updated successfully");

            con.Close();

        }


        public static void PrintCoursesInFile()
        {
            SqlConnection con = connection();

            string query = "SELECT * FROM course";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

           
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\OneDrive\\Documents\\courses.txt"))
            
            {
              
                writer.WriteLine("CourseId\tCourseName");
                Console.WriteLine("CourseId\tCourseName");


                while (reader.Read())
                {
                    int courseId = (int)reader["CourseId"];
                    string courseName = (string)reader["courseName"];
                 
                    Console.WriteLine($"{courseId}\t \t {courseName}");
                    writer.WriteLine($"{courseId}\t \t {courseName}");
                }
            }

            Console.WriteLine("Courses have been printed to 'courses.txt'");

            reader.Close();
            con.Close();
        }

    }
}
