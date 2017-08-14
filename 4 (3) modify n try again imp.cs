using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    interface IOne
    {
        string Name{get;set;}  //property 
        int Add(int x,int y);
      
    }

    interface ITwo
    {
        string ShowName();
    }

    class Base
    { 
    
    
    }

    class DemoInterface :Base,IOne,ITwo   //inherit base shoulb be 1st name only
    {
        string name;  //variable name

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Add(int a, int b)
        {
            return a + b;

        }

        public string ShowName()
        {
            return name;
        }

        public int Subtract(int x,int y)
        {
            return x - y;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string n,tw,on;
            int ad, sb;
            IOne one = new DemoInterface();
            one.Name = "MYname";
            Console.WriteLine("-------------------------");
            Console.WriteLine("Addition :{0}",one.Add(4,5));
            
            ITwo two = new DemoInterface();
            tw = two.ShowName();
            Console.WriteLine("{0}",tw);
            Console.WriteLine("-------------------------");
            DemoInterface demo  =new DemoInterface();
            
            demo.Name = "shoaib";
            n=demo.ShowName();
            Console.WriteLine("-------------------------");
            
            Console.WriteLine("name is {0}",n);
            Console.WriteLine("Addition :{0}", demo.Add(5, 6));
            sb=demo.Subtract(9,5);
            Console.WriteLine("subtract{0}",sb);

            Console.ReadKey();

        }
    }
}
