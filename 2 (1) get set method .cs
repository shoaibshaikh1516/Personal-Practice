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
            set
            {
                if (value == null)
                    Console.WriteLine("empty");
                else
                    phone = value;
            }
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
            person p = new person();
            p.Phone = 987456123;
            p.Name = "shoaib";
            p.Age = 20;

            
            p.show();

            Console.ReadLine();
        }
    }
}
