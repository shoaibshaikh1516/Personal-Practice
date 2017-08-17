using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication55
{
    class Demo
    {

        public void Show(int x, int y, int z = 12)   // default parameter i.e z
        {
        Console.WriteLine(x);
        Console.WriteLine(y); 
        Console.WriteLine(z); 
        }

        public void Display(string s, int y, char c)
        {
            Console.WriteLine(s);
            Console.WriteLine(y); 
            Console.WriteLine(c);

        }

    }
    class Program
    {  


        static void Main(string[] args)  
        {
            Demo d = new Demo();           
            d.Show(3,4);
            Console.WriteLine("---------------");
            d.Show(3, 4, 25);
            Console.WriteLine("---------------");
            d.Display("abc", 56, 's');              // without changing the order of parameter
            Console.WriteLine("---------------");

            d.Display(c: 'a', y: 56, s: "xxd");      // with changing the order of parameter


            dynamic x = "shoaib";       // works at runtime so fast execution
            Console.WriteLine(x);
            Console.WriteLine(x.GetType()); // show type of dynamic  
            Console.Read();
        }
    }
}
