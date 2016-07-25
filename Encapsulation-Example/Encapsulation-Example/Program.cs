using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Example
{
    class Sample
    {
        public int i = 10; //Integer type public variable
        private int j = 20; //Integer type private variable


        //Void type method - it doesn't return anything
        public void Display()
        {
            Console.WriteLine("Value of i is:" + i);
            Console.WriteLine("Value of j is:" + j);
        }

        public int Add()
        {
            return i + j;
        }
    }
    class Program
    {
        //Every Console Application will start from Static Void Main Method
        static void Main(string[] args)
        {
            //Creating object for the class
            Sample obj = new Sample();

            //Display method is public type so we are able to access
            obj.Display();

            //j is private type variable so we are not able to access it ,because the scope of private variables is within the class only

            Console.WriteLine("Addition of Two Numbers" + obj.Add());
            Console.ReadKey();

        }

    }
}
