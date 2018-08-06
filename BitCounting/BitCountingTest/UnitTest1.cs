using System;
using BitCounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitCountingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Program.CountBits(0));
            Assert.AreEqual(1, Program.CountBits(4));
            Assert.AreEqual(3, Program.CountBits(7));
            Assert.AreEqual(2, Program.CountBits(9));
            Assert.AreEqual(2, Program.CountBits(10));
        }
    }
}
