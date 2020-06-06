using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CircularQueue
{
    /// <summary>
    /// https://www.programiz.com/dsa/circular-queue
    /// </summary>
    public class CircularQueueV2
    {
        private int length;
        private int[] values;
        private int front;
        private int rear;

        public CircularQueueV2(int length)
        {
            this.front = -1;
            this.rear = -1;
            this.length = length;
            this.values = new int[length];
        }

        public void EnQueue(int value)
        {
            if(front == 0 && rear == length - 1)
            {
                throw new OverflowException();
            }

            if (front == rear + 1)
            {
                throw new OverflowException();
            }

            if (rear == -1)
            {
                rear = 0;
                front = 0;
            }
            else if (rear == length - 1)
            {
                rear = 0;
            }
            else
            {
                rear += 1;
            }

            values[rear] = value;
        }

        public int DeQueue()
        {
            if (front == -1)
            {
                throw new Exception("Queue is empty");
            }

            if (front == rear)
            {
                var value = values[front];
                front = -1;
                rear = -1;
                return value;
            }

            if (front == length - 1)
            {
                var value = values[front];
                front = 0;
                return value;
            }

            var v = values[front];
            front += 1;
            return v;
        }
    }
}
