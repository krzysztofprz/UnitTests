using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoToOne;

namespace TwoToOneTestNUnit
{
    [TestFixture]
    public class TwoToOneTestClass
    {
        [Test]
        [MaxTime(1000)]
        public void TwoToOneTest()
        {
            Assert.AreEqual("abcd", Solution.Longest("aaab", "bcd"));
            Assert.AreEqual("xyz", Solution.Longest("xxxxy", "zzxy"));
        }

    }
}
