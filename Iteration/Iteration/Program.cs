using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        ////1
        //string[] stringArray = { "item1", "item2", "item3", "item4", "item5", "item6" };
        //Console.WriteLine("Enter text to add");
        //string text = Console.ReadLine();
        //for (int i = 0; i < stringArray.Length; i++)
        //{
        //    stringArray[i] = stringArray[i] + text;
        //}
        //for (int i = 0; i < stringArray.Length; i++)
        //{
        //    Console.WriteLine(stringArray[i]);
        //}
        //Console.ReadLine();

        ////2
        //for (int i = 0; i > -1; i++)
        //{
        //    Console.WriteLine("This is an infinite loop");
        //}
        //Console.ReadLine();

        ////3
        //for (int i = 0; i < 9; i++)
        //{
        //    Console.WriteLine("Not an infinite loop");
        //}
        //Console.ReadLine();

        ////4
        //for (int i = 0; i < 9; i++)
        //{
        //    Console.WriteLine("i is less than 9");
        //}
        //Console.ReadLine();

        ////5
        //for (int i = 0; i <= 9; i++)
        //{
        //    Console.WriteLine("i is less than or equal to 9");
        //}
        //Console.ReadLine();

        ////6
        //List<string> stringList = new List<string>();
        //stringList.Add("Entry1");
        //stringList.Add("Entry2");
        //stringList.Add("Entry3");
        //stringList.Add("Entry4");
        //stringList.Add("Entry5");
        //Console.WriteLine("Enter text to search for");
        //string search = Console.ReadLine();
        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (search == stringList[i])
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //Console.ReadLine();

        ////7
        //List<string> stringList = new List<string>();
        //int w = 0;
        //stringList.Add("Entry1");
        //stringList.Add("Entry2");
        //stringList.Add("Entry3");
        //stringList.Add("Entry4");
        //stringList.Add("Entry5");
        //Console.WriteLine("Enter text to search for");
        //string search = Console.ReadLine();
        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (search == stringList[i])
        //    {
        //        Console.WriteLine(i);
        //        w = 1;
        //    }
        //}
        //if (w == 0)
        //{
        //    Console.WriteLine(text + " does not appear in the list");
        //}
        //Console.ReadLine();

        ////8
        //List<string> stringList = new List<string>();
        //int w = 0;
        //stringList.Add("Entry1");
        //stringList.Add("Entry2");
        //stringList.Add("Entry3");
        //stringList.Add("Entry4");
        //stringList.Add("Entry5");
        //Console.WriteLine("Enter text to search for");
        //string search = Console.ReadLine();
        //for (int i = 0; i < stringList.Count; i++)
        //{
        //    if (search == stringList[i])
        //    {
        //        Console.WriteLine(i);
        //        break;
        //    }
        //}
        //if (w == 0)
        //{
        //    Console.WriteLine(text + " does not appear in the list");
        //}
        //Console.ReadLine();

        ////9
        //List<string> stringList1 = new List<string>();
        //int counter = 0;
        //stringList1.Add("Entry1");
        //stringList1.Add("Entry1");
        //stringList1.Add("Entry1");
        //stringList1.Add("Entry3");
        //stringList1.Add("Entry4");
        //stringList1.Add("Entry5");
        //Console.WriteLine("Type text to search for");
        //string text1 = Console.ReadLine();
        //for (int i = 0; i < stringList1.Count; i++)
        //{
        //    if (text1 == stringList1[i])
        //    {
        //        counter++;
        //    }
        //}
        //Console.WriteLine(counter);

        ////10
        //List<string> stringList1 = new List<string>();
        //int counter = 0;
        //stringList1.Add("Entry1");
        //stringList1.Add("Entry1");
        //stringList1.Add("Entry1");
        //stringList1.Add("Entry3");
        //stringList1.Add("Entry4");
        //stringList1.Add("Entry5");
        //Console.WriteLine("Type text to search for");
        //string text1 = Console.ReadLine();
        //for (int i = 0; i < stringList1.Count; i++)
        //{
        //    if (text1 == stringList1[i])
        //    {
        //        counter++;
        //    }
        //}
        //Console.WriteLine(text + " appears " + counter + " in the list");
        //if (counter == 0)
        //{
        //    Console.WriteLine(text + " Does not appear in the list");
        //}

        //11
        List<string> stringList2 = new List<string>();
        int c = 0;
        bool flag = false;
        stringList2.Add("Entry1");
        stringList2.Add("Entry1");
        stringList2.Add("Entry1");
        stringList2.Add("Entry3");
        stringList2.Add("Entry4");
        stringList2.Add("Entry5");
        foreach (string entry in stringList2)
        {
            //Checking for match
            for (int i = 0; i < c; i++)
            {
                if (entry == stringList2[i])
                {
                    flag = true;
                    break;
                }
            }
            c++;
            if (flag == true)
            {
                Console.WriteLine(entry + " has appeared before");
            }
            else
            {
                Console.WriteLine(entry + " has not appeared before");
            }
            flag = false;
        }
        Console.ReadLine();
















    }
}

