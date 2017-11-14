using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
    public class LinkedListNode<T>
    {
        
        // Contstructor to create a node with the value given
        public LinkedListNode(T value)
        {
            Value = value;
        }

        // The node value
        public T Value { get; set; }

        // the next Node in the LikedList (Null if the last Node)
        public LinkedListNode<T> Next { get; set; }
    }
}