using System;
using System.Collections.Generic;
using System.Data;
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
            string cmdText = "SELECT * FROM pro";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", row["pid"].ToString(), row["pname"].ToString(), row["ctg"].ToString(), row["price"].ToString(), row["qty"].ToString());
            }
            Console.ReadLine();
        }
    }
}