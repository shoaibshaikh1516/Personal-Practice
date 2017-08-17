using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication54
{
    delegate int Mydel(int x, int y);   //delegate declare for Anonymous

   
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----Anonymous-------- \n ");
            Mydel del = delegate(int x,int y)  //Anonymous    2.0
                {
                    return x + y;
                };
            Console.WriteLine(del(1,2));
            Console.WriteLine(" ");

            Console.WriteLine("------Lambda------------- ");  //same as above with diff method 
            Mydel obj=(x,y)=> x+y;            //we do not return value here atutomatically understand type
            Console.WriteLine(obj(3, 4));


            Console.WriteLine(" ---without delegate-----");
            Func<int, int, int> fun = (x, y) => x + y;//no need to delcare delegate(without delegate).It has two values n one is return type     i.e <>
            Console.WriteLine(fun(5,6));

            Console.WriteLine("---------Action --------- ");  //Acion has void return type
            Action<string> act = s => Console.WriteLine(s) ;  
            act("This is a string");

         
          
            Console.Read();

        }
    }
}
