using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen
        string[] nameArray = { "name1", "name2", "name3", "name4", "name5" };
        Console.WriteLine("Enter an index between 0 and 4");
        int index = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(nameArray[index]);
        Console.ReadLine();

        //2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
        int[] numArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        Console.WriteLine("Enter a index between 0 and 9");
        index = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(numArray[index]);
        Console.ReadLine();

        //3. Add in a message that displays when the user selects an index that doesn’t exist.
        if (index < 0 || index > numArray.Length)
        {
            Console.WriteLine("Invalid Index");
            Console.ReadLine();
        }

        //4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
        List<string> stringList = new List<string>();
        stringList.Add("Item1");
        stringList.Add("Item2");
        stringList.Add("Item3");
        stringList.Add("Item4");
        stringList.Add("Item5");
        stringList.Add("Item6");
        stringList.Add("Item7");
        Console.WriteLine("Enter an index between 0 and 6");
        index = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(stringList[index]);
        Console.ReadLine();
    }
}
