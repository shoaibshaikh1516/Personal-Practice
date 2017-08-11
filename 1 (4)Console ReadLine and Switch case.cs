using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {  int x;
            Console.WriteLine("enter  two no");
            int a,b,c;
            char ch;

            do
               {
              

                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
            
                    Console.WriteLine("Enter ur choice");
                    x = Convert.ToInt32(Console.ReadLine());
                   switch (x)
                   {
                    case 1:
                        c = a + b;
                        Console.WriteLine("addition is {0}", c);
                        break;
                    case 2:
                        c = a - b;
                        Console.WriteLine("subtration is{0}", c);
                        break;
                    default:
                        Console.WriteLine("do u wanna continue");
                        break;
                    }

                   Console.WriteLine("do u wanna continue");
                   ch=Convert.ToChar(Console.ReadLine());

                }while (ch=='Y'|| ch=='y');

            Console.ReadLine();

        }  
   }

}
