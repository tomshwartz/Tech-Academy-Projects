using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            string num = Console.ReadLine();
            double num1 = Convert.ToDouble(num);
            Console.WriteLine("num*50");
            Console.WriteLine(num1 * 50);
            Console.WriteLine("num+25");
            Console.WriteLine(num1 + 25);
            Console.WriteLine("num/12.5");
            Console.WriteLine(num1 / 12.5);
            Console.WriteLine("Num is > 50");
            bool check = num1 > 50;
            Console.WriteLine(check);
            Console.WriteLine("Num remandier when divided by 7");
            Console.WriteLine(num1 % 7);
            Console.ReadLine();
        }
    }
}
