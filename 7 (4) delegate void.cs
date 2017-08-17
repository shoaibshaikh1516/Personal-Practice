using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
     delegate void MovieDel(string Name);
     
     class Program
    {
        public static void ShowCinema(string str)
        {
            Console.WriteLine("fav movie is {0} ", str);
        }
        public static void ShowMovie(string str)
        {
            Console.WriteLine("next fav movie is {0} ", str);
        }

        static void Main(string[] args)
        {
            MovieDel md = new MovieDel(ShowCinema);
            md += new MovieDel(ShowMovie);
            md("avengers");

            
            Console.Read();
        }
    }
}
