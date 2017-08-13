using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    abstract class Quadrilateral
    {
        protected double length;

        public abstract void Area();
        public abstract void Perimeter();
						// no constructor as requied in statment ..create it


    }



    class Square : Quadrilateral
    {
        public Square(double s)
        {
            length = s;		// as in quad class constructor pass value here using base (so inheritance violated as it is reinitialized) 		

        }


        public override void   Area()
        {
            double area;
            area = length * length;
            Console.WriteLine("Area {0}", area);
        }

        public override void Perimeter()
        {
            double peri;
            peri = (4 * length);
            Console.WriteLine("peri square{0}", peri);

        }
    }

    class Rectangle : Quadrilateral
    {
        protected double breadth;

        public Rectangle(double l, double b)
        {
            length = l;   				//violated as it is reinitialized 
       
            breadth = b; 
	}

        public override void Area()
        {
            double area;
            area = length * breadth;
            Console.WriteLine("rea {0}",area);
        }

        public override void Perimeter()
        {
            double per;
            per = 2 * (length + breadth);
            Console.WriteLine("this is peri rect{0}", per);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rc = new Rectangle(5, 6);
            rc.Area();
            rc.Perimeter();
            Square sq = new Square(4);
            sq.Area();
            sq.Perimeter();
            Console.ReadKey();
        }
    }
}
