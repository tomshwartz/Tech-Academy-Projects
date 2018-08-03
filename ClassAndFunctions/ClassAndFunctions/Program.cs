using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you want to Multiply, Add, or Subtract?");
            string choice = Console.ReadLine();
            if (choice == "Multiply")
            {
                num1 = Class1.Multiply(num1);
            } else if (choice == "Subtract")
            {
                num1 = Class1.Minus(num1);
            } else if (choice == "Add")
            {
                num1 = Class1.Add(num1);
            } else
            {
                Console.WriteLine("Your did not enter Multiply, Subract, or Add");
            }









            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
