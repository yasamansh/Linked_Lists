using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer
{
    public class CircularBuffer
    {
        private double[] _buffer;
        private int _start;
        private int _end;

        public CircularBuffer(int capacity)
        {
            _buffer = new double[capacity+1];
            _start = 0;
            _end = 0;
            
        }

        public void Write(double value)
        {
            Console.WriteLine("_end:: " + _end);
            _buffer[_end] = value;
            Console.WriteLine("_buffer[_end]:: " + _buffer[_end]);
            _end = (_end + 1) % _buffer.Length;
            Console.WriteLine("_end:: " + _end);
            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
                Console.WriteLine("_start:: " +_start);
            }
            Console.ReadLine();
        }

        public void Read()
        {
            int i = _buffer.Length;
            while (i > 0)
                Console.WriteLine(_buffer[i]);

        }

    }
}
