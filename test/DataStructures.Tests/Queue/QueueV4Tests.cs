﻿using DataStructures.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class QueueV4Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_AddFivenElementsAndRemoveTwoElements_Then_LengthOfQueueShouldBeThree()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5 };
            var queue = new QueueV4(values.Length);
            var expectedLength = 3;

            //When
            for (var index = 0; index < values.Length; index++)
            {
                queue.EnQueue(values[index]);
            }
            queue.DeQueue();
            queue.DeQueue();

            //Then
            Assert.AreEqual(expectedLength, queue.Length);
        }
    }
}
