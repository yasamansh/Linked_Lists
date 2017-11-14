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
            CircularBuffer buffer = new CircularBuffer(10);
            buffer.Write(12);
            Console.ReadLine();
        }
    }
}
