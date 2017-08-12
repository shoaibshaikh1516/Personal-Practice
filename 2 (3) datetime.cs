using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    struct Student 
    {
        int rollno;
        string sname;

       

        public Student(int roll,string _name )
        {
            rollno = roll;
            sname = _name;
        }

        public void ShowRoll()
        {
            Console.WriteLine("roll no is {0}",rollno); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st=new Student();
           // st.rollno = 100;
            st.ShowRoll();

            DateTime dt = DateTime.Now;
           /* sme as
             int x=20;
              int y;
             y=x;
            */
            Console.WriteLine();
            Console.WriteLine(dt);
            Console.WriteLine(dt.AddDays(2));
            Console.WriteLine(dt.AddMonths(2));


            DateTime dt2 = DateTime.Today;
            Console.WriteLine();
            Console.WriteLine(dt2);
            Console.WriteLine(dt2.AddDays(2));
            Console.WriteLine(dt2.AddMonths(2));

            Console.WriteLine(dt2.Date);

            Console.WriteLine();
            DateTime dt3 = new DateTime(2015,5,28);
            Console.WriteLine(dt3.Date);

            Console.ReadLine();

        }
    }
}
