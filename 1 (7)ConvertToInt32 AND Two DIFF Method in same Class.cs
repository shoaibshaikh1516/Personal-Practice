using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class math
    {
        public int x, y,z;

        public int Add()
        {
            z = x + y;
            return z;
        }
        public int Sub()
        {
            z = x - y;
            return z;
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            int res;
            math m = new math();
            Console.WriteLine("Enter the values");
            m.x = Convert.ToInt32 (Console.ReadLine());
            m.y = Convert.ToInt32(Console.ReadLine());
            
            res=m.Add();
            Console.WriteLine("{0}",res);
            Console.ReadLine();

        }
    }
}
