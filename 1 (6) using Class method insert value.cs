using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConClassApp
{
    class Employee
    {
        public    int Eid;
        public  string Ename;
        public double salary;

        public void ShowEmp()
        {   
            Console.WriteLine("name :{0}",Ename);
            Console.WriteLine("emp id :{0}",Eid);
            Console.WriteLine("salary :{0}",salary);
            Console.WriteLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Eid = 123;
            e.Ename = "shoaib";
            e.salary=5000000.00;
            e.ShowEmp();

            Employee e1 = new Employee();
            e1.Eid = 1023;
            e1.Ename = "pavan";
            e1.salary = 50000.00;
            e1.ShowEmp();




            Console.ReadKey();
        }
    }

}

