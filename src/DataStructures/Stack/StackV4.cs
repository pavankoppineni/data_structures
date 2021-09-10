using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class StackV4
    {
        private readonly int[] _values;
        private int _offset;
        public StackV4(int size)
        {
            _values = new int[size];
            _offset = -1;
        }

        public void Push(int item)
        {
            if (_offset + 1 >= _values.Length)
            {
                throw new StackOverflowException();
            }

            _offset += 1;
            _values[_offset] = item;
        }

        public int Pop()
        {
            if (_offset < 0)
            {
                throw new Exception("Stack is empty");
            }
            var item = _values[_offset];
            _offset -= 1;
            return item;
        }

        public int Count
        {
            get
            {
                if (_offset < 0)
                {
                    return 0;
                }
                return _offset + 1;
            }
        }
    }
}
