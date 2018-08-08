using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Check;
            Employee employee = new Employee();
            employee.Id = 1;
            Employee employee1 = new Employee();
            employee1.Id = 2;
            
            Console.WriteLine(employee == employee1);
            Console.ReadLine();
        }
    }
}
