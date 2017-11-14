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
            CircularBuffer<double> buffer = new CircularBuffer<double>(capacity);

            Console.WriteLine("Enter Buffer Element::   (For Exit enter 00)");

            var input = Console.ReadLine();

            while (input != "00")
            {
                var value = 0.0;
                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Circular Buffer Elements::   ");
            while(!buffer.IsEmpty)
                Console.WriteLine("\t" + buffer.Read());
            Console.ReadLine();
        }
    }
}
