using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    public class COnstructors
    {
        public COnstructors(int Prop) : this(Prop,"Bill")
        {

        }
        public COnstructors(int Prop, string name)
        {
            Prop1 = Prop;
            Name = name;
        }
        public int Prop1 { get; set; }
        public string Name { get; set; }

    }
}
