using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heap
{
    /// <summary>
    /// https://www.geeksforgeeks.org/heap-data-structure/
    /// </summary>
    public class MaxHeapV2
    {
        private readonly int[] values;
        private readonly int length;

        public MaxHeapV2(int[] values)
        {
            this.values = values;
            this.length = values.Length;
        }

        public void Heapify()
        {
            var parent = length >> 1;
            for (var index = parent; index >= 0; index--)
            {
                Heapify(index);
            }
        }

        private void Heapify(int index)
        {
            var maxIndex = index;
            var left = 2 * maxIndex + 1;
            var right = 2 * maxIndex + 2;

            if (right < length)
            {
                if (values[left] > values[maxIndex])
                {
                    maxIndex = left;
                }
            }

            if (left < length)
            {
                if (values[right] > values[maxIndex])
                {
                    maxIndex = right;
                }
            }

            if (maxIndex == index)
            {
                return;
            }

            var temp = values[maxIndex];
            values[maxIndex] = values[index];
            values[index] = temp;

            Heapify(maxIndex);
        }
    }
}
