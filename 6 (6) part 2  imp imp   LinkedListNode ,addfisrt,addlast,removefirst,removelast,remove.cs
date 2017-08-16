using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aa = new ArrayList();   //example to disadvantage of Array
            aa.Add(10);                        // this is the reason to us generic class
            aa.Add(20);
            aa.Add(140);
            aa.Add(50);
           //    aa.Add("hh");  //  <--  give runtime error (compile time error is better then runtime error)
            aa.Add(5);
           
            foreach(object obj in aa)
            {
              int ans=(int)obj;       // boxing 
              Console.WriteLine(ans);
            }


            //using List<>
            Console.WriteLine("using List<>");
            Console.WriteLine("-----");
            List<int> li =new List<int>();
            li.Add(30);
            li.Add(12);

           // li.Add("hello");  // <---gives comile time error
                                // in generic class boxing and unboxing is avoided

            li.AddRange(new int [] {10,20,40,60});
           
            foreach(int x in li)
            {
                Console.WriteLine(x);
            }
             Console.WriteLine("---------equals----------");
            Console.WriteLine(li.Find(x=>x.Equals(20)));

            Console.WriteLine("------ Queue-------------");
            Queue<string> str = new Queue<string>();
            str.Enqueue("shoaib");
            str.Enqueue("shyam");
            str.Enqueue("imran");
            foreach (string ss in str)
            {
                Console.WriteLine(ss);
            }

            Console.WriteLine("------ -------------");
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt[1]="2223";
            dt[2]="63413";
            dt[3]="656";
            dt[4]="563";
            dt[5]="22";
            dt[6]="22";

            Dictionary<int, string>.Enumerator t_1 = dt.GetEnumerator();

            while(t_1.MoveNext())
            {
                Console.WriteLine(t_1.Current.Key + " " + t_1.Current.Value);
            }

            Console.WriteLine("-------------------");
            // same as obove other way do same thing
            
            foreach(KeyValuePair<int ,string> k in dt )
            {
                Console.WriteLine(k.Key+"="+k.Value);
            }


            string[] test = { "the", "fox", "over", "lazy"};
            LinkedList<string> link = new LinkedList<string>(test);
            
            Console.WriteLine("original List");

            foreach (string s in link)
            {
                Console.Write(s+""); 
            }
            Console.WriteLine("\n-----------After adding dog--------------");
            link.AddLast("dog");

            foreach (string s in link)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n for using AddAfter");

            LinkedListNode<string> curr = link.Find("the");
           link.AddAfter(curr,"quick");
           
            Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

            Console.WriteLine("\n for using AddBefore");

            LinkedListNode<string> curr1 = link.Find("lazy");
           link.AddBefore(curr1,"the");
           
            Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

           LinkedListNode<string> curr2 = link.Find("fox");
           link.AddBefore(curr2, "Brown");

           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

           LinkedListNode<string> curr3 = link.Find("over");
           link.AddBefore(curr3, "jumped");

           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

           link.AddFirst("helo");

           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

           link.AddLast("really");

           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

          
            link.RemoveFirst();
           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }


           link.RemoveLast();
           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }


           link.Remove("the");
           

           Console.WriteLine("\n");
           foreach (string s in link)
           {
               Console.Write(s + " ");
           }

            Console.WriteLine("\n---------------- first-------------");
            Console.WriteLine(link.First.Value);

            Console.WriteLine("\n ----------last-------------------");
            Console.WriteLine(link.Last.Value);
          

            Console.ReadKey();
        }
    }
}
