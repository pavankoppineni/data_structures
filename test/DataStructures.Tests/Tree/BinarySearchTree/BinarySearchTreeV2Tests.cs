using DataStructures.Tree;
using DataStructures.Tree.BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Tree.BinarySearchTree
{
    [TestClass]
    public class BinarySearchTreeV2Tests
    {
        private static IEnumerable<object[]> GetDatasetForInsertOperation()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[] { 10, 1, 17, 14, 20, 29 },
                    new int[] { 1, 10, 14, 17, 20, 29 }
                }
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDatasetForInsertOperation), DynamicDataSourceType.Method)]
        public void Given_BinarySearchTree_When_InsertValues_Then_VlauesShouldBeInserted(int[] valuesToInsert, int[] expectedValues)
        {
            //Given
            var binarySearchTree = new BinarySearchTreeV2();
            var actualValues = new List<int>();
            var stack = new Stack<Node>();

            //When
            foreach (var valueToInsert in valuesToInsert)
            {
                binarySearchTree.Insert(valueToInsert);
            }

            //Then
            //In-order traversal
            var node = binarySearchTree.Root;
            stack.Push(node);
            while (stack.Count > 0)
            {
                if (node.Left != null)
                {
                    stack.Push(node.Left);
                    node = node.Left;
                }
                else
                {
                    var currentNode = stack.Pop();
                    actualValues.Add(currentNode.Value);
                    if (currentNode.Right != null)
                    {
                        stack.Push(currentNode.Right);
                        node = currentNode.Right;
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

        private static IEnumerable<object[]> GetDatasetForNodeDeleteOperation()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[] { 10, 1, 17, 12, 29, 18, 37, 20 },
                    new int[] { 1, 10, 12, 18, 20, 29, 37 },
                    17
                },
                new object[]
                {
                    new int[] { 10, 1, 17, 12, 29, 37 },
                    new int[] { 1, 10, 12, 17, 29 },
                    37
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
            var binarySearchTree = new BinarySearchTreeV2();
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
