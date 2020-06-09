using DataStructures.Tree;
using DataStructures.Tree.BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructures.Tests.Tree.BinarySearchTree
{
    [TestClass]
    public class BinarySearchTreeV1Tests
    {
        private static IEnumerable<object[]> GetDatasetForInsertOperation()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[] {3, 1, 5, 4, 10},
                    new int[]{1, 3, 4, 5, 10}
                },
                new object[]
                {
                    new int[] { 10, 1, 20, 15, 22},
                    new int[] { 1, 10, 15, 20, 22}
                }
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDatasetForInsertOperation), DynamicDataSourceType.Method)]
        public void Given_BinarySearchTree_When_InsertValues_Then_ValuesShouldBeInsertedIntoBinarySearchTree(int[] valuesToInsert, int[] expectedValues)
        {
            //Given
            var binarySearchTree = new BinarySearchTreeV1();
            var actualValues = new List<int>();

            //When
            foreach (var value in valuesToInsert)
            {
                binarySearchTree.Insert(value);
            }

            //Then
            //In-order traversal
            var stack = new Stack<Node>();
            var currentNode = binarySearchTree.Root;
            stack.Push(currentNode);
            while (stack.Count > 0)
            {
                if (currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                    stack.Push(currentNode);
                }
                else
                {
                    var node = stack.Pop();
                    actualValues.Add(node.Value);
                    if (node.Right != null)
                    {
                        currentNode = node.Right;
                        stack.Push(currentNode);
                    }
                }
            }
            for (var i = 0; i < expectedValues.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i]);
            }
        }

        private static IEnumerable<object[]> GetDatasetForNodeDeleteOperation()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[] { 10, 1, 17, 12, 29, 18, 37, 20 },
                    new int[] { 1, 10, 12, 18, 20, 29, 37 },
                    17
                }
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDatasetForNodeDeleteOperation), DynamicDataSourceType.Method)]
        public void Given_BinarySearchTree_When_DeleteNodeWithTwoChildNodes_Then_NodeShouldBeDeleted(int[] valuesToInsert, int[] expectedValues, int valueToDelete)
        {
            //Given
            var actualValues = new List<int>();
            var binarySearchTree = new BinarySearchTreeV1();
            foreach (var valueToInsert in valuesToInsert)
            {
                binarySearchTree.Insert(valueToInsert);
            }

            //When
            binarySearchTree.Delete(valueToDelete);

            //Then
            //In-order traversal
            var currentNode = binarySearchTree.Root;
            var stack = new Stack<Node>();
            stack.Push(currentNode);
            while (stack.Count > 0)
            {
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                    currentNode = currentNode.Left;
                }
                else
                {
                    var node = stack.Pop();
                    actualValues.Add(node.Value);
                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                        currentNode = node.Right;
                    }
                }
            }

            for (var i = 0; i < expectedValues.Length; i++)
            {
                var expectedValue = expectedValues[i];
                var actualValue = actualValues[i];
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
