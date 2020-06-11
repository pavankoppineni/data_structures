using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleEndedQueue
{
    /// <summary>
    /// https://www.programiz.com/dsa/deque
    /// </summary>
    public class DoubleEndedQueueV1
    {
        private int length;
        private int front;
        private int rear;
        private int[] values;
        
        public DoubleEndedQueueV1(int length)
        {
            this.length = length;
            this.front = -1;
            this.rear = -1;
            this.values = new int[length];
        }

        public void InsertFront(int value)
        {
            if (front == 0 && rear == length - 1)
            {
                throw new OverflowException();
            }

            if (front > 0 && rear == front + 1)
            {
                throw new OverflowException();
            }

            if (front < 0)
            {
                front = 0;
                rear = 0;
                values[front] = value;
                return;
            }

            if (front == 0)
            {
                front = length - 1;
                values[front] = value;
                return;
            }

            front -= 1;
            values[front] = value;
        }

        public void InsertRear(int value)
        {
            if (front == 0 && rear == length - 1)
            {
                throw new OverflowException();
            }

            if(front > 0 && rear == front + 1)
            {
                throw new OverflowException();
            }

            if (front < 0)
            {
                front = 0;
                rear = 0;
                values[rear] = value;
                return;
            }

            if (rear == length - 1)
            {
                rear = 0;
                values[rear] = value;
                return;
            }

            rear += 1;
            values[rear] = value;
        }

        public int DeleteFront()
        {
            if (front < 0)
            {
                throw new Exception("Queue is empty");
            }

            if (front == length - 1)
            {
                var value = values[front];
                front = 0;
                return value;
            }

            if (front == rear)
            {
                var value = values[front];
                front = -1;
                rear = -1;
                return value;
            }

            var v = values[front];
            front += 1;
            return v;
        }

        public int DeleteRear()
        {
            if (front < 0)
            {
                throw new Exception("Queue is empty");
            }

            if (rear == 0)
            {
                var value = values[rear];
                rear = length - 1;
                return value;
            }

            if (front == rear)
            {
                var value = values[rear];
                front = -1;
                rear = -1;
                return value;
            }

            var v = values[rear];
            rear -= 1;
            return v;
        }
    }
}
