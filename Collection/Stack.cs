using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class stack
    {
        public void ReadWriteStack()
        { 
        Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee { Name = "Alex" });
            stack.Push(new Employee { Name = "Scott"});
            stack.Push(new Employee { Name = "Yasaman"});

            Console.WriteLine("___stack.ReadWriteStack___");

            Console.WriteLine(stack.Peek().Name);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop().Name);
        }
    }
}
