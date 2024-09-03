using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pid;
            string pname;
            int up;
            int qty;
            double tot;
            double dsc;
            double fin;

            Console.WriteLine("Product ID: ");
            pid = int.Parse(Console.ReadLine());

            Console.WriteLine("Product name: ");
            pname = Console.ReadLine();

            Console.WriteLine("Unit Price: ");
            up = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantity: ");
            qty = int.Parse(Console.ReadLine());

            tot = up * qty;

            double dp = 0;
            if(qty>50){
                dp = 30;
            }
            else if (qty>30){
                dp = 0.2;
            }
            else if (qty > 10){
                dp = 0.1;
            }

            dsc = tot * dp;
            fin = tot - dsc;


            Console.WriteLine("-------Price Details--------");
            Console.WriteLine("Total: " + tot);
            Console.WriteLine("Discount: " + dsc);
            Console.WriteLine("Final: " + fin);

            Console.ReadLine();
        }
    }
}
