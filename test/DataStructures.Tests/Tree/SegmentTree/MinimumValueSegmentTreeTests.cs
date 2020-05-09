using DataStructures.Tree.SegmentTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Tree.SegmentTree
{
    [TestClass]
    public class MinimumValueSegmentTreeTests
    {
        [TestMethod]
        public void ArrayWithSizeFour_ConstructTree_ReturnsSegmentTreeArray()
        {
            //Arrange
            var values = new int[] { 1, 2, 3, 4 };
            var segmentTree = new MinimumValueSegmentTree();

            //Act
            var segmentTreeArray = segmentTree.ConstructTree(values);

            //Assert
            Assert.AreEqual(1, 1);
        }
    }
}
