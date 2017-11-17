using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class linkedList
    {
        public void readWriteLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            var first = linkedList.First;
            linkedList.AddAfter(first, 5);
            linkedList.AddBefore(first, 10);

            var node = linkedList.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            Console.WriteLine("********");
            linkedList.RemoveLast();

            node = linkedList.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
