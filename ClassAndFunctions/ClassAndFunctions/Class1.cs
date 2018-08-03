using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndFunctions
{
    class Class1

    {
        public static int Add(int num1)
        {
            Console.WriteLine("How much do you want to add?");
            int num2 = Convert.ToInt16(Console.ReadLine());
            num1 = num1 + num2;
            return num1;
        }

        public static int Multiply(int num1)
        {
            Console.WriteLine("How much do you want to multiply by?");
            int num2 = Convert.ToInt16(Console.ReadLine());
            num1 = num1 * num2;
            return num1;
        }

        public static int Minus(int num1)
        {
            Console.WriteLine("How much do you want to subtract?");
            int num2 = Convert.ToInt16(Console.ReadLine());
            num1 = num1 - num2;
            return num1;
        }

    }
}
