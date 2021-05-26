using DataStructures.Tree;
using DataStructures.Tree.BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Tree.BinarySearchTree
{
    [TestClass]
    public class BinarySearchTreeV3Tests
    {
        [TestMethod]
        public void Given_BinarySearchTree_When_InsertMultipleNodes_Then_ShouldAddNodesToBinarySearchTree()
        {
            //Given
            var values = new int[] { 10, 5, 3, 7 };
            var binarySearchTree = new BinarySearchTreeV3();

            //When
            foreach (var value in values)
            {
                binarySearchTree.Insert(value);
            }

            //Then
        }
    }
}
