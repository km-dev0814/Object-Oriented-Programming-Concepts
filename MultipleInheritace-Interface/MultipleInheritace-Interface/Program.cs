using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritace_Interface
{
    public interface Icar
    {
        int WheelsCount();
    }
    public interface IPlane
    {
        bool canFly { get; }
    }
    class SuperCar : Icar, IPlane
    {
        public int WheelsCount()
        {
            return 4;
        }

        public bool canFly
        {
            get
            {
                return true;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperCar obj = new SuperCar();
            Console.WriteLine("Aeroplain can Fly" +" "+ obj.canFly);
            Console.WriteLine("Wheels Count of Car" +" "+ obj.WheelsCount());
            Console.ReadKey();
        }
    }
}
