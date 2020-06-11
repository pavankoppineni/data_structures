using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTreeV2
    {
        public Node Root { get; set; }

        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }

        private Node Insert(Node node, int value)
        {
            if (node == null)
            {
                return Node.Create(value);
            }

            if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
                return node;
            }
            else
            {
                node.Left = Insert(node.Left, value);
                return node;
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
            else if(value < node.Value)
            {
                node.Left = Delete(node.Left, value);
                return node;
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }
                else
                {
                    var minimumValue = GetMinimumValue(node.Right);
                    node.Value = minimumValue;
                    node.Right = Delete(node.Right, minimumValue);
                    return node;
                }
            }
        }

        private int GetMinimumValue(Node node)
        {
            var minimumValue = node.Value;
            while (node != null)
            {
                minimumValue = node.Value;
                node = node.Left;
            }
            return minimumValue;
        }
    }
}