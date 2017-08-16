using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
        ArrayList arr= new ArrayList(new string[]{"jan","feb","may","june","nov"});
        foreach (string item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------");
        Console.WriteLine("After inserting  values");
        Console.WriteLine("-----------------------");
        arr.InsertRange(2, new string[] { "mar", "april", "july", "aug", "sep" });  //insert range after 2 index
        foreach (string item in arr)  //item behave like new var again
        {
            Console.WriteLine(item);
        }

        Console.Read();
        }
    }
}
