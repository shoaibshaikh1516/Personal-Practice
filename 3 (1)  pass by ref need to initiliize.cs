using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{

    class DemoRefPar 
    {
        public void ShowDouble(int x)
        {
            x *= 2;//x=x*2;      
            Console.WriteLine(x); 

        }


        public void ShowDouble_22(ref int x)
        {
            x *= 2;//x=x*2;      
            Console.WriteLine(x);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DemoRefPar df = new DemoRefPar();
            int num = 5;
            Console.WriteLine("Value of Num  {0} ",num);
            
            df.ShowDouble(num);
            Console.WriteLine("");
            Console.WriteLine("After multipication");

            Console.WriteLine("Value of Num  {0} ", num);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

            df.ShowDouble_22(ref num); /* if we dont write ref then 
                                        it will show error as we pass  method
                                        showdouble_22 a ref */ 
            Console.WriteLine("Value of Num 2nd method num = {0} ", num);
            

            Console.ReadLine();


        }
    }
}
