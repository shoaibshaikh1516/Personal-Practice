using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    abstract class Demo
    {
        public abstract void showAbs();
       
        public void Display()
        {
            Console.WriteLine("hello ab class");
         }
    }

    class implement : Demo
    {
        public override void showAbs()
        {
            Console.WriteLine("ab method  implements");

        }    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new implement();
            implement imp = new implement();


        }
    }
}
