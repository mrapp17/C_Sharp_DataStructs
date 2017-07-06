using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stack.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void PushTest()
        {
            Stack<int> testStack = new Stack<int>();
            for(int i = 0; i < 10; ++i)
            {
                testStack.Push(i);
            }
            for(int i = 9; i > 0; --i)
            {
                Assert.AreEqual(i, testStack.PopLook());
            }
        }

        [TestMethod()]
        public void SizeTest()
        {
            Stack<int> testStack = new Stack<int>();
            for(int i = 0; i < 25; ++i)
            {
                testStack.Push(i);
                Assert.AreEqual(i + 1, testStack.Size());
            }
            for (int i = 24; i > 0; --i)
            {
                testStack.Pop();
                Assert.AreEqual(i, testStack.Size());
            }
        }

        [TestMethod()]
        public void PeakTest()
        {
            Stack<int> testStack = new Stack<int>();
            for (int i = 0; i < 25; ++i)
            {
                testStack.Push(i);
                Assert.AreEqual(i, testStack.Peak());
            }
        }

        [TestMethod()]
        public void PopLookTest()
        {
            Stack<int> testStack = new Stack<int>();
            for (int i = 0; i < 25; ++i)
            {
                testStack.Push(i);
            }
            for (int i = 24; i > 0; --i)
            {
                Assert.AreEqual(i, testStack.PopLook());
            }
        }

        [TestMethod()]
        public void PopTest()
        {
            Stack<int> testStack = new Stack<int>();
            for (int i = 0; i < 25; ++i)
            {
                testStack.Push(i);
            }
            for (int i = 24; i >= 0; --i)
            {
                testStack.Pop();
                Assert.AreEqual(i, testStack.Size());
            }
            Assert.AreEqual(0, testStack.Size());
        }
    }
}