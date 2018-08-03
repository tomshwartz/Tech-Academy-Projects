using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Enter a number");
            int num1 = 0;
            int num = Convert.ToInt16(Console.ReadLine());
            Class1.Walk(num, out num1);
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
