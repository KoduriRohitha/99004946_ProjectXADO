using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXDAL
{
    public class Class3
    {
        public static void UpdateFaculty(int PSNo, string EmailId, string Name)
        {
            SqlConnection connection = Class1.ConnectToDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                connection.Open();
                string query = @"update Faculty set  EmailId='" + EmailId + ",Name='" + Name + "' where PSNo ='" + PSNo + "'";
                adapter.UpdateCommand = new SqlCommand(query, connection);
                int rows = adapter.UpdateCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Query Executed");
                }
                else
                {
                    Console.WriteLine("Invalid Query");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Course Details" + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertFaculty(int PSNo, string Email, string Name)
        {
            SqlConnection connection = Class1.ConnectToDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                connection.Open();
                string query = @"INSERT INTO Course values ('" + PSNo + "','" + Email + "','" + Name + "'  )";
                adapter.InsertCommand = new SqlCommand(query, connection);
                int rows = adapter.InsertCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Query Executed");
                }
                else
                {
                    Console.WriteLine("Invalid Query");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Course Details" + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DeleteFaculty(int PSNo)
        {
            SqlConnection connection = Class1.ConnectToDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                connection.Open();
                string query = @"delete from course where courseid='" + @PSNo + "'";
                adapter.DeleteCommand = new SqlCommand(query, connection);
                int rows = adapter.DeleteCommand.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Query Executed");
                }
                else
                {
                    Console.WriteLine("Invalid Query");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Course Details" + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
