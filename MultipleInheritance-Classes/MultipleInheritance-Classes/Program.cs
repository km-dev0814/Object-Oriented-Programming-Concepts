using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance_Classes
{
    class Parent1
    {
        public void Display()
        {
            Console.WriteLine("Parent1 Display");
        }
    }
    class Parent2
    {
        public void Display()
        {
            Console.WriteLine("Parent2 Display");
        }
    }

    //By using classes we can't inmplement Multiple Inheritance
    //C#.net doesn't support Multiple Inheritancne
    //By using interfaces we can implemenet Multiple Inheritance

    class child : Parent1, Parent2
    {
        public void Display()
        {
            Console.WriteLine("Parent2 Display");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
