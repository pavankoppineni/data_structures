using DataStructures.RedBlackTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.RedBlackTree
{
    [TestClass]
    public class RedBlackTree_V1Tests
    {
        [TestMethod]
        public void Given_NewNode_When_AddNodeToRedBlackTree_Then_ShouldInsertNewNode()
        {
            //Given
            var redBlackTree = new RedBlackTree_V1();

            //When
            redBlackTree.Insert(10);
            redBlackTree.Insert(20);
            redBlackTree.Insert(5);

            //Then
        }
    }
}
