using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList arr = new ArrayList();
            Console.WriteLine(arr.Capacity + "  is the capacity");
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
                Console.Write(" Array list element is " + a);
            }
            Console.WriteLine("\n\n--------------");

            Console.WriteLine("Below GetEnumerator   is same as Array list");    // topic comes under collection

            Console.WriteLine("");

            IEnumerator en = intArr.GetEnumerator();

            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);

            }

            Console.WriteLine("\n\n--------------");
            Console.WriteLine("");
                                    

            arr_2.Add("hello");
            arr_2.Add('c');
            arr_2.Add(234.1);             // our list is mix so we create object array


            foreach (object obj in arr_2)
            {
                Console.WriteLine(obj);
            }

            object[] obArr = new object[arr_2.Count];
            
            arr_2.CopyTo(0,obArr,0,arr_2.Count);
            Console.WriteLine("");
            foreach (object item in obArr)
            {
                Console.WriteLine("mix object arrary element \t{0}",item);
            }

            Console.WriteLine("GetRange print ");
            ArrayList getR =arr_2.GetRange(2,5);
            foreach (object aaa in getR)
            {
                Console.WriteLine(aaa);
            }

            Console.WriteLine("contains method");
            Console.WriteLine("----------------------");
            int res = arr_2.IndexOf("hello");
            Console.WriteLine( "index of hello  "+res);

            if (arr_2.Contains("hello") == true)
            {
                Console.WriteLine("contains is working");
            }
            else
                Console.WriteLine("not");



            Console.WriteLine("reverse method"); 
            
            Console.WriteLine("---------------");

            arr_2.Reverse();
            foreach (object nn in arr_2)
            {
                Console.WriteLine(nn);
            }

            // imp try again

            object[] insRange = new object[arr.Count];

            arr_2.InsertRange(arr_2.Count, insRange);
            foreach(object inR in arr_2 )
            {
                Console.WriteLine(" insert range elemect"+ inR);         
             }
            Console.WriteLine("---------------");
            arr_2.RemoveAt(2);
            foreach (object inRR in arr_2)
            {
                Console.WriteLine(" insert range elemect" + inRR);
            }
            




            Console.ReadKey();
        }
    }
}
