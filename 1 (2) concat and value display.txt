using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class demo 
    {
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fistapp");
            string name;
            int rollno, age;


            Console.WriteLine("Enter your name");
             name = Console.ReadLine();
           
            Console.WriteLine("Enter age");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter roll no");
            rollno=Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("my name is "+ name + " age " + age + " roll no is "+rollno);
             
            Console.Read();
        }
    }
}
