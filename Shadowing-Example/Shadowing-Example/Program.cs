using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing_Example
{
    class Sample1
    {
        public int Calculations(int a, int b)
        {
            return a + b;
        }
    }
    class Sample2 : Sample1
    {
        public new int Calculations(int a, int b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample2 obj = new Sample2();
            Console.WriteLine("Calculation Result:" + obj.Calculations(6, 4));
            Console.ReadKey();
        }
    }
}
