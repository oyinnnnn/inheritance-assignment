using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    // base class
    class Brand
    {

        public string name;

        public void display()
        {
            Console.WriteLine("I am a brand");
        }

    }

    // derived class of Brand 
    class YSL : Brand
    {

        public void getName()
        {
            Console.WriteLine("My brand name is " + name);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            // object of derived class
            YSL labrador = new YSL();

            // access field and method of base class
            labrador.name = "LV";
            labrador.display();

            // access method from own class
            labrador.getName();

            Console.ReadLine();
        }

    }
}
