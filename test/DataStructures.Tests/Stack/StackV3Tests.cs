using DataStructures.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Stack
{
    [TestClass]
    public class StackV3Tests
    {
        [TestMethod]
        public void Given_EmptyStack_When_Pop_Then_ShouldThrowException()
        {
            //Given
            var size = 3;
            var stack = new StackV3(size);

            //When
            //Then
            Assert.ThrowsException<Exception>(() => stack.Pop());
        }

        [TestMethod]
        public void Given_Stack_When_PushThreeValues_Then_CountOfStackShouldBeThree()
        {
            //Given
            var size = 5;
            var stack = new StackV3(size);
            var expectedCount = 3;

            //When
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //Then
            Assert.AreEqual(expectedCount, stack.Count);
        }

        [TestMethod]
        public void Given_Stack_When_PushTheeValuesAndPopTwoValues_Then_CountShouldBeOne()
        {
            //Given
            var size = 5;
            var stack = new StackV3(size);
            var expectedCount = 1;

            //When
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();

            //Then
            Assert.AreEqual(expectedCount, stack.Count);
        }
    }
}
