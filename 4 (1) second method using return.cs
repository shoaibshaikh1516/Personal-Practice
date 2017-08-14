using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication25
{
    abstract class Quadrilateral
    {
        protected double length;

        public   abstract double Area();
        public   abstract double Perimeter();

        public Quadrilateral(double s)
        {
            length = s;

        }



    }



    class Square : Quadrilateral
    {
       public Square(double s):base(s)
        {
            

        } 


        public override double Area()
        {
            
           return (length * length);
           
        }

        public override double Perimeter()
        {
           
           return (4 * length);
           

        }
    }

    class Rectangle : Quadrilateral
    {
        protected double breadth;

        public Rectangle(double l, double b):base(l)
        {
            
            breadth = b;
        }


        public override double Area()
        {
           
           return(length * breadth);
            
        }

        public override double Perimeter()
        {
            
            return ( 2 * (length + breadth));
            

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            double areaOfREC, areaOfSq; //IsSquare property  is remaining complete it 
            double periOfREC, periOfSq;

            Rectangle rc = new Rectangle(5,6);
            areaOfREC=rc.Area();
            periOfREC=rc.Perimeter();
            Console.WriteLine("rect area is {0}",areaOfREC);
            Console.WriteLine("peri  is {0}", periOfREC);

            Square sq = new Square(4);
            areaOfSq=sq.Area();
            periOfSq=sq.Perimeter();
            Console.WriteLine("square area is {0}", areaOfSq);
            Console.WriteLine("peri is {0}", periOfSq);
            Console.ReadKey();
        }
    }
}
