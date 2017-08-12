using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    public enum TimeOfThday
    {
        morning,
        Evening,
        noon
    };

    class DemoEnum
    {

        public void greet(TimeOfThday t)
        {
            switch (t)
            { 
                case TimeOfThday.morning:
                    Console.WriteLine("good morning");
                    break;
                case TimeOfThday.noon:
                    Console.WriteLine("good noon");
                    break;
                case TimeOfThday.Evening:
                    Console.WriteLine("good Evening");
                    break;
           
            }
        
        }
    }




    class Program
    {   

        static void Main(string[] args)
        {

            DemoEnum de = new DemoEnum ();
            de.greet(TimeOfThday.morning);//pass value

            Console.ReadLine();
        }
    }
}
