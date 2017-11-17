using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class dictionary
    {
        public void readWriteDictionary()
        {
            Dictionary<string, Employee> employeesByName = new Dictionary<string, Employee>();
            employeesByName.Add("Scott", new Employee { Name = "Scott"});
            employeesByName.Add("Alex", new Employee { Name = "Alex"});
            employeesByName.Add("Yasaman", new Employee { Name = "yasaman"});

            var scott = employeesByName["Scott"];

            Console.WriteLine("employeesByName");
            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}::{1}", item.Key, item.Value.Name);
            }

            Dictionary<string, List<Employee>> employeesByDepartment = new Dictionary<string, List<Employee>>();
            employeesByDepartment.Add("HR", new List<Employee>() { new Employee { Name = "Scott" }, new Employee { Name = "Scott"}, new Employee { Name = "Yasaman"} });
            employeesByDepartment["HR"].Add(new Employee { Name = "Alex"});
            employeesByDepartment["HR"].Add(new Employee { Name = "Alex"});

            Console.WriteLine("employeesByDepartment");
            foreach (var item in employeesByDepartment)
            {
                foreach(var employee in item.Value)
                    Console.WriteLine("{0}::{1}", item.Key, employee.Name);
            }
        }
        public void sort()
        {
            var employeeByName = new SortedDictionary<string, List<Employee>>();

            employeeByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee()});
            employeeByName.Add("Engineering", new List<Employee> { new Employee(), new Employee(), new Employee(), new Employee() });

            foreach (var item in employeeByName)
            {
                Console.WriteLine("The count of employees for {0} is {1}", item.Key, item.Value.Count);
            }
        }
    }
}
