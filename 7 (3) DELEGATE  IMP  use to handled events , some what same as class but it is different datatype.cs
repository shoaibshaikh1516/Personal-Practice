using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication50
{       
    delegate int Calculator(int x,int y);		
    
    


    class Program
    {

        public static int Add(int a, int b)          // parameter list should be same as delegate ,order also
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static void show()
        {
            Console.WriteLine("Show method");
        }
         
        static void Main(string[] args)
        {
            Calculator cal = new Calculator(Add);

            Console.WriteLine("Addition "+cal(2, 3));      // passing value to Add
            Calculator cal2 = new Calculator(Sub);
            Console.WriteLine("Subtraction "+cal2(10, 3));
            Console.Read();
        }
    }
}
