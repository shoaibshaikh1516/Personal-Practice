using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication42
{
    class DemoIndex
    { 
            string[] range = new string[5];
        public string this[int indexRange]     // indexer imp similar as property
                                               //to enter value in string at its index
                                              //we want class to behave like arrary so we use index-er
        {
            get { return range[indexRange]; }
            
            set { range[indexRange] =value; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            DemoIndex d1 = new DemoIndex();
            d1[0]="hello";
            d1[1] = "hi";
            d1[2] = "Gm";
            d1[3] = "Bye";
            d1[4] = "GN";
            Console.WriteLine("{0}",d1[0]);
            Console.WriteLine("{0}", d1[1]); 
            Console.WriteLine("{0}", d1[2]);
            Console.WriteLine("{0}",d1[3]);
            Console.WriteLine();

            SortedList s1 = new SortedList();
            s1["one"] = 524;    // sorted is possibe LHS provide type same then get sorted i.e RHS
            s1["two"] = "Mon";
            s1["three"] = "April";
            s1["four"] = 132.342;

            foreach(DictionaryEntry de in s1)
            {
                Console.WriteLine("{0}={1}",de.Key,de.Value);
            }

            
            Console.ReadKey();

        }
    }
}
