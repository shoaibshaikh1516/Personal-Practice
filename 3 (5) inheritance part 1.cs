using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{


    class Person
    {
        string name;
        int age;
        public Person()
        { 
        }
        public Person(string _name, int age)
        {
            name = _name;
            this.age = age;
        }
        public void ShowPerson()
        {

            Console.WriteLine(" Name : {0}\n Age : {1}",name,age);
        }
    }

    class Student :Person 
    {
        int rollno;
        string subject;
        double marks;
        public Student()
        {}
        public Student(int _rollno, string sub, double mrks)
        {
            rollno = _rollno;
            subject = sub;
            marks = mrks;
        }

        public void ShowStud()
        {
            Console.WriteLine(" Roll no :{0} \n Subject : {1} \n Marks :{2}",rollno,subject,marks);

        }

                 
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person p_Obj = new Person("shoaib",20);
            p_Obj.ShowPerson();

            Student s_Obj = new Student(101,".NET",83);
            s_Obj.ShowStud();
            Console.ReadLine();

        }
    }
}
