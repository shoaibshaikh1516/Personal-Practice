using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conproENum
{
    enum colors
    {
        Red=12,Green,Orange,Blue
    }

    class favColor
    {
        colors clrs;  //enum obj
        public void MyColor()
        {
            Console.WriteLine(clrs);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            colors clr = colors.Green;
            Console.WriteLine(clr);

            colors clr2 = colors.Blue;
            Console.WriteLine(clr2);
            
            int red = (int)colors.Red;
            Console.WriteLine(red);
            Console.ReadLine();
        }
    }
}
