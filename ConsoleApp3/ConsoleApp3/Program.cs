using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter weight");
        int weight = Convert.ToInt32(Console.ReadLine());
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        } else
        {
            Console.WriteLine("Please input width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input height");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input length");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            } else
            {
                int cost = (length + width + height) * weight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + cost);
                Console.ReadLine();
            }
        }
    }
}
