using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.RedBlackTree
{
    public class RedBlackTree_V1
    {
        public Node_V1 Root { get; private set; }

        public void Insert(int value)
        {
            //When : Root is null
            if (Root == null)
            {
                Root = Node_V1.CreateBlackNode(value);
                return;
            }
            //When : Root is not null
            var insertedNode = InsertNewNode(value, Root);
            Rebalance(insertedNode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        private void Rebalance(Node_V1 node)
        {
            //When : Parent is null
            if (node.Parent == null)
            {
                if (node.Color == Color.Red)
                {
                    throw new Exception("This should not happen");
                }
                return;
            }

            var parent = node.Parent;
            if (parent.Color == Color.Red && node.Color == Color.Red)
            {
                var parentSibling = GetSibling(parent);
                if (parentSibling != null)
                {
                    if (parentSibling.Color == Color.Red)
                    {
                        parent.Toggle();
                        parentSibling.Toggle();
                        Recolor(parent.Parent);
                    }
                    else
                    {
                        Rotate(node);
                    }
                    return;
                }
                Rotate(node);
            }
        }

        private void Rotate(Node_V1 node)
        {
            if (node == null || node.Parent == null || node.Parent.Parent == null)
            {
                return;
            }

            var parent = node.Parent;
            var grandParent = parent.Parent;
            var nodeDirection = node.Value > parent.Value ? "R" : "L";
            var parentDirection = parent.Value > grandParent.Value ? "R" : "L";
            var direction = $"{nodeDirection}{parentDirection}";
            switch (direction)
            {
                case Directions.RightRightDirection:
                    LeftRotate(parent, true);
                    break;
                case Directions.LeftLeftDirection:
                    RightRotate(parent, true);
                    break;
                case Directions.LeftRightDirection:
                    RightRotate(node, false);
                    LeftRotate(node, true);
                    break;
                case Directions.RightLeftDirection:
                    LeftRotate(node, false);
                    RightRotate(node, true);
                    break;
            }
            if (parent.Parent == null)
            {
                Root = parent;
            }
            else if(node.Parent == null)
            {
                Root = node;
            }
            Rebalance(parent);
        }

        private void LeftRotate(Node_V1 node, bool recolor)
        {
            if (node == null || node.Parent == null)
            {
                return;
            }
            var parent = node.Parent;
            var grandParent = node.Parent?.Parent;
            node.Parent = grandParent;
            if (grandParent != null)
            {
                if (node.Value > grandParent.Value)
                {
                    grandParent.Right = node;
                }
                else
                {
                    grandParent.Left = node;
                }
            }
            parent.Parent = node;
            parent.Right = node.Left;
            node.Left = parent;
            if (!recolor)
            {
                return;
            }
            node.Toggle();
            parent.Toggle();
        }

        private void RightRotate(Node_V1 node, bool recolor)
        {
            if (node == null || node.Parent == null)
            {
                return;
            }

            var parent = node.Parent;
            var grandParent = parent.Parent;
            node.Parent = grandParent;
            if (grandParent != null)
            {
                if (node.Value > grandParent.Value)
                {
                    grandParent.Right = node;
                }
                else
                {
                    grandParent.Left = node;
                }
            }
            parent.Parent = node;
            parent.Left = node.Right;
            node.Right = parent;
            if (!recolor)
            {
                return;
            }
            node.Toggle();
            parent.Toggle();
        }

        private void Recolor(Node_V1 node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Parent == null)
            {
                return;
            }
            node.Toggle();
            Rebalance(node);
        }

        private Node_V1 GetSibling(Node_V1 node)
        {
            if (node.Parent == null)
            {
                return null;
            }

            var parent = node.Parent;
            if (node.Value > parent.Value)
            {
                return parent.Left;
            }
            return parent.Right;
        }

        /// <summary>
        /// Inserts new node into tree
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private Node_V1 InsertNewNode(int value, Node_V1 parent)
        {
            var nodeToInsert = Node_V1.CreateRedNode(value);
            while (true)
            {
                if (value > parent.Value)
                {
                    if (parent.Right == null)
                    {
                        parent.Right = nodeToInsert;
                        nodeToInsert.Parent = parent;
                        break;
                    }
                    parent = parent.Right;
                }
                else
                {
                    if (parent.Left == null)
                    {
                        parent.Left = nodeToInsert;
                        nodeToInsert.Parent = parent;
                        break;
                    }
                    parent = parent.Left;
                }
            }
            return nodeToInsert;
        }

        public class Node_V1
        {
            public int Value { get; set; }
            public Node_V1 Parent { get; set; }
            public Node_V1 Left { get; set; }
            public Node_V1 Right { get; set; }
            public Color Color { get; set; }
            public void Toggle()
            {
                Color = Color == Color.Red ? Color.Black : Color.Red;
            }

            public static Node_V1 CreateBlackNode(int value, Node_V1 parent = null)
            {
                return new Node_V1 { Value = value, Color = Color.Black, Parent = parent };
            }

            public static Node_V1 CreateRedNode(int value, Node_V1 parent = null)
            {
                return new Node_V1 { Value = value, Color = Color.Red, Parent = null };
            }
        }
    }
}
