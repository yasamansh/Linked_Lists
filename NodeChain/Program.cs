using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeChain
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };
            Node middle = new Node { Value = 5 };

            first.Next = middle;

            Node last = new Node { Value = 7 };
            middle.Next = last;
            last.Next = null;

            printList(first);
            Console.WriteLine("----------------------"+ 11%10 +"-------------------------");
            Console.ReadLine();
        }

        private static void printList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
