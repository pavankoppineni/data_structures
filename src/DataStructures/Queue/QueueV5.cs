using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class QueueV5
    {
        private readonly int _size;
        private int _startIndex;
        private int _endIndex;
        private int[] _values;
        public QueueV5(int size)
        {
            _size = size;
            _startIndex = -1;
            _endIndex = -1;
            _values = new int[size];
        }

        public void EnQueue(int item)
        {
            if (_endIndex + 1 == _size)
            {
                throw new OverflowException();
            }

            _endIndex += 1;
            _values[_endIndex] = item;
            if(_startIndex == -1)
            {
                _startIndex = 0;
            }
        }

        public int DeQueue()
        {
            if (_endIndex == -1)
            {
                throw new Exception("Queue is empty");
            }
            var item = _values[_startIndex];
            _startIndex += 1;
            if (_startIndex > _endIndex || _endIndex == _size)
            {
                _startIndex = -1;
                _endIndex = -1;
            }
            return item;
        }
    }
}
