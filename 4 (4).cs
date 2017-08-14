using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication27
{
     class Demo
     {
            int age;
            protected double salary;
            public string name;
            internal string depName;

     }

     class D : Demo
     { 
            public void Show()
            {

                Console.WriteLine(salary+name+depName);
            }
            
     }

    class Program
    {
        static void Main(string[] args)
        {

            Demo d = new Demo();
            d.name = "hi";
            d.depName = "buddy";

            D dd = new D();
            dd.Show();
            Console.ReadKey();

        }
    }
}
