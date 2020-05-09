using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace DataStructures.Queue
{
    public class SampleQueue
    {
        private readonly int size;
        private int front;
        private int rear;
        private readonly int[] values;

        public SampleQueue(int size)
        {
            this.size = size;
            front = -1;
            rear = -1;
            values = new int[this.size];
        }

        public int Length
        {
            get
            {
                if (IsEmpty()) return 0;
                return rear - front + 1;
            }
        }

        private bool IsFull()
        {
            if (rear >= size - 1)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (front < 0)
            {
                return true;
            }
            return false;
        }

        public void EnQueue(int value)
        {
            if (IsFull())
            {
                throw new OverflowException();
            }
            rear++;
            values[rear] = value;
            if (front == -1)
            {
                front = 0;
            }
        }

        public int DeQueue()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            var value = values[front];
            front++;
            if (front > rear)
            {
                front = -1;
                rear = -1;
            }
            return value;
        }
    }
}
