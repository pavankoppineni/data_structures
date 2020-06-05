using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class QueueV2
    {
        private int length;
        private int frontIndex;
        private int endIndex;
        private int[] values;

        public QueueV2(int length)
        {
            this.length = length;
            this.values = new int[this.length];
            this.frontIndex = -1;
            this.endIndex = -1;
        }

        public void EnQueue(int value)
        {
            if (endIndex >= length)
            {
                throw new OverflowException();
            }
            endIndex++;
            this.values[endIndex] = value;
            if (frontIndex == -1)
            {
                frontIndex = 0;
            }
        }

        public int DeQueue()
        {
            if (frontIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var value = values[frontIndex];
            frontIndex++;
            if (frontIndex > endIndex)
            {
                frontIndex = -1;
                endIndex = -1;
            }
            return value;
        }
    }
}
