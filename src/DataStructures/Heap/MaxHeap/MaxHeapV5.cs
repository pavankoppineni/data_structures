using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heap.MaxHeap
{
    public class MaxHeapV5
    {
        private readonly int[] _values;
        private int _index;
        public MaxHeapV5(int length)
        {
            _values = new int[length];
            _index = -1;
        }

        public void Add(int value)
        {
            if (_index >= _values.Length)
            {
                return;
            }
            _index += 1;
            _values[_index] = value;
            Heapify(_index);
        }

        private void Heapify(int currentIndex)
        {
            if (currentIndex <= 0)
            {
                return;
            }

            var parentIndex = (currentIndex - 1) / 2;
            if (_values[currentIndex] > _values[parentIndex])
            {
                var temp = _values[currentIndex];
                _values[currentIndex] = _values[parentIndex];
                _values[parentIndex] = temp;
                Heapify(parentIndex);
            }
        }
    }
}
