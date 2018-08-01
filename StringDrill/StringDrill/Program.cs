using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Concatenate three strings
        string fname = "tom";
        string mname = "wells";
        string lname = "shwartz";
        string name = fname + " " + mname + " " + lname;
        Console.WriteLine(name);
        Console.ReadLine();
        // Convert to uppercase
        name = name.ToUpper();
        Console.WriteLine(name);
        Console.ReadLine();
        //Create a StringBuilder and build a paragraph of text, one sentence at a tiem.
        StringBuilder paragraph = new StringBuilder("This is the first line.");
        Console.WriteLine(paragraph);
        paragraph.Append("This is the second line.");
        Console.WriteLine(paragraph);
        paragraph.Append("This is the third line.");
        Console.WriteLine(paragraph);
        Console.ReadLine();
    }
}
