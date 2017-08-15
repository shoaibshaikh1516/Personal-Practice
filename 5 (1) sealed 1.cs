using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication29
{
    class A
    {
        public virtual void Show()
        {

        }
    }

    class B:A
    {
        public sealed override void Show()     // public override void Show() 
        { 
                // base .show();
        }
    }

    class C:B
    {
        public override void Show()   // if it is sealed then it will throw error here
        { 
            //
        }

    }
   

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
