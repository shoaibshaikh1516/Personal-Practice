using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;			// collection is used here


namespace colllectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine(arr.Capacity+"  is the capacity");
            arr.Add(5);   // accept type object
                            // here we accepted int

            int[] intArr = { 4, 6, 9, 8, 2, 15, 65 };
            ArrayList arr_2 = new ArrayList();

            arr_2.Add(5);
            arr_2.Add(23);

            arr_2.AddRange(intArr);

            foreach (int a in arr_2)
            {
                Console.WriteLine(""); 
                Console.Write(" Array list element is "+a); 
            }
            Console.WriteLine("\n\n--------------");

            Console.WriteLine("Below GetEnumerator   is same as Array list");    // topic comes under collection

            Console.WriteLine("");

            IEnumerator en = intArr.GetEnumerator();
            
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
                
            }
           
             Console.ReadKey();
          
        }
    }
}
