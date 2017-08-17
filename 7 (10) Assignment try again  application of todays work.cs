using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication56
{
    public class Employee
    {
        public int eid { get; set; }
        public int salary { get; set; }
        public string ename { get; set; }
    }
    public static class ExtEmployee
    {
        public static void Show(this Employee e, int eid,int salary,string ename) // employee class is extended
        {
            Console.WriteLine(eid);
            Console.WriteLine(salary);
            Console.WriteLine(ename);

        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();

            e.Show(12, 1100313, "hi wake up");
            /*
             e.eid = 13341;
            e.ename = "shoaib";  		//try again
            e.salary = 1233;
          */
            Console.Read();
        
        }              
     }
}
