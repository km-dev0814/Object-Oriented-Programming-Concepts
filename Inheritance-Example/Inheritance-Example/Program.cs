using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Sample1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Sample2 : Sample1
    {
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample2 obj = new Sample2();

            Console.WriteLine("Enter Value for A:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of Two Numbers" + obj.Add(a, b));
            Console.WriteLine("Subtraction of Two Numbers" + obj.Subtract(a, b));
            Console.ReadKey();
        }
    }
}
