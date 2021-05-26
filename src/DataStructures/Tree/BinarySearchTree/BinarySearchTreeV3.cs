using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTreeV3
    {
        public Node Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node { Value = value };
            }
            else
            {
                Insert(Root, value);
            }
        }

        private void Insert(Node currentNode, int value)
        {
            //Case 1 : When value is greater than node value
            //Action : Insert new node to right side of node
            if (value > currentNode.Value)
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = Node.Create(value);
                }
                else
                {
                    Insert(currentNode.Right, value);
                }
            }
            //Case 2 : When value is less than node value
            //Action : Insert new node to left side of current node
            else
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = Node.Create(value);
                }
                else
                {
                    Insert(currentNode.Left, value);
                }
            }
        }

        public void Delete(int value)
        {
            DeleteNode(Root, value);
        }

        private Node DeleteNode(Node node, int value)
        {
            if(node == null)
            {
                return null;
            }

            //Case 1 : When value is greater than node value
            //Action : Search right tree
            if (value > node.Value)
            {
                node.Right = DeleteNode(node.Right, value);
                return node;
            }

            //Case 2 : When value is less than node value
            //Action : Search left tree
            else if (value < node.Value)
            {
                node.Left =  DeleteNode(node.Left, value);
                return node;
            }

            //Case 3 : When value is equal to node value
            //Action : Remove node from tree
            else
            {
                if(node.Left == null)
                {
                    //Case 3A : When node is leaf node
                    //Action : Remove node
                    if (node.Right == null)
                    {
                        return null;
                    }
                }
                else
                {
                }

                return node;
            }
        }
    }
}