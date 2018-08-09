using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { FirstName = "Joe", LastName = "Smith", Id = 1 },
                new Employee() { FirstName = "Joe", LastName = "Biden", Id = 2 },
                new Employee() { FirstName = "Will", LastName = "W", Id = 3 },
                new Employee() { FirstName = "Bill", LastName = "Art", Id = 4 },
                new Employee() { FirstName = "Tom", LastName = "Willis", Id = 5 },
                new Employee() { FirstName = "Sara", LastName = "Brown", Id = 6 },
                new Employee() { FirstName = "Jill", LastName = "Smith", Id = 7 },
                new Employee() { FirstName = "Phil", LastName = "Obama", Id = 8 },
                new Employee() { FirstName = "Tyler", LastName = "Jackson", Id = 9 },
                new Employee() { FirstName = "Rafa", LastName = "Smith", Id = 10 },
            };
            List<Employee> newEmployees = new List<Employee>();
            

            foreach (Employee person in employees)
            {
                if (person.FirstName == "Joe")
                {
                    newEmployees.Add(person);
                }
            }

            List<Employee> list2 = new List<Employee>();

            list2 = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> list3 = new List<Employee>();

            list3 = employees.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
