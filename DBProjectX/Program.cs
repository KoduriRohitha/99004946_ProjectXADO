using ProjectXDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectX
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Class1.ConnectToDB();
             Console.WriteLine("Batch Details");
             string query = @"select * from batch";
             List<string> l = Class1.GetData(query);
             foreach(var row in l)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Batch faculty Details");
             string query1 = @"select * from batchfaculty";
             List<string> l1 = Class1.GetData(query1);
             foreach (var row in l1)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Batch model course Details");
             string query2 = @"select * from batchmodelcoursemapping";
             List<string> l2 = Class1.GetData(query2);
             foreach (var row in l2)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Batch model Details");
             string query3 = @"select * from batchmodelmapping";
             List<string> l3 = Class1.GetData(query3);
             foreach (var row in l3)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Course faculty mapping Details");
             string query4 = @"select * from coursefacultymapping";
             List<string> l4 = Class1.GetData(query4);
             foreach (var row in l4)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Courses Details");
             string query5 = @"select * from courses";
             List<string> l5 = Class1.GetData(query5);
             foreach (var row in l5)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("faculty Details");
             string query6 = @"select * from faculty";
             List<string> l6 = Class1.GetData(query6);
             foreach (var row in l6)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Grader Details");
             string query7 = @"select * from grader";
             List<string> l7 = Class1.GetData(query7);
             foreach (var row in l7)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Model Details");
             string query8 = @"select * from model";
             List<string> l8 = Class1.GetData(query8);
             foreach (var row in l8)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("model course Details");
             string query9 = @"select * from modelcourse";
             List<string> l9 = Class1.GetData(query9);
             foreach (var row in l9)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Participant Details");
             string query10 = @"select * from Participant";
             List<string> l10 = Class1.GetData(query10);
             foreach (var row in l10)
             {
                 Console.WriteLine(row);
             }

             Console.WriteLine("Participant Batch mapping Details");
             string query11 = @"select * from ParticipantBatchMapping";
             List<string> l11 = Class1.GetData(query11);
             foreach (var row in l11)
             {
                 Console.WriteLine(row);
             }*/

            Class2.GetDataFromProcedure(102,"1@gmail.com","Faculty1");
            //Class3.InsertFaculty(101, "demo@gmail.com", "Faculty1");
            //Class3.UpdateFaculty(101, "demo@gmail.com", "Name1");
            //Class3.DeleteFaculty(101);



        }
        
    }
}
