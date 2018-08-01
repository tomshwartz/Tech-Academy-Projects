using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);
            Console.WriteLine("Input a number to divide other by");
            int divisor = Convert.ToInt16(Console.ReadLine());
            foreach (int number in numbers)
            {
                Console.WriteLine(number / divisor);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divided by Zero Error");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number not a string");
        }
        catch
        {
            Console.WriteLine("Error please enter a whole number");
        }
        finally
        {
            Console.WriteLine("Program continued");
            Console.ReadLine();
        }
    }

}

