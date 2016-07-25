using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingwihTwoClasses
{
    class Base
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Derived : Base
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived objDerived = new Derived();
            Console.WriteLine("BaseClass Add method" + objDerived.Add(4, 2));
            Console.WriteLine("DerivedClass Add method" + objDerived.Add(4, 2, 1));
            Console.ReadKey();
        }
    }
}
