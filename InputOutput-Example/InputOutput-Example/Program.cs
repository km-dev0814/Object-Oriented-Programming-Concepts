using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput_Example
{
    class Sample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Console.WriteLine("Enter Value for A:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of Two Numbers" + obj.Add(a, b));
            Console.WriteLine("Subtraction of Two Numbers" + obj.Subtract(a, b));
            Console.WriteLine("Multiplication of Two Numbers" + obj.Multiplication(a, b));
            Console.WriteLine("Division of Two Numbers" + obj.Divide(a, b));
            Console.ReadKey();
        }
    }
}
