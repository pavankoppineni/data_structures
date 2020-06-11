using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class QueueV3
    {
        private readonly int length;
        private int[] values;
        private int front;
        private int end;

        public QueueV3(int length)
        {
            this.length = length;
            this.values = new int[length];
            this.front = -1;
            this.end = -1;
        }

        public void EnQueue(int value)
        {
            if (front == 0 && end == length - 1)
            {
                throw new OverflowException();
            }

            end = end + 1;
            values[end] = value;
            if (front < 0)
            {
                front = 0;
            }
        }

        public int DeQueue()
        {
            if (front < 0)
            {
                throw new Exception("Queue is empty");
            }

            var value = values[front];
            if (front == end)
            {
                front = -1;
                end = -1;
            }
            else
            {
                front = front + 1;
            }
            return value;
        }
    }
}
