using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFightersOneWinner;

namespace TwoFightersOneWinnerTestNUnit
{
    [TestFixture]
    public class TwoFightersOneWinnerTest
    {
        [Test]
        public void ComparingResults()
        {
            Assert.AreEqual("Jerry", Program.declareWinner(new Fighter("Harry", 13, 4), new Fighter("Jerry", 28, 3), "Jerry"));
            Assert.AreNotEqual("Henry", Program.declareWinner(new Fighter("Bill", 47, 5), new Fighter("Henry", 13, 3), "Henry"));
        }
    }
}
