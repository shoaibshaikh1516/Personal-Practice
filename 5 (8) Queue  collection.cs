using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue("Add");
            que.Enqueue("Elements");
            que.Enqueue("into ");
            que.Enqueue("the");
            que.Enqueue("Queue");

            foreach (string s in que)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine(que.Peek());
            Console.WriteLine("--------------------");

            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());            
            }

            

            Console.Read();

        }

    }
}
