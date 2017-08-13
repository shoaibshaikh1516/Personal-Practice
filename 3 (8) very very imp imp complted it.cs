using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Vehicle
    {
        protected string colors;
        protected string engineno;

        public Vehicle()
        { 
        }
        
        public void ShowVehicle(string _engineno,string _colors)
        {
            engineno=_engineno;
            colors=_colors;
        }
       
        public void show()
        {
            Console.WriteLine("colors {0} engine {1}",colors,engineno);
        }

    }
    
    enum VehicleType
    {
        TwoWheeler, 
        FourWheeler,
        ThreeWheeler
    };

    class Auto : Vehicle
    { 
        string make ;
        int price; 
        string name;
        VehicleType vt;

        public Auto()
        {}
        
        public Auto(string _make,VehicleType _vt ,int _price,string _name,string c,string en):base(c,en)
        {
                vt=_vt;
                make=_make;
                price=_price;
                name=_name;

        }
        public
        Console.WriteLine(" Name :{0}\n color {1} \n Engine no {2} \n vehicletype{3} \nMake {4} \n no of wheels:{5}\n price{6} ",);
    }

    class car : Vehicle
    {
        string make;
        int price;
        string name;
    }

    class scooter : Vehicle
    {
        string make;
        int price;
        string name;
    }





    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
