using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDSSUSMITH6; Database=Sept2024Db; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);
            // conn.ConnectionString = connStr;

            string cmdText = "insert into pro VALUES(7651, 't shirt', 'clothes', 400, 5)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            conn.Open();
            Console.WriteLine("Connected to Database successfully");

            int n = cmd.ExecuteNonQuery();  // For DML:  Insert, update, delete

            Console.WriteLine("No. of rows affected :" + n);
            conn.Close();
            Console.ReadLine();
        }
    }
}