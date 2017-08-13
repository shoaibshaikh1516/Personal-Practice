using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class DemoVar
    {
         static int x = 0;     //
        public DemoVar()
        {
            x++;        
        }

        public void show()
        {
            Console.WriteLine(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoVar dv1 = new DemoVar();
            DemoVar dv2 = new DemoVar();
            DemoVar dv3 = new DemoVar();
            dv1.show();
            dv2.show();
            dv3.show();
            Console.ReadLine();
        }
    }
}
