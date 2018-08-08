using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Empolyee<string> empolyee = new Empolyee<string>();
            empolyee.things = new List<string>();
            empolyee.things.Add("Object1");
            empolyee.things.Add("Object2");
            empolyee.things.Add("Object3");
            empolyee.things.Add("Object4");
            Empolyee<int> empolyeeInt = new Empolyee<int>();
            empolyeeInt.things = new List<int>();
            empolyeeInt.things.Add(1);
            empolyeeInt.things.Add(2);
            empolyeeInt.things.Add(3);
            empolyeeInt.things.Add(4);
           for (int i = 0; i < empolyeeInt.things.Count; i++)
            {
                Console.WriteLine(empolyeeInt.things[i]);
            }
           for (int i = 0; i < empolyee.things.Count; i++)
            {
                Console.WriteLine(empolyee.things[i]);
            }
            Console.ReadLine();
        }
    }
}
