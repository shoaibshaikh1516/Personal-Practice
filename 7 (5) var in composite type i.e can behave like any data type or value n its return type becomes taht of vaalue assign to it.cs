using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication52
{
    class Employee
    {
        public int Age { get; set; }  /* w/o declaring varaible value is assign
                                       this is automatic property and it has to have both property get, set */

        public string Name { get; }  // this gives error     
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Age = 22;

            var x = new[] { 1, 2, 3, 45, 6, 5 };  // int array 
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
                    
             var a = 40;
             var s = "Today is Tednesday(behave like string)";
            
            Console.Read();
        }
    }
}
