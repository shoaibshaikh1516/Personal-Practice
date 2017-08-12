using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{

    class paramprof
    {
        public int add(params int[] x)
        {
            int sum = 0;
            foreach (int a in x)
            {
                sum += a; 
            }
            return sum;
        }
    

    }
    class Program
    {
        static void Main(string[] args)
        {

            paramprof c = new paramprof();
            Console.WriteLine(" Params example (avoids writing n number of parameters)\t"+c.add(1,2,3));
            Console.WriteLine("i.e passing");
            Console.ReadLine();
        }
    }
}
