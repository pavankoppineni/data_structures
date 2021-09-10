using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CircularQueue
{
    public class CircularQueueV5
    {
        private readonly int[] _values;
        private int _start;
        private int _end;
        public CircularQueueV5(int size)
        {
            _values = new int[size];
            _start = -1;
            _end = -1;
        }

        public void EnQueue(int item)
        {
        }
    }
}
