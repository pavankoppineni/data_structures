using DataStructures.CircularQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.CircularQueue
{
    [TestClass]
    public class CircularQueueV3Tests
    {
        private static IEnumerable<object[]> GetDatasetForCircularQueue()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[] { 1, 2, 3, 4, 5, 6},
                    6,
                    3
                }
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDatasetForCircularQueue), DynamicDataSourceType.Method)]
        public void Given_CircularQueue_When_AddValuesAndDeleteItems_Then_ItemsDeletedShoulComeInOrder(int[] expectedValues, int length, int itemsCountToDelete)
        {
            //Given
            var queue = new CircularQueueV3(length);
            var actualValues = new List<int>();

            //When
            foreach (var value in expectedValues)
            {
                queue.EnQueue(value);
            }

            //Then
            for (var i = 0; i < itemsCountToDelete; i++)
            {
                var expectedValue = expectedValues[i];
                var actualValue = queue.DeQueue();
                Assert.AreEqual(expectedValue, actualValue);
            }

            for (var i = 0; i < itemsCountToDelete; i++)
            {
                queue.EnQueue(expectedValues[i]);
            }

            for (var i = itemsCountToDelete; i < length; i++)
            {
                var expectedValue = expectedValues[i];
                var actualValue = queue.DeQueue();
                Assert.AreEqual(expectedValue, actualValue);
            }

            for (var i = 0; i < itemsCountToDelete; i++)
            {
                var expectedValue = expectedValues[i];
                var actualValue = queue.DeQueue();
                Assert.AreEqual(expectedValue, actualValue);
            }

            Assert.ThrowsException<Exception>(() => queue.DeQueue());
        }
    }
}
