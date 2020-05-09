using DataStructures.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Stack
{
    [TestClass]
    public class SampleStackTests
    {
        [TestMethod]
        public void GivenTwoItems_Push_CountShouldBeTwo()
        {
            //Arrange
            var size = 5;
            var sampleStack = new SampleStack(size);

            //Act
            sampleStack.Push(1);
            sampleStack.Push(2);

            //Assert
            Assert.AreEqual(2, sampleStack.Count);
        }

        [TestMethod]
        public void GivenStackWithFullCapacity_Push_ShouldThrowStackOverflowException()
        {
            //Arrange
            var size = 5;
            var sampleStack = new SampleStack(size);
            sampleStack.Push(1);
            sampleStack.Push(2);
            sampleStack.Push(3);
            sampleStack.Push(4);
            sampleStack.Push(5);

            //Act
            Action action = () => sampleStack.Push(6);

            //Assert
            Assert.ThrowsException<StackOverflowException>(action);
        }

        [TestMethod]
        public void GivenStackWithLengthFive_Pop_TwoItems_LengthOfStackShouldBeThree()
        {
            //Arrange
            var size = 5;
            var sampleStack = new SampleStack(size);
            sampleStack.Push(1);
            sampleStack.Push(2);
            sampleStack.Push(3);
            sampleStack.Push(4);
            sampleStack.Push(5);

            //Act
            sampleStack.Pop();
            sampleStack.Pop();

            //Assert
            Assert.AreEqual(3, sampleStack.Count);
        }

        [TestMethod]
        public void GivenStackWithLengthZero_Pop_ShouldThrowIndexOutOfRangeException()
        {
            //Arrange
            var size = 0;
            var sampleStack = new SampleStack(size);

            //Act
            Action action = () => sampleStack.Pop();

            //Assert
            Assert.ThrowsException<IndexOutOfRangeException>(action);
        }
    }
}
