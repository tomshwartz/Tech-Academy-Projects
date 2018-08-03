using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndsMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Add(12);
            Console.WriteLine(num);
            decimal num1 = Math.Add(.5m);
            Console.WriteLine(num1);
            int num2 = Math.Add("10");
            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }
}
