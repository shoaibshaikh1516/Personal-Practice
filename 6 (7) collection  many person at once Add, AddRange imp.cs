using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication44
{
    class Person
    {
        int age;
        string name;
        public Person()
        { 
        }

        public Person(int _age,string _name) 
        {
            name = _name;
            age = _age;
        
        }

        public void ShowPerson()
        {
            Console.WriteLine("Name {0} \t Age{1} ",name,age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*
             int x=10;
              List<int> aa = new List<int>();
              aa.Add(x);
              */


            List<Person> list = new List<Person>();
            Person p=new Person(22,"shruti");
            list.Add(p);
            
            Person[] per = new Person[3] {new Person(22,"shoaib"),new Person(23,"shyam"),new Person (21,"das") };     //{11,3,1,5}
            list.AddRange(per);
            foreach (Person pi in list)
            {
                pi.ShowPerson();     
            }

            Console.ReadKey();

        }
    }
}
