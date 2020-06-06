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

        private bool IsFull()
        {
            throw new NotImplementedException();
        }

        private bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void InsertFront(int value)
        {
            throw new NotImplementedException();
        }

        public void InsertRear(int value)
        {
            throw new NotImplementedException();
        }

        public int DeleteFront()
        {
            throw new NotImplementedException();
        }

        public int DeleteRear()
        {
            throw new NotImplementedException();
        }
    }
}
