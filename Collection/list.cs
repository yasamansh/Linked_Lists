using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class list
    {
        public void ReadWriteList()
        {
            List<Employee> employees = new List<Employee> {
                new Employee{ Name = "Scott"},
                new Employee{ Name = "Alex"}
            };
            employees.Add(new Employee { Name = "Yasaman" });


            Console.WriteLine("___list.ReadWriteList___");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
