using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heap
{
    /// <summary>
    /// 
    /// </summary>
    public class MinHeapV1
    {
        private int[] values;
        private int length;

        public MinHeapV1(int[] values)
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
            var minIndex = index;
            var minValue = values[index];
            if (left < length)
            {
                if (minValue > values[left])
                {
                    minValue = values[left];
                    minIndex = left;
                }
            }

            if (right < length)
            {
                if (minValue > values[right])
                {
                    minValue = values[right];
                    minIndex = right;
                }
            }

            if (index != minIndex)
            {
                var temp = values[index];
                values[index] = values[minIndex];
                values[minIndex] = temp;
                Heapify(minIndex);
            }
        }
    }
}
