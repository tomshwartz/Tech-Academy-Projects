using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1
{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a Day of the Week");
            try
            {
                string temp = Console.ReadLine();
                DaysOfTheWeek day1 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), temp);
                Console.WriteLine(day1);
            }
            catch
            {
                Console.WriteLine("Please Enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
