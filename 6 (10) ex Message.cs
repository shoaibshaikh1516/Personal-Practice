using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            Console.WriteLine("Enter your Employee id ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(empid);
            if (empid <= 0)
            {
                throw new Exception("Exployee id cannot be 0 or -ve ");
            }
            Console.WriteLine("\n");
                Console.WriteLine(empid);
            }catch(Exception ex)
             {
               Console.WriteLine(ex.Message);
             }

            Console.ReadLine();
        }
    }
}
