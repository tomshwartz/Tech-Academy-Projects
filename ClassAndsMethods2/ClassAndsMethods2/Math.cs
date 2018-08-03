using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndsMethods2
{
    class Math
    {
        public static int Add(int num)
        {
            num = num + 5;
            return num;
        }

        public static decimal Add(decimal num)
        {
            num = num + .2m;
            return num;
        }

        public static int Add(string num)
        {
            int num1 = Convert.ToInt16(num);
            num1 = num1 - 5;
            return num1;
        }
    }
}
