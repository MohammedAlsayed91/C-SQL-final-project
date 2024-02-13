using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Score
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


        public static void ScoreAvg()
        {
            SqlConnection con = connection();

            Console.WriteLine("Enter course ID to calculate average score:");
            int courseId = Convert.ToInt32(Console.ReadLine());

            string query = "SELECT AVG(value) AS AverageScore FROM score WHERE CourseId = '"+courseId+"'";

            SqlCommand cmd = new SqlCommand(query, con);
           

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                double averageScore =Convert.ToDouble( reader["AverageScore"]);
                Console.WriteLine($"Average score for course {courseId}: {averageScore}");
            }
            else
            {
                Console.WriteLine("No scores found for the specified course.");
            }

            reader.Close();
            con.Close();
        }

        public static void PrintScoreInFile() {



            SqlConnection con = connection();

            string query = "SELECT * FROM score";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();


            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\OneDrive\\Documents\\Score.txt"))

            {

                writer.WriteLine("ScorID \t StudentID \t CourseID  \t value");
                Console.WriteLine("ScorID \t\t StudentID \t CourseID  \t value");


                while (reader.Read())
                {
                    int scoreID = (int)reader["ScoreId"];
                    int studentID = (int)reader["StudentID"];
                    int courseID = (int)reader["CourseID"];
                    int Value = (int)reader["value"];

                    Console.WriteLine($"{scoreID}\t   \t{studentID} \t \t {courseID}\t \t{Value}");
                    writer.WriteLine($"{scoreID}\t   \t {studentID} \t \t {courseID}\t \t {Value}");
                }
            }

            Console.WriteLine("Scores have been printed to 'Score.txt'");

            reader.Close();
            con.Close();












        }
        public static void RemoveScore() {



            SqlConnection con = connection();


            Console.WriteLine("enter Score to  Remove : ");

            int scroreID = Convert.ToInt32(Console.ReadLine());







            string query = "delete from score where ScoreId = ('" + scroreID + "' )";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" score removed successfully");
        


    }
        public static void ManageStudentScore() {


            SqlConnection con = connection();

            Console.WriteLine("enter ID of student to update : ");

            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter course ID:");
            int courseID = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter updated score of student");
            int newValue = Convert.ToInt32(Console.ReadLine());



            string query = "UPDATE score SET value = '" + newValue + "' WHERE StudentId = '" + studentId + "' AND CourseID = '" + courseID + "'";



            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

            Console.WriteLine("score  updated successfully");

            con.Close();








        }




    }
}
