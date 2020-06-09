using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public static Node Create(int value)
        {
            return new Node
            {
                Value = value
            };
        }
    }
}
