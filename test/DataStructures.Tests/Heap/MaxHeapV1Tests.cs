using DataStructures.Heap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Heap
{
    [TestClass]
    public class MaxHeapV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>
            {
                new object[] { new int[] {1, 2, 3, 8, 10}, 10},
                new object[] { new int[] {7, 5, 99, 101, 88, 176}, 176},
                new object[] { new int[] {1, 2, 3, 90, 23, 99, 10}, 99},
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_IntegerArray_When_Heapify_Then_MaximumElementShouldBeOnTop(int[] values, int expectedMaxValue)
        {
            //Given
            var maxHeap = new MaxHeapV1(values);

            //When
            maxHeap.Heapify();
            var actualValue = maxHeap.Peek();

            //Then
            Assert.AreEqual(expectedMaxValue, actualValue);
        }
    }
}
