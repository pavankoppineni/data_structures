using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heap
{
    public class MinHeapV2
    {
        private readonly int[] values;
        private readonly int length;

        public MinHeapV2(int[] values)
        {
            this.values = values;
            this.length = this.values.Length;
        }

        public void Heapify()
        {
            var parentNode = length >> 1;
            for (var index = parentNode; index >= 0; index--)
            {
                Heapify(index);
            }
        }

        private void Heapify(int index)
        {
            var minIndex = index;
            var left = 2 * minIndex + 1;
            var right = 2 * minIndex + 2;

            if (left < length)
            {
                if (values[left] < values[minIndex])
                {
                    minIndex = left;
                }
            }

            if (right < length)
            {
                if (values[right] < values[minIndex])
                {
                    minIndex = right;
                }
            }

            if (minIndex == index)
            {
                return;
            }

            var temp = values[minIndex];
            values[minIndex] = values[index];
            values[index] = temp;
            Heapify(minIndex);
        }
    }
}