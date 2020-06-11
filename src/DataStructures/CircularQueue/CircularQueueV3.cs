using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CircularQueue
{
    public class CircularQueueV3
    {
        private readonly int length;
        private int[] values;
        private int end;
        private int front;

        public CircularQueueV3(int length)
        {
            this.length = length;
            this.values = new int[length];
            this.end = -1;
            this.front = -1;
        }

        public void EnQueue(int value)
        {
            if (front == 0 && end == length - 1)
            {
                throw new OverflowException();
            }

            if (front > 0 && front == end + 1)
            {
                throw new OverflowException();
            }

            if (front > 0 && end == length - 1)
            {
                end = 0;
                values[end] = value;
                return;
            }

            end += 1;
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
                return value;
            }

            if (front == length - 1)
            {
                front = 0;
                return value;
            }

            front += 1;
            return value;
        }
    }
}
