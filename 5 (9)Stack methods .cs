using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;               // imp add


namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("hello ");
            stk.Push("stack ");
            stk.Push("prog");
            stk.Push("nyc");

            foreach(string aa in stk)
            {
                Console.WriteLine(aa);
            }

            Console.WriteLine(".....");
            Console.WriteLine(stk.Peek());

            Console.WriteLine(".....");
						// try pop etc.
           
               
            Console.Read();
        }
    }
}
