using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularBuffer;

namespace CircularBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the apcity::  ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            CircularBuffer buffer = new CircularBuffer(capacity);

            Console.WriteLine("Enter Buffer Element::   (For Exit enter 00)");
            var input = Console.ReadLine();
            while (input != "00")
            {
                
                buffer.Write(input);
                input = Console.ReadLine();
            }

            Console.WriteLine("Circular Buffer Elements::   ");
            while(!buffer.IsEmpty)
                Console.WriteLine("\t" + buffer.Read());
            Console.ReadLine();
        }
    }
}
