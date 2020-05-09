using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class SampleStack
    {
        private readonly int size;
        private readonly int[] values;
        private int currentPointer;

        public SampleStack(int size)
        {
            this.size = size;
            values = new int[size];
            currentPointer = -1;
        }

        public int Count
        {
            get
            {
                return currentPointer + 1;
            }
        }

        public void Push(int value)
        {
            if (currentPointer + 1 >= size)
            {
                throw new StackOverflowException();
            }

            currentPointer++;
            values[currentPointer] = value;
        }

        public int Pop()
        {
            if (currentPointer < 0)
            {
                throw new IndexOutOfRangeException();
            }
            var value = values[currentPointer];
            currentPointer--;
            return value;
        }
    }
}
