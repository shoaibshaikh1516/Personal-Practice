using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{

    class Employee
    {

        int eid;
        string Ename;
        float salary;
        public Employee()
        { 
                  
        }
        public Employee(int eid,string _name,float _salary)
        {
            this.eid = eid;
            Ename = _name;
            salary = _salary;
        }

        public void show()
        {
            Console.WriteLine("{0}", Ename);
            Console.WriteLine("{0}", eid); 
            Console.WriteLine("{0}", salary);
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee(12, "anb", 83f);
            e.show();
            int eid=Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Employee e2 = new Employee(eid, "shoaib", 83f);
            e2.show();

           Console.ReadLine();

        }
    }
}
