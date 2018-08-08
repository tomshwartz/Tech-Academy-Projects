using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    public class Employee
    {
        public int Id { get; set; }

        public static bool operator== (Employee employee, Employee employee1)
        {
            bool check = (employee.Id == employee1.Id);
            return check;
        }
        public static bool operator!= (Employee employee, Employee employee1)
        {
            bool check = (employee.Id == employee1.Id);
            return check;
        }
    }
}
