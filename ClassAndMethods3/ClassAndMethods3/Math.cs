using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods3
{
    class Math
    {
        public static int Add(int num1, string num2 = "")
        {
            int num;
            if (num2 == "")
            {
                num = 0;
            } else
            {
                num = Convert.ToInt16(num2);
            }
            num = num1 + num;
            return num;
        }
    }
}
