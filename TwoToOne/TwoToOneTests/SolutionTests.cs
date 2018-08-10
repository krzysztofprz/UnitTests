using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoToOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOne.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LongestTest()
        {
            Assert.AreEqual("abcd", Solution.Longest("aaab", "bcd"));
            Assert.AreEqual("xyz", Solution.Longest("xxxxy", "zzxy"));
        }
    }
}