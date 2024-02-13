using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Student
    {

        public static SqlConnection connection()
        {
            student stu = new student();
            string str = @"Data Source=DESKTOP-7222SDS\MSSQLSERVER1;Initial Catalog=finalProject;Integrated Security=True";
            SqlConnection con;
            con = new SqlConnection(str);
            con.Open();
            return con;
        }
       
       


        

         


            public static void AddNewStudent()
            {

                SqlConnection con = connection();

                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter student Gender:");
                string gender = Console.ReadLine();

            string query = "INSERT INTO student(name, gender) VALUES('" + name + "', '" + gender + "')";


            SqlCommand cmd = new SqlCommand(query, con);
               

                cmd.ExecuteNonQuery();

                Console.WriteLine("New student added successfully");

                con.Close();
            }

            public static void RemoveStudent()
            {


                SqlConnection con = connection();


                Console.WriteLine("enter ID of student to remove : ");

                int studentId = Convert.ToInt32(Console.ReadLine());







                string query = "delete from student where StudentId = ('" + studentId + "' )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                Console.WriteLine(" student removed successfully");
            }

            public static void EditStudentInfo() {

            SqlConnection con = connection();

            Console.WriteLine("enter ID of student to update : ");

            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student Gender:");
            string gender = Console.ReadLine();

            string query = "UPDATE student SET name = '" + name + "', gender = '" + gender + "' WHERE studentId = '" + studentId+ "'";


            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

            Console.WriteLine("New student updated successfully");

            con.Close();

        }


        public static void InfoForAllStudents()
        {
            SqlConnection con = connection();

            string query = "SELECT * FROM student";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int studentId = (int)reader["StudentId"];
                string name = (string)reader["name"];
                string gender = (string)reader["gender"];

                Console.WriteLine("Student ID: " + studentId);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gender: " + gender);
                Console.WriteLine("-----------------------------------------");
            }

            reader.Close();
            con.Close();
        }


        public static void SearchStudentByID()
        {
            SqlConnection con = connection();

            Console.WriteLine("Enter ID of student to search:");
            int studentId = Convert.ToInt32(Console.ReadLine());

            string query = "SELECT * FROM student WHERE StudentId = @StudentId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@StudentId", studentId);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string name = (string)reader["name"];
                string gender = (string)reader["gender"];

                Console.WriteLine("Student ID: " + studentId);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gender: " + gender);
            }
            else
            {
                Console.WriteLine("No student found with ID " + studentId);
            }

            reader.Close();
            con.Close();
        }


        public static void DisplayStaticStudent()
        {
            SqlConnection con = connection();

            string query = "SELECT COUNT(*) AS TotalStudents, SUM(CASE WHEN gender = 'male' THEN 1 ELSE 0 END) AS MaleStudents, SUM(CASE WHEN gender = 'female' THEN 1 ELSE 0 END) AS FemaleStudents FROM student";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int totalStudents = (int)reader["TotalStudents"];
                int maleStudents = (int)reader["MaleStudents"];
                int femaleStudents = (int)reader["FemaleStudents"];

                Console.WriteLine("Total Students: " + totalStudents);
                Console.WriteLine("Male Students: " + maleStudents);
                Console.WriteLine("Female Students: " + femaleStudents);
            }
            else
            {
                Console.WriteLine("No student data found.");
            }

            reader.Close();
            con.Close();
        }


    }
}


