using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string rate = Console.ReadLine();
            double rate1 = Convert.ToDouble(rate);
            Console.WriteLine("Hours Worked per week?");
            string hours = Console.ReadLine();
            int hours1 = Convert.ToInt16(hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            rate = Console.ReadLine();
            double rate2 = Convert.ToDouble(rate);
            Console.WriteLine("Hours Worked per week?");
            hours = Console.ReadLine();
            int hours2 = Convert.ToInt16(hours);
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(rate1 * hours1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(rate2 * hours2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool var = (rate1 * hours1) > (rate2 * hours2);
            Console.WriteLine(var);
            Console.ReadLine();
        }
    }
}
