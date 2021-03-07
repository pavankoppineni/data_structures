using DataStructures.Heap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Heap
{
    [TestClass]
    public class MinHeapV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Heapify_Then_ShouldGetMinHeap()
        {
            //Given
            var values = new int[] { 7, 8, 9, 15, 5, 2, 3, 1 };
            var minHeap = new MinHeapV2(values);
            var expectedResult = new int[] { 1, 5, 2, 8, 7, 9, 3, 15};

            //When
            minHeap.Heapify();

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], values[index]);
            }
        }
    }
}
