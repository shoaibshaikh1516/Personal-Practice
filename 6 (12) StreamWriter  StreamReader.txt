using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {

             
            FileStream Fst1 = new FileStream(@"e:\text2.txt", FileMode.Create,FileAccess.Write);  // both same
            StreamWriter sw = new StreamWriter(Fst1);
            sw.Write("hello");
            sw.Write(" Learning input output");
            sw.Close();
            Fst1.Close();

            FileStream Fst = new FileStream("e:\\text2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(Fst);
            Console.WriteLine(sr.ReadLine());
            sr.Close();
            Fst.Close();

          
            Console.ReadLine();
        }
    }
}
