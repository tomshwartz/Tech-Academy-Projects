using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            Console.WriteLine("Enter a number");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dateTime.AddHours(hour));
            Console.ReadLine();

        }
    }
}
