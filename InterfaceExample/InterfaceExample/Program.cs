using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface i1
    {
        //Interface contains only declaration of the method, there is no implementation
        void Display();
    }
    class Sample : i1
    {
        public void Display()
        {
            Console.WriteLine("Interface Display");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.Display();
            Console.ReadKey();
        }
    }
}
