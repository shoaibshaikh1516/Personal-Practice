using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Exception;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Fst1 = null; //new obiect is create only ref is create so no memory allocation
            StreamWriter sw = null;    //new obiect is create only ref is create so no memory allocation
            try
            {
                fst1=new FileStream(@"e:\text2.txt", FileMode.Create, FileAccess.Write);  //object is created here also memory is allocated here(new)
                sw=new StreamWriter(Fst1);
                sw.Write("hello");
                sw.Write(" Learning input output");
                
                /*
                FileStream FstR = new FileStream("e:\\text2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(Fst);
                Console.WriteLine(sr.ReadLine());       // do on ur own try, this also
                 
                 */

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // sr.Close();
                // FstR.Close();
                sw.Close();
                Fst1.Close();
            }
            Console.ReadLine();
        }
    }
}
