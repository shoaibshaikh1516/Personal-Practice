using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstGetSetapp
{
    class person
    {
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        long phone;

        public long Phone
        {
            get { return phone; }
            
        }


        public person(long ph)
        {
            phone = ph;
        }
        public person()
        {
            
        }


        public void show()
        {
            Console.WriteLine("name {0}  \n age {1} \n phone {2} \n ", name, age, phone);      
        }

    }
    class Program
    {
        

        static void Main(string[] args)
        {

            person p2 = new person();
            person p = new person(9874561230);
           
            p.Name = "shoaib";
            p.Age = 20;
             p.show();

            Console.WriteLine("\tsecond\n");
           
            p2.Name = "shyam";
            p2.Age = 21;
            // p.Phone = 987456123;
            p2.show();
         
            Console.ReadLine();
        }
    }
}
