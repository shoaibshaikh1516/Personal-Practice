using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            int cap;

            StringBuilder sb = new StringBuilder("hi");
            sb.Append("hello");
            sb.Insert(2, " and ");
            Console.WriteLine(sb.ToString());
            
            string a = "man";
            string b;
           Console.WriteLine(sb.AppendLine(a));
           
            cap = sb.Capacity;		// try maxcapacity
           Console.WriteLine(cap);
            
            sb.Clear();
            Console.WriteLine(sb);
            
            string str1 = " this is copy  to method ";
            char[] chrs = new char[10];
				
            str1.CopyTo(0, chrs, 0,10);
            foreach (char cs in chrs)
            {
                Console.Write(cs);
            }
            Console.ReadKey();
        }
    }
}
