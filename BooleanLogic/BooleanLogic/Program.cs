using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt16(age);
            Console.WriteLine("Have you ever had a DUI? (True or False)");
            string DUI = Console.ReadLine();
            bool DUI1 = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticket1 = Convert.ToInt16(ticket);
            bool var = (age1 > 15) && (DUI1 = false) && (ticket1 < 4);
            Console.WriteLine(var);
            Console.ReadLine();
        }
    }
}
