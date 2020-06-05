using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class StackV2
    {
        private int index;
        private int length;
        private int[] values;

        public StackV2(int length)
        {
            this.length = length;
            this.values = new int[this.length];
            this.index = -1;
        }

        public void Push(int value)
        {
            if (index >= length)
            {
                throw new OverflowException();
            }
            index++;
            values[index] = value;
        }

        public int Pop()
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var value = values[index];
            index--;
            return value;
        }
    }
}
