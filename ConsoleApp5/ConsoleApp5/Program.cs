using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Math.Add(10, 2);
            Math.Add(num1: 2, num2: 4);
            Console.ReadLine();
        }
    }
}
