using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class QueueV4
    {
        private readonly int length;
        private readonly int[] values;
        private int pointer;
        private int start;
        private int end;

        public  QueueV4(int length)
        {
            this.length = length;
            this.values = new int[length];
            this.pointer = -1;
            this.start = -1;
            this.end = -1;
        }

        public void EnQueue(int value)
        {
            if (end >= values.Length - 1)
            {
                throw new OverflowException();
            }

            if (end < 0)
            {
                start = 0;
                end = 0;
                values[end] = value;
                return;
            }

            end += 1;
            values[end] = value;
        }

        public int DeQueue()
        {
            if (start < 0)
            {
                throw new Exception();
            }

            var value = values[start];
            start += 1;
            if (start > end)
            {
                start = -1;
                end = -1;
            }
            return value;
        }

        public int Length
        {
            get
            {
                if (pointer < 0)
                {
                    return 0;
                }

                return pointer + 1;
            }
        }
    }
}
