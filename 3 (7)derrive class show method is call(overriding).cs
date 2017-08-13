using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base Class mehtod ");
        }
    }

    class Derrived:BaseClass
    {
        public override void show()
        {
          Console.WriteLine("Derrived class Method");
        }

    }

    class d1 : BaseClass
    {
        public new void show()  //method call base class and here keyword 'new' is used 
        {
            Console.WriteLine("d1 class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc_Obj = new BaseClass();
            bc_Obj.show();

            Console.WriteLine("------------------");

            Derrived d_Obj = new Derrived();
            d_Obj.show();

            Console.WriteLine("------------------");
            Console.WriteLine("------------------");

            BaseClass b = new Derrived();
            b.show();               //derrive class show method is call(overriding)

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("------------------");


          //  Derrived d = (Derrived)new BaseClass(); 
                                            /*casting error  (int double concept )
                                             * emplicit convert but still error will come*/

            BaseClass newbase = new d1();
            newbase.show();
            
            Console.ReadLine();

        }
    }
}
