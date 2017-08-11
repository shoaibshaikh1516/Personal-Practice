using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("ENTER size");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("ENTER ARRY ELEMENTS");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("for each");
            Console.WriteLine("");
            foreach (int sec_var in arr)
            {
                
                Console.WriteLine(sec_var);
            }

                Console.ReadLine();
        }

    }
}
