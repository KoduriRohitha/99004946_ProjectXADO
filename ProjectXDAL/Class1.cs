using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProjectXDAL
{
    public class Class1
    {
        static SqlConnection connection = null;
        public static SqlConnection ConnectToDB()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Constr"].ConnectionString;
            try
            {
                return new SqlConnection(conStr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static List<string> GetData(string str)
        {
            List<string> list = new List<string>();
            SqlCommand command = null;
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                SqlDataReader reader = command.ExecuteReader();
                int columns = reader.FieldCount;
                while (reader.Read())
                {
                    string temp = "";
                    for (int i = 0; i < columns; i++)
                    {
                        temp += reader[i].ToString() + " ";
                    }
                    list.Add(temp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
        public static List<string> GetData1(string str)
        {
            List<string> list = new List<string>();
            SqlCommand command = null;
            try
            {

                command = new SqlCommand(str, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string temp = reader["Courseid"].ToString() + " " + reader["CourseOwner"].ToString() + " " + reader["CourseTitle"].ToString() + " " + reader["AssessmentId"].ToString() + " " + reader["HoursAssigned"].ToString() + " " + reader["CourseSyllabus"].ToString();
                    list.Add(temp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
    }
}

