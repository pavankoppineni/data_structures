using DataStructures.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Stack
{
    [TestClass]
    public class StackV2Tests
    {
        [TestMethod]
        public void Given_CreateStack_When_PerformPushAndPopOperations_Then()
        {
            //Given
            var length = 5;
            var stack = new StackV2(length);
            var expectedValues = new List<int> { 5, 4, 3, 2, 1 };
            foreach (var item in expectedValues)
            {
                stack.Push(item);
            }

            //When
            //Then
            for (var i = expectedValues.Count - 1; i >= 0; i--)
            {
                var actualValue = stack.Pop();
                Assert.AreEqual(actualValue, expectedValues[i]);
            }
        }
    }
}
