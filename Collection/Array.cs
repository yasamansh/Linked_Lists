using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class array
    {
        public void ReadWriteArray()
        { 
            Employee[] employees = new Employee[2] {
                    new Employee{ Name = "Scott"},
                    new Employee{ Name = "Alex"}
                };


            Console.WriteLine("___array.ReadWriteArray___");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            Array.Resize(ref employees, 10);
        }
    }
}
