using DataStructures.Heap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Heap
{
    [TestClass]
    public class MaxHeapV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfValues_When_Heapify_Then_ShouldReturnMaxHeapDatastructure()
        {
            //Given
            var values = new int[] { 1, 2, 3, 5, 7, 8, 9 };
            var maxHeap = new MaxHeapV2(values);
            var expectedResult = new int[] { 9, 7, 8, 5, 2, 1, 3 };

            //When
            maxHeap.Heapify();

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], values[index]);
            }
        }
    }
}
