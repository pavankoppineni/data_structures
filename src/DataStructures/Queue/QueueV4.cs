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

        public  QueueV4(int length)
        {
            this.length = length;
            this.values = new int[length];
            this.pointer = -1;
        }

        public void EnQueue(int value)
        {
            if (pointer >= length - 1)
            {
                throw new OverflowException();
            }

            pointer += 1;
            values[pointer] = value;
        }

        public int DeQueue()
        {
            if (pointer < 0)
            {
                throw new Exception();
            }

            var value = values[pointer];
            pointer -= 1;
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
