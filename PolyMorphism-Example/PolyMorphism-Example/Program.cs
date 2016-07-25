using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism_Example
{
    class sample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            Console.WriteLine("Addition of Two Numbers" + obj.Add(4, 2));
            Console.WriteLine("Addition of Three Numbers" + obj.Add(4, 2, 1));
            Console.ReadKey();
        }
    }
}
