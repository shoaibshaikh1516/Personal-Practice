using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ConsoleApplication49
{
    

    class Program
    {
        static void Main(string[] args)
        {

            using (FileStream fs = new FileStream(@"d:\test2.txt", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))      //there are two using keyword 
                {
                    sw.Write("understanding the using concept");
                    sw.Write("using disposes object agter their use");
                }
            }
            Console.WriteLine("\n check the file in d:");

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("--reading from file using keyword--\n");
            using (FileStream fs2 = new FileStream(@"d:\test2.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs2))
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            
            
            Console.Read();
        }
    }
}
