using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmsTests
{
    [TestFixture]
    public class ReverseCharTest
    {
        [Test]
        public void EmptyStringTest()
        {
            var expected = "".ToCharArray();
            var actual = "".ToCharArray();
            ReverseChars.Reverse(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleCharacterStringTest()
        {
            var expected = "A".ToCharArray();
            var actual = "A".ToCharArray();
            ReverseChars.Reverse(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongerStringTest()
        {
            var expected = "EDCBA".ToCharArray();
            var actual = "ABCDE".ToCharArray();
            ReverseChars.Reverse(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
