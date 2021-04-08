using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CircularQueue
{
    public class CircularQueueV4
    {
        private int[] values;
        private int start;
        private int end;

        public CircularQueueV4(int length)
        {
            this.values = new int[length];
            this.start = -1;
            this.end = -1;
        }

        public void EnQueue(int value)
        {
            if (start < 0)
            {
                start += 1;
                end += 1;
                values[start] = value;
                return;
            }

            var newEnd = (end + 1) % values.Length;
            if (newEnd - start == 0)
            {
                throw new OverflowException();
            }

            end = newEnd;
            values[end] = value;
        }

        public int DeQueue()
        {
            //Case 1 : Check if queue is empty
            if (start < 0)
            {
                throw new Exception();
            }

            var value = values[start];
            if (start == end)
            {
                start = -1;
                end = -1;
                return values[start];
            }

            start = (start + 1) % values.Length;
            return value;
        }
    }
}
