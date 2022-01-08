using data_structure.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure.tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Test_Push_StackUsingLL()
        {
            StackUsingLL stack = new StackUsingLL();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(stack.Top.Value, 3);
            Assert.AreEqual(stack.Bottom.Value, 1);
        }

        [TestMethod]
        public void Test_Peek_StackUsingLL()
        {
            StackUsingLL stack = new StackUsingLL();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek();
            Assert.AreEqual(stack.Top.Value, 3);
            Assert.AreEqual(stack.Bottom.Value, 1);
            Assert.AreEqual(stack.Peek(), 3);
        }

        [TestMethod]
        public void Test_Pop_StackUsingLL()
        {
            StackUsingLL stack = new StackUsingLL();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.AreEqual(stack.Top.Value, 2);
            Assert.AreEqual(stack.Bottom.Value, 1);
        }

        [TestMethod]
        public void Test_Pop_WhenLengthIsOne_StackUsingLL()
        {
            StackUsingLL stack = new StackUsingLL();
            stack.Push(1);
            stack.Pop();
            Assert.AreEqual(stack.Pop(), -1);
        }

        [TestMethod]
        public void Test_Pop_WhenLengthIsTwo_StackUsingLL()
        {
            StackUsingLL stack = new StackUsingLL();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            Assert.AreEqual(stack.Top.Value, 1);
            Assert.AreEqual(stack.Bottom.Value, 1);
        }
    }
}