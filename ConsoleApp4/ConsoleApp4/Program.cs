using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        //Boolean while statement
        Console.WriteLine("How many hours did you study today?");
        int num = Convert.ToInt32(Console.ReadLine());

        while (num<8)
        {
            Console.WriteLine("Study More");
            Console.WriteLine("How many hours have you studied now?");
            num = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("You have studied enough");

        //Boolean do while statement
        Console.WriteLine("What is the tenth's place of PI?");
        int guess = Convert.ToInt32(Console.ReadLine());
        do
        {
            if (guess == 1)
            {
                Console.WriteLine("You're right.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("You're wrong try again.");
                guess = Convert.ToInt32(Console.ReadLine());
            }
        }
        while (guess != 1);

    }
}

