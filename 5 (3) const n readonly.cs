using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication31
{
    class Demo
    {
        const double pir = 3.14;
        readonly int age;
        public Demo()
        { 
        }

        public Demo(int _age)
        {
            age = _age;
           
        }
        
        public int Display()
        {
            //age=22;
            return age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
       

            Demo d = new Demo(22);   // pass value

            // Demo wt = null; this allowed as it is class

            Console.WriteLine(d.Display());


            int? p = null;// we cannot assign Null value to var 
            string str = null;
            // double? sal = 13213.415;   //allowed
            if (p.HasValue)
            {
                Console.WriteLine("yes" + p.Value);

            }
            else
                Console.WriteLine("no");

            Console.ReadKey();
        }
    }
}
