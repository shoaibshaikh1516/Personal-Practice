using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication47
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name;
                name = Console.ReadLine();
                if (name == null || name=="")
                {
                    Console.WriteLine("String cannot be Null");   // same both
                    throw new Exception("Employee cannot be Null");  
                }

            }
            catch (Exception)
            {
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
