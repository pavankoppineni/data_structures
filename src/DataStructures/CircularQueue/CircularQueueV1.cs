using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CircularQueue
{
    /// <summary>
    /// https://www.programiz.com/dsa/circular-queue
    /// </summary>
    public class CircularQueueV1
    {
        private int end;
        private int front;
        private int[] values;
        private int length;
        private int currentLength;

        public CircularQueueV1(int length)  
        {
            this.length = length;
            this.end = -1;
            this.front = -1;
            this.values = new int[this.length];
            this.currentLength = 0;
        }

        public void EnQueue(int value)
        {
            if (currentLength == length)
            {
                throw new OverflowException();
            }
            end = (end + 1) % length;
            values[end] = value;
            if (front == -1)
            {
                front = 0;
            }
            currentLength = currentLength + 1;
        }

        public int DeQueue()
        {
            if(currentLength == 0)
            {
                throw new Exception();
            }
            var value = values[front];
            front = (front + 1) % length;
            currentLength--;
            if (currentLength == 0)
            {
                front = -1;
                end = -1;
            }
            return value;
        }
    }
}
