using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class cal
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void Add(double x,double y)
        {
            Console.WriteLine("results is"+(x+y));

        }

        public void Add(string x, string y)
        {
            Console.WriteLine(x+y);        
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            cal c = new cal();
            c.Add("hello ", " internet");
            c.Add(4.0, 2.2);

            Console.ReadKey();

        }

    }
}
