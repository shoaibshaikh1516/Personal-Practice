using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {  int x;
            Console.WriteLine("enter  a no");
            
            x=Convert.ToInt32(Console.ReadLine());
            if ((x %2) == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
           
             }
         Console.ReadLine();

        }

    }
    
}
