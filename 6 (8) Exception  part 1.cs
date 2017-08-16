using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, res;
            Console.WriteLine("Enter the ywo values");
            x=Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            try
            {
                res = x / y;
                Console.WriteLine("Quotient is {0}", res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The final");
            }
            Console.ReadLine();
            
        }
    }
}
