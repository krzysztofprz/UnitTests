using System;
using IsThisATriangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsThisATriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.IsThisATriangle(3, 4, 5));
            Assert.IsFalse(Program.IsThisATriangle(3, 4, 10));
        }
    }
}
