using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    static class StaticClass
    {
        static int age;

        public static int Age
        {
            get { return StaicClass.age; }
            set { StaicClass.age = value; }
        }


        public static void show()
        {

            Console.WriteLine(age);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            StaticClass.Age = 22;
            StaticClass.show();
            Console.ReadLine();
        }
    }
}
