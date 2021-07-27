using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXDAL
{
    public class Class2
    { 
        public static void GetDataFromProcedure(int PSNo, string EmailId, string Name)
        {
            SqlConnection connection =  Class1.ConnectToDB();
            SqlCommand command = null;
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "[dbo].[uspInsertFaculty]";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PSNo", PSNo);
                command.Parameters.AddWithValue("@EmailId", EmailId);
                command.Parameters.AddWithValue("@Name", Name);
                
                int noOfRowsAffected = command.ExecuteNonQuery();
                if (noOfRowsAffected > 0)
                {
                    Console.WriteLine("No of rows affected : " + noOfRowsAffected);
                }
                else
                {
                    Console.WriteLine("Request status : " + command.Parameters["@RequestStatus"].Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
