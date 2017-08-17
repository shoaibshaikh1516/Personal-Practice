using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication53
{
    public static class ExtClass
    {
        public static int Add(this int a, int x, int y) //should have this keyword as it tells us which type it extends n it(this) should be first parameter
        {
            return x + y;
        }
        public static int Mul(this int a, int x)
        {
            return a * x;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = 40; //if we dont assign value and still use it it will give error
            var s = "Today is Tednesday(behave like string)";

            // <---linked with line 10 (Add) n it works only if it is assign value to 'a'i.e two line above

            var b = 40;

            Console.WriteLine("\n------Extend class--------------");
            Console.WriteLine(a.Add(5, 2));
            Console.WriteLine(b.Mul(2));

            Console.Read();
        }
    }
}
