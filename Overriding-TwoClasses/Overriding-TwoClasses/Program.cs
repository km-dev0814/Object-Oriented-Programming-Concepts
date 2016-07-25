using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_TwoClasses
{
    class BaseClass
    {

        //In Base Class Method we want to use Virtual Keyword
        public virtual string YourCity()
        {
            return "NewYork";
        }
    }
    class DerivedClass : BaseClass
    {
        //In Derived Class Method we want to use the Override keyword
        public override string YourCity()
        {
            return "London";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            Console.WriteLine("City:" + obj.YourCity());
            Console.ReadKey();
        }
    }
}
