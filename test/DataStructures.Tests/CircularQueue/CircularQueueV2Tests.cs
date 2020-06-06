using DataStructures.CircularQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.CircularQueue
{
    [TestClass]
    public class CircularQueueV2Tests
    {
        private static IEnumerable<object[]> GetDataSet()
        {
            var dataset = new List<object[]>();

            var dataSetOne = new object[]
            {
                new List<int>{ 1, 2, 3, 4}
            };
            dataset.Add(dataSetOne);

            var dataSetTwo = new object[]
            {
                new List<int>{5, 6, 7, 8}
            };
            dataset.Add(dataSetTwo);

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSet), DynamicDataSourceType.Method)]
        public void Given_CircularQueue_When_PerformsEnQueueAndDeQueueOperations_Then(IList<int> expectedvalues)
        {
            //Given
            var length = 4;
            var circularQueue = new CircularQueueV2(length);
            var expectedValues = new List<int> { 1, 2, 3, 4 };
            foreach (var value in expectedValues)
            {
                circularQueue.EnQueue(value);
            }

            //When
            //Then
            foreach(var expectedValue in expectedValues)
            {
                var actualValue = circularQueue.DeQueue();
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
