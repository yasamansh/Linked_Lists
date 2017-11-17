using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class queue
    {
        public void ReadWriteQueue()
        {
            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee { Name = "Alex" });
            queue.Enqueue(new Employee { Name = "Scott"});
            queue.Enqueue(new Employee { Name = "Yasaman"});

            Console.WriteLine("___queue.ReadWriteQueue___");

            Console.WriteLine(queue.Peek().Name);


            Employee Yasaman = new Employee { Name = "Yasaman" };
            if (queue.Contains(Yasaman))
            {
                Console.WriteLine("Yasaman Exists!");
            }

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue().Name);
        }
    }
}
