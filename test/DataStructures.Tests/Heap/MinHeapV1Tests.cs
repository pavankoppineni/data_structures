using DataStructures.Heap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Heap
{
    [TestClass]
    public class MinHeapV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>
            {
                new object[]{ new int[] {1, 2, 3, 4, 5}, 1},
                new object[] { new int[] { 99, 101, 89, 78, 67, 0}, 0}
            };
            return dataset;
        }

        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void Given_IntegerArray_When_HeapifyAndPeek_Then_ShouldReturnMinimumValue(int[] values, int expectedValue)
        {
            //Given
            var minHeap = new MinHeapV1(values);

            //When
            minHeap.Heapify();
            var actualValue = minHeap.Peek();

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
