using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heap
{
    /// <summary>
    /// https://www.geeksforgeeks.org/heap-data-structure/
    /// </summary>
    public class MaxHeapV1
    {
        private int[] values;
        private int length;

        public MaxHeapV1(int[] values)
        {
            this.values = values;
            this.length = this.values.Length;
        }

        public void Heapify()
        {
            for (var i = length / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public int Peek()
        {
            return values[0];
        }

        private void Heapify(int index)
        {
            var left = 2 * index + 1;
            var right = 2 * index + 2;
            var maxIndex = index;
            var maxValue = values[index];
            if (left < length)
            {
                if (maxValue < values[left])
                {
                    maxValue = values[left];
                    maxIndex = left;
                }
            }

            if (right < length)
            {
                if (maxValue < values[right])
                {
                    maxValue = values[right];
                    maxIndex = right;
                }
            }

            if (index != maxIndex)
            {
                var temp = values[index];
                values[index] = values[maxIndex];
                values[maxIndex] = temp;
                Heapify(maxIndex);
            }
        }
    }
}
