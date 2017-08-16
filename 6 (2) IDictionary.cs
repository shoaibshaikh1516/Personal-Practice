using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();  //IDictionary part of 
            ht.Add("one","two");
            ht.Add("two","second");
            ht.Add("three","third");
            ht.Add("four","fourth"); 
            ht.Add("five","fifth");

            foreach(object obj in ht)
            {
                Console.WriteLine(obj);     // this does not work point to note
            }
            Console.WriteLine("-----------------------");
            
            foreach(DictionaryEntry de in ht )
            {
                Console.WriteLine(de.Key+"  "+de.Value);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine(ht.Contains("five"));    //Containskey  and Contains same
            Console.WriteLine(ht.ContainsValue("five"));
            Console.WriteLine(ht.ContainsKey("five"));

            Console.WriteLine("-----------------------");
            IDictionaryEnumerator ide = ht.GetEnumerator();  // IEnumerator inherited 
            
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key+" "+ide.Value);
            }

            Console.WriteLine("----------get hash code-------------");
            int i=ide.GetHashCode();
            Console.WriteLine(i);

            Console.WriteLine("----------use ht object of hashcode-------------");
            
            Console.WriteLine("CopyTo method");
            object [] obj1 = new object[ht.Count];

            ht.CopyTo(obj1,0);                  //imp

             foreach (DictionaryEntry cs in obj1)
            {
                Console.WriteLine(cs.Key+" "+ cs.Value);
            }


             Console.WriteLine("----index value to understand indexor ---- ");
             ht["34"]=34;
             ht[23]="23";
             ht[123]='2';
             ht["hello"]=46.4;
             ht["hi"]=145.444;

             foreach (DictionaryEntry onDe in ht)
             {
                 Console.WriteLine(onDe.Value);
             }

            Console.ReadKey();
        }
    }
}
