using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eid;
            string ename;
            string ejob;
            int sal;

            Console.WriteLine("Enter ID: ");
            eid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name: ");
            ename = Console.ReadLine();

            Console.WriteLine("Enter job: ");
            ejob = Console.ReadLine();

            Console.WriteLine("Enter salary: ");
            sal = int.Parse(Console.ReadLine());

            Console.WriteLine("-------Emp Details--------");
            Console.WriteLine("Emp ID: " + eid);
            Console.WriteLine("Emp Name: " + ename);
            Console.WriteLine("Emp Job: " + ejob);
            Console.WriteLine("Emp salary: " + sal);

            Console.ReadLine();
        }
    }
}
