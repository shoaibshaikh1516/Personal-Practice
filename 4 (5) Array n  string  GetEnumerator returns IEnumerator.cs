
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;    //add this  

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
           Array intArr =Array.CreateInstance(typeof(int),5);
           intArr.SetValue(2,0);
           intArr.SetValue(3,1);  //   (Value/index)
           intArr.SetValue(4,3);
           intArr.SetValue(1,2);
           intArr.SetValue(10,4);

           foreach (int x in intArr)
           {
               Console.WriteLine(x);
           }
           
            Array.Sort(intArr);		// try this on ur own(sorting)

           Array ob =Array.CreateInstance(typeof(int),5);

           Console.WriteLine(intArr.ToString());

           intArr.CopyTo(ob,0);  // start index

           foreach (int r in ob)
           {
               Console.WriteLine(r);
           }

           Console.WriteLine("----------------------------");
           IEnumerator obj = intArr.GetEnumerator();   // GetEnumerator returns IEnumerator so we catch it in obj(i.e asign)
          while (obj.MoveNext())
          {
              Console.WriteLine(obj.Current);
          }

		string str = "this is first string";
          string str1 = "hello poona";
          string[] result =str.Split('i',' ');            //works with params and result is string array
                                                        // bracket contains spliting char 
          foreach (string s in result)
          {
              Console.WriteLine(s);
          }

	   Console.WriteLine();
         Console.WriteLine("the upper {0} is upper case \t\n{1}",str,str.ToUpper());

         Console.WriteLine("----Copy string----");
            Char[] ch = new char[str1.Length];
            str.CopyTo(0, ch, 0, str1.Length);   //new is where we want to copy
   
            foreach(char c in ch)
             {
                 Console.Write(c);  // or Console.WriteLine(c);  
                                    // due to foreach it will print char by char i.e single char
             }
            Console.WriteLine("");
            Console.WriteLine("----reverse string----");

            Console.WriteLine(""+str1.Replace("hello ","go"));
            
            Console.WriteLine("----Trim string----");
            Console.WriteLine(""+str1.TrimEnd('a'));
            Console.WriteLine(""+str1.Remove(4));


            Console.WriteLine("" + str1.Remove(4,4));
	
	

           Console.ReadKey();
        }
    }
}
