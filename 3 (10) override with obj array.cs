using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    class DrawingObject 
    {
        public virtual void   Draw()
        {
            Console.WriteLine("This base class");
        }

    }

    class line : DrawingObject
    {
        public override void  Draw()
     {
    	 Console.WriteLine("This is line object ");
                 }
    }

     class Square : DrawingObject
    {
        public override void  Draw()
     {
    	 Console.WriteLine("This is square object ");
                 }
    }

     class Circle : DrawingObject
    {
        public override void  Draw()
     {
    	 Console.WriteLine("This is circle object ");
                 }
    }


    class Program
    {


        static void Main(string[] args)
        {
            DrawingObject[] db=new DrawingObject[4];
            db[0]=new line();
            db[1]=new Square();
            db[2]=new Circle();
            db[3]=new DrawingObject();
          
            foreach(DrawingObject d in db)
            {
                d.Draw();
            }
            Console.ReadKey();
        }
    }
}
