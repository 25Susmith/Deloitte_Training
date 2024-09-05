using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", Pid, Pname, UnitPrice, Quantity, Category);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer
            Product p1 = new Product()
            {
                Pid = 1026,
                Pname = "asd",
                UnitPrice = "10",
                Quantity = "1",
                Category ="First"
            };

            Product p2 = new Product() { Pid = 1027, Pname = "qwe", UnitPrice = "20", Quantity="8", Category="First" };

            Product p3 = new Product() { Pid = 1028, Pname = "zxc", UnitPrice = "30", Quantity = "5", Category = "Second" };

            Product p4 = new Product() { Pid = 1029, Pname = "rty", UnitPrice = "40", Quantity = "3", Category = "Second" };

            Product p5 = new Product() { Pid = 1025, Pname = "hyy", UnitPrice = "70", Quantity = "1", Category = "Second" };

            List<Product> pList = new List<Product>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);



            foreach (Product item in pList)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}