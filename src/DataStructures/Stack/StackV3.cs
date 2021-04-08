using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class StackV3
    {
        private int[] values;
        private int currentIndex = -1;
        private int size;

        public StackV3(int size)
        {
            this.size = size;
            this.values = new int[this.size];
        }

        public void Push(int value)
        {
            if(currentIndex == size)
            {
                throw new OverflowException();
            }

            currentIndex += 1;
            values[currentIndex] = value;
        }

        public int Count
        {
            get
            {
                if (currentIndex == -1)
                {
                    return 0;
                }

                return currentIndex + 1;
            }
        }

        public int Pop()
        {
            if (currentIndex == -1)
            {
                throw new Exception("Stack is Empty");
            }

            var value = values[currentIndex];
            currentIndex -= 1;
            return value;
        }
    }
}
