using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            Int16 num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            string num2 = Console.ReadLine();


            
            Math math = new Math();
            int num = Math.Add(num1, num2);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
