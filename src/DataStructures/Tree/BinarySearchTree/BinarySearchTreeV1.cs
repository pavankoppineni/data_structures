using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTreeV1
    {
        public Node Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = Node.Create(value);
                return;
            }
            else
            {
                Insert(Root, value);
            }
        }

        public void Delete(int value)
        {
            Delete(Root, value);
        }

        private Node Delete(Node node, int value)
        {
            if (value > node.Value)
            {
                node.Right = Delete(node.Right, value);
                return node;
            }
            else if (value < node.Value)
            {
                node.Left = Delete(node.Left, value);
                return node;
            }
            else
            {
                if (node.Right == null)
                {
                    return node.Left;
                }
                else if (node.Left == null)
                {
                    return node.Right;
                }
                else
                {
                    var minValue = GetMinimumValue(node.Right);
                    node.Value = minValue;
                    node.Right = Delete(node.Right, minValue);
                    return node;
                }
            }
        }

        private int GetMinimumValue(Node node)
        {
            var minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }

        private void Insert(Node node, int value)
        {
            if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = Node.Create(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
            else
            {
                if (node.Left == null)
                {
                    node.Left = Node.Create(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
        }
    }
}
