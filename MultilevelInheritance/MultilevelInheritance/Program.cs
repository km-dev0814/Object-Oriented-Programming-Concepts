using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    class HeadOffice
    {
        public void HeadOfficeAddress()
        {
            Console.WriteLine("Head Office Address");
        }
    }
    class BranchOffice : HeadOffice
    {
        public void BaranchOfficeAddress()
        {
            Console.WriteLine("Brance Office Address");
        }
    }
    class Employee : BranchOffice
    {
        public void NameOfEmployee()
        {
            Console.WriteLine("Name of Employee");
        }
        public void Salary()
        {
            Console.WriteLine("Salary of the Employee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.HeadOfficeAddress();
            objEmployee.BaranchOfficeAddress();
            objEmployee.NameOfEmployee();
            objEmployee.Salary();

            Console.ReadKey();
        }
    }
}
