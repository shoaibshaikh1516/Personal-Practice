using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class demo 
    {
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fistapp");
            int x, y, result;
            Console.WriteLine("enter two integer");
            x=Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            result = x + y;
            Console.WriteLine("the addition of "+ x + " and " + y + " is "+result);
            
            Console.Read();
        }
    }
}
