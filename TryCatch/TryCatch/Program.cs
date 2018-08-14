using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age.");
            bool valid = false;
            int num = 0;
            try
            {
                valid = int.TryParse(Console.ReadLine(), out num);
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error you entered a number less than 1.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
