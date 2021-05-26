using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heap
{
    public class MaxHeapV4
    {
        private readonly int[] values;
        public MaxHeapV4(int[] values)
        {
            this.values = values;
        }

        public int[] Heapify()
        {
            var mid = values.Length >> 1;
            for (var index = mid; index >= 0; index--)
            {
                Heapify(index);
            }

            return values;
        }

        private void Heapify(int index)
        {
            var currentIndex = index;
            var currentMaxValue = values[index];
            var leftChildIndex = 2 * index + 1;
            if (leftChildIndex < values.Length)
            {
                var value = values[leftChildIndex];
                if (value > currentMaxValue)
                {
                    currentMaxValue = value;
                    currentIndex = leftChildIndex;
                }
            }

            var rightChildIndex = 2 * index + 2;
            if (rightChildIndex < values.Length)
            {
                var value = values[rightChildIndex];
                if (value > currentMaxValue)
                {
                    currentMaxValue = value;
                    currentIndex = rightChildIndex;
                }
            }

            if (index == currentIndex)
            {
                return;
            }

            var temp = values[index];
            values[index] = values[currentIndex];
            values[currentIndex] = temp;
            Heapify(currentIndex);
        }
    }
}
