using IsThisATriangle;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisATriangleTestNUnit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void IsThisATriangleTestMethod()
        {
            Assert.IsTrue(Program.IsThisATriangle(3, 4, 5));
        }
    }
}
