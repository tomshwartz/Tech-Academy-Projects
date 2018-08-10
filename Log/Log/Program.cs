using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string num = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\User\Desktop\log.txt", true))
            {
                file.WriteLine(num);
            }
            string text = File.ReadAllText(@"C:\Users\User\Desktop\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
